using GoodFood.Classes;
using GoodFood.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GoodFood {
  public class DB:IRepository {
    //private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    private static string connectionString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
    //private static string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    private DbContextOptionsBuilder<RatingContext> optionsBuilderRating;
    private DbContextOptionsBuilder<BookingContext> optionsBuilderBooking;
    private DbContextOptionsBuilder<RestaurantContext> optionsBuilderRestaurant;
    private DbContextOptionsBuilder<UserContext> optionsBuilderUser;
    private DbContextOptions<RestaurantContext> optionsRestaurant;
    private DbContextOptions<UserContext> optionsUser;
    private  DbContextOptions<RatingContext> optionsRating;
    private  DbContextOptions<BookingContext> optionsBooking;
    public DB(DbContextOptionsBuilder<RatingContext> a , DbContextOptionsBuilder<BookingContext> b, DbContextOptionsBuilder<RestaurantContext> c, DbContextOptionsBuilder<UserContext> d) {
      optionsBuilderRating = a;
      optionsBuilderBooking = b;
      optionsBuilderRestaurant = c;
      optionsBuilderUser = d;
      optionsRestaurant = optionsBuilderRestaurant.UseSqlServer(connectionString).Options;
      optionsUser = optionsBuilderUser.UseSqlServer(connectionString).Options;
      optionsRating = optionsBuilderRating.UseSqlServer(connectionString).Options;
      optionsBooking = optionsBuilderBooking.UseSqlServer(connectionString).Options;
    }
    public  BindingList<User> GetUsers() {
      BindingList<User> users = new BindingList<User>();
      try {
        UserContext db = new UserContext(optionsUser);
        db.User.Load();
        users = db.User.Local.ToBindingList();
        foreach(var user in users) {
          MessageBox.Show(user.Email);
        }
        return users;
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
        return users;
      }
    }
    public BindingList<Booking> GetBookings() {
      BindingList<Booking> bookings = new BindingList<Booking>();
      try {
        BookingContext db = new BookingContext(optionsBooking);
        db.Booking.Load();
        bookings = db.Booking.Local.ToBindingList();
        return bookings;
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
        return bookings;
      }
    }
    public BindingList<Rating> GetRatings() {
      BindingList<Rating> ratings = new BindingList<Rating>();
      try {
        RatingContext db = new RatingContext(optionsRating);
        db.Rating.Load();
        ratings = db.Rating.Local.ToBindingList();
        return ratings;
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
        return ratings;
      }
    }
    public void AddBooking(int rest_id, int user_id, DateTime date, int table) {
      try {
        BookingContext db = new BookingContext(optionsBooking);
        Booking booking = new Booking(rest_id, user_id, date, table);
        db.Booking.Add(booking);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }
    public void AddUser(string email, string hashPass, string name, string surname) {
      try {
        UserContext db = new UserContext(optionsUser);
        User user = new User(email, hashPass, name, surname, false);
        db.User.Add(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }
    public void AddRestaurant(string name, int number_of_tables, int start, int end, string image, string type) {
      try {
        RestaurantContext db = new RestaurantContext(optionsRestaurant);
        Restaurant rest = new Restaurant(name, number_of_tables, start, end, image, type);
        db.Restaurant.Add(rest);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }

    public void AddRating(int rest_id, int user_id, int rate) {
      try {
        RatingContext db = new RatingContext(optionsRating);
        Rating rating = new Rating(rate, user_id, rest_id);
        db.Rating.Add(rating);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }
    public BindingList<Restaurant> GetRestaurants() {
      BindingList<Restaurant> restaurants = new BindingList<Restaurant>();
      try {
        RestaurantContext db = new RestaurantContext(optionsRestaurant);
        db.Restaurant.Load();
        restaurants = db.Restaurant.Local.ToBindingList();
        var tasks = new List<Task>();
        Parallel.ForEach(restaurants, el => {
          tasks.Add(Task.Run(() => {
            el.Restaurant_Picture = new Picture();
            el.Restaurant_Picture.PictureString = el.Restaurant_String_Image;
            el.Restaurant_ImageSource = ImageConverter.ImageSourceFromBitmap(el.Restaurant_Picture.Source);
            el.Restaurant_ImageSource.Freeze();
          }));
        });
        Task t = Task.WhenAll(tasks);
        t.Wait();
        return restaurants;
      }

      catch(Exception e) {
        MessageBox.Show(e.Message);
        return restaurants;
      }
    }
    public BindingList<Restaurant> GetRestaurantsParam(int RestId) {
      BindingList<Restaurant> list = new BindingList<Restaurant>();
      try {
        RestaurantContext db = new RestaurantContext(optionsRestaurant);
        db.Restaurant.Load();
        var restaurants = db.Restaurants.Where(x => x.Rest_ID == RestId);
        var tasks = new List<Task>();
        Parallel.ForEach(restaurants, el => {
          tasks.Add(Task.Run(() => {
            el.Restaurant_Picture = new Picture();
            el.Restaurant_Picture.PictureString = el.Restaurant_String_Image;
            el.Restaurant_ImageSource = ImageConverter.ImageSourceFromBitmap(el.Restaurant_Picture.Source);
            el.Restaurant_ImageSource.Freeze();
          }));
        });
        Task t = Task.WhenAll(tasks);
        t.Wait();
        foreach(var item in restaurants) {
          list.Add(item);
        }
        return list;
      }

      catch(Exception e) {
        MessageBox.Show(e.Message);
        return list;
        ;
      }
    }
    public void DeleteRating(Rating rating) {
      try {
        RatingContext db = new RatingContext(optionsRating);
        db.Rating.Remove(rating);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }
    public void EditRating(Rating rating) {
      RatingContext db = new RatingContext(optionsRating);
      using(var transaction = db.Database.BeginTransaction()) {
        try {
          db.Rating.Update(rating);
          db.SaveChanges();
          transaction.Commit();
        }
        catch(Exception e) {
          MessageBox.Show(e.Message);
          transaction.Rollback();
        }

      }
    }
    public void DeleteBooking(Booking booking) {
      try {
        BookingContext db = new BookingContext(optionsBooking);
        db.Booking.Remove(booking);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }
  }
}
