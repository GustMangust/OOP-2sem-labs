using GoodFood.Classes;
using GoodFood.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace GoodFood.Repository {
  public class RatingRepository:IRepository<Rating> {
    private DataContext db;

    public RatingRepository(DataContext context) {
      this.db = context;
    }

    public IEnumerable<Rating> Get() {
      BindingList<Rating> users = new BindingList<Rating>();
      try {
        db.Rating.Load();
        users = db.Rating.Local.ToBindingList();
        return users;
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
        return users;
      }
    }

    public void Create(Rating user) {
      try {
        db.Rating.Add(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }

    public void Update(Rating user) {
      try {
        db.Rating.Update(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }

    public void Delete(Rating user) {
      try {
        db.Rating.Remove(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }
  }
}
