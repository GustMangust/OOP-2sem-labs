using Microsoft.EntityFrameworkCore;

namespace GoodFood.Model {
  public class RestaurantContext : DbContext {
    public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) {
      Database.EnsureCreated();
    }
    public DbSet<Restaurant> Restaurant { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
  }
}
