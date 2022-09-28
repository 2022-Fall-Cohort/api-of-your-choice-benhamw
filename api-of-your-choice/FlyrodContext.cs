using api_of_your_choice.Models;
using Microsoft.EntityFrameworkCore;
namespace api_of_your_choice
{
    public class FlyrodContext : DbContext
    {
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Flyrod> Flyrods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Flyrod;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Maker>().HasData(
                new Maker() { Id = 1, Name = "Leonard", YearFounded = 1933, Type = "Company" },
                new Maker() { Id = 2, Name = "Payne", YearFounded = 1929, Type = "Company" },
                new Maker() { Id = 3, Name = "Orvis", YearFounded = 1889, Type = "Company" },
                new Maker() { Id = 4, Name = "Uslan", YearFounded = 1933, Type = "Individual" },
                new Maker() { Id = 5, Name = "EC Powell", YearFounded = 1919, Type = "Company" },
                new Maker() { Id = 6, Name = "WE Edwards", YearFounded = 1940, Type = "Individual" },
                new Maker() { Id = 7, Name = "Browning Silaflex", YearFounded = 1970, Type = "Company" },
                new Maker() { Id = 8, Name = "Fenwick", YearFounded = 1972, Type = "Company" },
                new Maker() { Id = 9, Name = "Winston", YearFounded = 1933, Type = "Company" });
            model.Entity<Flyrod>().HasData(
                new Flyrod() { Id = 1, MakerId = 1, Model = "37H", LengthFeet = 6.0, Sections = 2, LineWeight = "WF4", YearMade = 1959, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 2, MakerId = 2, Model = "98", LengthFeet = 7.0, Sections = 2, LineWeight = "DT4", YearMade = 1962, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 3, MakerId = 3, Model = "Far and Fine", LengthFeet = 7.5, Sections = 2, LineWeight = "DT5", YearMade = 1972, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 4, MakerId = 9, Model = "SF8672", LengthFeet = 8.5, Sections = 2, LineWeight = "DT7", YearMade = 1962, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 5, MakerId = 4, Model = "7513", LengthFeet = 7.5, Sections = 2, LineWeight = "DT5", YearMade = 1955, Type = "Bamboo", Construction = "Penta" },
                new Flyrod() { Id = 6, MakerId = 5, Model = "B9", LengthFeet = 8.5, Sections = 2, LineWeight = "WF6", YearMade = 1946, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 7, MakerId = 6, Model = "37", LengthFeet = 7.5, Sections = 2, LineWeight = "WF6", YearMade = 1950, Type = "Bamboo", Construction = "Quad" },
                new Flyrod() { Id = 8, MakerId = 7, Model = "Medallion", LengthFeet = 8.5, Sections = 2, LineWeight = "DT7", YearMade = 1975, Type = "Bamboo", Construction = "Hex" },
                new Flyrod() { Id = 9, MakerId = 8, Model = "FF80", LengthFeet = 8.0, Sections = 2, LineWeight = "WF6", YearMade = 1977, Type = "Fiberglass", Construction = "Tubular" },
                new Flyrod() { Id = 10, MakerId = 3, Model = "Fullflex A", LengthFeet = 7.5, Sections = 2, LineWeight = "WF6", YearMade = 1977, Type = "Fiberglass", Construction = "Tubular" },
                new Flyrod() { Id = 11, MakerId = 9, Model = "Stalker", LengthFeet = 8.0, Sections = 2, LineWeight = "WF4", YearMade = 1979, Type = "Fiberglass", Construction = "Tubular" });
        }
    }
}
