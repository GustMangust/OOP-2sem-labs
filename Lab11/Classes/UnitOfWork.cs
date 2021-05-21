using GoodFood.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace GoodFood.Classes {
  public static class UnitOfWork {
    private static DbContextOptionsBuilder<RatingContext> optionsBuilderRating = new DbContextOptionsBuilder<RatingContext>();
    private static DbContextOptionsBuilder<BookingContext> optionsBuilderBooking = new DbContextOptionsBuilder<BookingContext>();
    private static DbContextOptionsBuilder<RestaurantContext> optionsBuilderRestaurant = new DbContextOptionsBuilder<RestaurantContext>();
    private static DbContextOptionsBuilder<UserContext> optionsBuilderUser = new DbContextOptionsBuilder<UserContext>();
    private static DB db;
    static UnitOfWork() {
      optionsBuilderRating = new DbContextOptionsBuilder<RatingContext>();
      optionsBuilderBooking = new DbContextOptionsBuilder<BookingContext>();
      optionsBuilderRestaurant = new DbContextOptionsBuilder<RestaurantContext>();
      optionsBuilderUser = new DbContextOptionsBuilder<UserContext>();
      db = new DB(optionsBuilderRating, optionsBuilderBooking, optionsBuilderRestaurant, optionsBuilderUser);
    }
    public static BindingList<User> GetUsers() {
      return db.GetUsers();
    }
    public static BindingList<Booking> GetBookings() {
      return db.GetBookings();
    }
    public static BindingList<Rating> GetRatings() {
      return db.GetRatings();
    }
    public static void AddBooking(int rest_id, int user_id, DateTime date, int table) {
      db.AddBooking(rest_id, user_id, date, table);
    }
    public static void AddUser(string email, string hashPass, string name, string surname) {
      db.AddUser(email, hashPass, name, surname);
    }
    public static void AddRestaurant(string name, int number_of_tables, int start, int end, string image, string type) {
      db.AddRestaurant(name, number_of_tables, start, end, image, type);
    }
    public static void AddRating(int rest_id, int user_id, int rate) {
      db.AddRating(rest_id, user_id, rate);
    }
    public static BindingList<Restaurant> GetRestaurants() {
      return db.GetRestaurants();
    }
    public static BindingList<Restaurant> GetRestaurantsParam(int RestId) {
      return db.GetRestaurantsParam(RestId);
    }
    public static void DeleteRating(Rating rating) {
      db.DeleteRating(rating);
    }
    public static void EditRating(Rating rating) {
      db.EditRating(rating);
    }
    public static void DeleteBooking(Booking booking) {
      db.DeleteBooking(booking);
    }
  }
}
