using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using GoodFood.Model;
using GoodFood.Classes;

namespace GoodFood.Repository {
  public class UserRepository:IRepository<User> {
    private DataContext db;
    public UserRepository(DataContext context) {
      this.db = context;
    }
    public IEnumerable<User> Get() {
      BindingList<User> users = new BindingList<User>();
      try {
        db.User.Load();
        users = db.User.Local.ToBindingList();
        return users;
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
        return users;
      }
    }

    public void Create(User user) {
      try {
        db.User.Add(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }

    public void Update(User user) {
      try {
        db.User.Update(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }

    public void Delete(User user) {
      try {
        db.User.Remove(user);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }
  }
}
