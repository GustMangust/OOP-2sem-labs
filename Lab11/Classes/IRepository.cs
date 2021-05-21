using GoodFood.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GoodFood.Classes {
  interface IRepository {
    BindingList<User> GetUsers();
    BindingList<Booking> GetBookings();
    BindingList<Rating> GetRatings();
    void AddBooking(int rest_id, int user_id, DateTime date, int table);
    void AddUser(string email, string hashPass, string name, string surname);
    void AddRestaurant(string name, int number_of_tables, int start, int end, string image, string type);
    void AddRating(int rest_id, int user_id, int rate);
    BindingList<Restaurant> GetRestaurants();
    BindingList<Restaurant> GetRestaurantsParam(int RestId);
    void DeleteRating(Rating rating);
    void EditRating(Rating rating);
    void DeleteBooking(Booking booking);
  }
}
