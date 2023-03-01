using ExaminationApp.Entities;
using ExaminationApp.EntityMappings;
using ExaminationApp.StaticData;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ExaminationApp
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<SoldBook> SoldBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookEntityMap).Assembly);
            CreateStaticData(modelBuilder);
        }

        private static void CreateStaticData(ModelBuilder builder)
        {
            StaticDataCreator.CreateBooks(builder);
            StaticDataCreator.CreateSoldBooks(builder);
        }
    }
}
