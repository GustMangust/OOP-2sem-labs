using GoodFood.Model;
using GoodFood.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows;

namespace GoodFood.Classes {
  public static class UnitOfWork {
    private static string StringConnection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
    private static DbContextOptionsBuilder<DataContext> optionsBuilder = new DbContextOptionsBuilder<DataContext>();
    private static DbContextOptions<DataContext> options = optionsBuilder.UseSqlServer(StringConnection).Options;
    private static DataContext db = new DataContext(options);
    private static BookingRepository bookingRepository;
    private static UserRepository userRepository;
    private static RatingRepository ratingRepository;
    private static RestaurantRepository restaurantRepository;

    public static BookingRepository Bookings {
      get {
        Refresh();
        return bookingRepository;
      }
    }
    public static RestaurantRepository Restaurants {
      get {
        Refresh();
        return restaurantRepository;
      }
    }

    public static UserRepository Users {
      get {
        Refresh();
        return userRepository;
      }
    }

    public static RatingRepository Ratings {
      get {
        Refresh();
        return ratingRepository;
      }
    }
    public static void Save() {
      db.SaveChanges();
    }

    public static void Refresh() {
      try {
        db = new DataContext(options);
        bookingRepository = new BookingRepository(db);
        userRepository = new UserRepository(db);
        ratingRepository = new RatingRepository(db);
        restaurantRepository = new RestaurantRepository(db);
      }
      catch {
        MessageBox.Show("Во время работы с базой данных произошла ошибка. Проверьте работу сервера, или попробуйте вернуться позже!");
        Application.Current.Shutdown();
      }
    }
  }
}
