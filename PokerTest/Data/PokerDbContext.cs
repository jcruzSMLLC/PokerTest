using PokerTest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace PokerTest.Data
{
    public class PokerDbContext : DbContext
    {
        public PokerDbContext(DbContextOptions<PokerDbContext> options) : base(options) { }

        public DbSet<Sprint> Sprints => Set<Sprint>();
        public DbSet<Story> Stories => Set<Story>();
        public DbSet<Point> Points => Set<Point>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Point>().HasData(
                new Point { Id = 1, Value = 1 },
                new Point { Id = 2, Value = 2 },
                new Point { Id = 3, Value = 3 },
                new Point { Id = 4, Value = 5 },
                new Point { Id = 5, Value = 8 },
                new Point { Id = 6, Value = 13 },
                new Point { Id = 7, Value = 21 },
                new Point { Id = 8, Value = 34 });

            modelBuilder.Entity<Story>().HasData(
                new Story { Id = 1, DevopsNumber = 14556, Title = "Mock Task #1", Notes = "Do the first mock task." },
                new Story { Id = 2, DevopsNumber = 13645, Title = "Mock Task #2", Notes = "Do the second mock task." },
                new Story { Id = 3, DevopsNumber = 15871, Title = "Mock Task #3", Notes = "Do the third mock task." },
                new Story { Id = 4, DevopsNumber = 15662, Title = "Mock Task #4", Notes = "Do the fourth mock task." },
                new Story { Id = 5, DevopsNumber = 15998, Title = "Mock Task #5", Notes = "Do the fifth mock task." });

            modelBuilder.Entity<Sprint>().HasData(
                new Sprint { Id = 1, Name = "First Sprint", StartDate = Convert.ToDateTime("1/9/2023"), EndDate = Convert.ToDateTime("1/30/2023") },
                new Sprint { Id = 2, Name = "Second Sprint", StartDate = Convert.ToDateTime("2/9/2023"), EndDate = Convert.ToDateTime("2/28/2023") },
                new Sprint { Id = 3, Name = "Third Sprint", StartDate = Convert.ToDateTime("3/9/2023"), EndDate = Convert.ToDateTime("3/30/2023") });
        }
    }
}
