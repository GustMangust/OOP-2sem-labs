using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodFood.Model {
  public class DataContext:DbContext {
    public DataContext(DbContextOptions<DataContext> options)
            : base(options) {
      Database.EnsureCreated();
    }
    public DbSet<Booking> Booking { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Restaurant> Restaurant { get; set; }
    public DbSet<Rating> Rating { get; set; }
  }
}
