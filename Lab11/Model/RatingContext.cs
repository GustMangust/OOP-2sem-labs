using Microsoft.EntityFrameworkCore;

namespace GoodFood.Model {
  public class RatingContext : DbContext {
    public RatingContext(DbContextOptions<RatingContext> options) : base(options) {
      Database.EnsureCreated();
    }
    public DbSet<Rating> Rating { get; set; }
  }
}
