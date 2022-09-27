using api_of_your_choice.Models;
using Microsoft.EntityFrameworkCore;
namespace api_of_your_choice
{
    public class FlyrodContext : DbContext
    {
        public DbSet<Flyrod> Flyrod { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Flyrod;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Flyrod>().HasData(
                new Flyrod() { Id = 1, Maker = "Leonard", Model = "37H", LengthFeet = 6.0, Sections = 2, LineWeight = "WF4", YearMade = 1959, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 2, Maker = "Payne", Model = "98", LengthFeet = 7.0, Sections = 2, LineWeight = "DT4", YearMade = 1962, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 3, Maker = "Orvis", Model = "Far and Fine", LengthFeet = 7.5, Sections = 2, LineWeight = "DT5", YearMade = 1972, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 4, Maker = "Uslan", Model = "7513", LengthFeet = 7.5, Sections = 2, LineWeight = "DT5", YearMade = 1955, Type = "Bamboo", Construction = "Penta" },
                new Flyrod() { Id = 5, Maker = "EC Powell", Model = "B9", LengthFeet = 8.5, Sections = 2, LineWeight = "WF6", YearMade = 1946, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 6, Maker = "WE Edwards", Model = "37", LengthFeet = 7.5, Sections = 2, LineWeight = "WF6", YearMade = 1950, Type = "Bamboo", Construction = "Quad" },
                new Flyrod() { Id = 7, Maker = "Browning", Model = "Silaflex", LengthFeet = 8.5, Sections = 2, LineWeight = "DT7", YearMade = 1975, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 8, Maker = "Fenwick", Model = "FF80", LengthFeet = 8.0, Sections = 2, LineWeight = "WF6", YearMade = 1977, Type = "Fiberglass", Construction = "Tubular" },
                new Flyrod() { Id = 9, Maker = "Winston", Model = "Stalker", LengthFeet = 8.0, Sections = 2, LineWeight = "WF4", YearMade = 1979, Type = "Fiberglass", Construction = "Tubular" });
        }
    }
}
