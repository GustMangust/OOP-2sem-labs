using GoodFood.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;

namespace GoodFood
{
    public static class DB
    {
        //private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private static string connectionString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;

        public static BindingList<Booking> GetBookings() 
        {
            BindingList<Booking> bookings = new BindingList<Booking>();
            string sqlExpression = "SELECT * FROM [Booking]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bookings.Add(new Booking(Convert.ToInt32(reader.GetValue(0)), Convert.ToInt32(reader.GetValue(1)), Convert.ToInt32(reader.GetValue(2)), Convert.ToDateTime(reader.GetValue(3)), Convert.ToInt32(reader.GetValue(4))));
                    }
                }

                reader.Close();
            }
            return bookings;
        }
        public static BindingList<Rating> GetRatings() 
        {
            BindingList<Rating> ratings = new BindingList<Rating>();
            string sqlExpression = "SELECT * FROM [Rating]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ratings.Add(new Rating(Convert.ToInt32(reader.GetValue(0)), Convert.ToInt32(reader.GetValue(1)), Convert.ToInt32(reader.GetValue(2)), Convert.ToInt32(reader.GetValue(3))));
                    }
                }
                reader.Close();
            }
            return ratings;
        }
        public static void AddBooking(int rest_id, int user_id, DateTime date,int table)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO [Booking] (Rest_ID,User_ID,DateTime,Number_of_table) VALUES ({rest_id}, {user_id},'{date}',{table})";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        public static BindingList<User> GetUsers() 
        {
            BindingList<User> users = new BindingList<User>();
            string sqlExpression = "SELECT * FROM [User]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(new User(Convert.ToInt32(reader.GetValue(0)), "" + reader.GetValue(1), "" + reader.GetValue(2), reader.GetValue(4) + "", reader.GetValue(5) + "", Convert.ToBoolean(reader.GetValue(3))));
                    }
                }
                reader.Close();
            }
            return users;
        }
        public static void AddUser(string email, string hashPass, string name,string surname) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO [User] (Email,Password,Is_admin,Name,Surname) VALUES ('{email}', '{hashPass}',{0},'{name}','{surname}')";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        public static void AddRestaurant(string name, int number_of_tables, int start,int end, string image,string type) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO [Restaurant] (Name,Number_of_tables,Start_time,End_time,Restaurant_String_Image,Type_of_cuisine) VALUES ('{name}', {number_of_tables},{start},{end},'{image}','{type}')";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        public static void AddRating(int rest_id,int user_id,int rate)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO [Rating] (Rate,User_ID,Rest_ID) VALUES ({rate}, {user_id},{rest_id})";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        public static BindingList<Restaurant> GetRestaurants()
        {
            BindingList<Restaurant> restaurants = new BindingList<Restaurant>();
            string sqlExpression = "SELECT * FROM [Restaurant]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Restaurant rest = new Restaurant(Convert.ToInt32(reader.GetValue(0)), "" + reader.GetValue(1), Convert.ToInt32(reader.GetValue(2)), Convert.ToInt32(reader.GetValue(3)), Convert.ToInt32(reader.GetValue(4)), reader.GetValue(5) + "", reader.GetValue(6) + "");
                        rest.Restaurant_Picture = new Picture();
                        rest.Restaurant_Picture.PictureString = rest.Restaurant_String_Image;
                        rest.Restaurant_ImageSource = ImageConverter.ImageSourceFromBitmap(rest.Restaurant_Picture.Source);
                        restaurants.Add(rest);
                    }
                }
                reader.Close();
            }
            return restaurants;
        }

        public static void EditRating(Rating rating)
        {
            
            string sqlExpression = $"UPDATE Rating SET Rate={rating.Rate} WHERE Rate_ID = {rating.Rate_ID} and User_ID = {rating.User_ID}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }
        public static void DeleteRating(Rating rating)
        {
            string sqlExpression = $"DELETE  FROM Rating WHERE Rate_ID = {rating.Rate_ID} and User_ID = {rating.User_ID}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
