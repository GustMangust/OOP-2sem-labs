using GoodFood.Classes;
using GoodFood.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text;
using System.Windows;

namespace GoodFood.Repository {
  public class BookingRepository:IRepository<Booking> {
    private DataContext db;
    public BookingRepository(DataContext context) {
      this.db = context;
    }
    public IEnumerable<Booking> Get() {
      BindingList<Booking> bookings = new BindingList<Booking>();
      try {
        db.Booking.Load();
        bookings = db.Booking.Local.ToBindingList();
        return bookings;
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
        return bookings;
      }
    }

    public void Create(Booking user) {
      try {
        db.Booking.Add(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }

    public void Update(Booking user) {
      try {
        db.Booking.Update(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }

    public void Delete(Booking user) {
      try {
        db.Booking.Remove(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }
  }
}
