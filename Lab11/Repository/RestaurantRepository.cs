using GoodFood.Classes;
using GoodFood.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GoodFood.Repository {
  public class RestaurantRepository:IRepository<Restaurant> {
    private DataContext db;

    public RestaurantRepository(DataContext context) {
      this.db = context;
    }

    public IEnumerable<Restaurant> Get() {
      BindingList<Restaurant> adverts = new BindingList<Restaurant>();
      try {
        db.Restaurant.Load();
        adverts = db.Restaurant.Local.ToBindingList();
        var tasks = new List<Task>();
        Parallel.ForEach(adverts, el => {
          tasks.Add(Task.Run(() =>
          {
            el.Restaurant_Picture = new Picture();
            el.Restaurant_Picture.PictureString = el.Restaurant_String_Image;
            el.Restaurant_ImageSource = ImageConverter.ImageSourceFromBitmap(el.Restaurant_Picture.Source);
            el.Restaurant_ImageSource.Freeze();
          }));
        });
        Task t = Task.WhenAll(tasks);
        t.Wait();
        return adverts;
      }

      catch(Exception e) {
        MessageBox.Show(e.Message);
        return adverts;
      }
    }
    public void Create(Model.Restaurant ad) {

      try {
        db.Restaurant.Add(ad);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.InnerException.Message);
      }
    }

    public void Update(Model.Restaurant ad) {
      try {
        db.Restaurant.Update(ad);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }

    public void Delete(Model.Restaurant ad) {
      try {
        db.Restaurant.Remove(ad);
        db.SaveChanges();
      }
      catch(Exception e) {
        MessageBox.Show(e.Message);
      }
    }
  }
}
