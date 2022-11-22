using ASP_MVC_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC_EntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    Name = "Kalle Person",
                    PhoneNumber = "555-5555",
                    City = "Gothenburg"
                },
                new Person
                {
                    Id = 2,
                    Name = "Stina Bratt",
                    PhoneNumber = "555-5555",
                    City = "Gothenburg"
                },
                new Person
                {
                    Id = 3,
                    Name = "Jennie Antonsson",
                    PhoneNumber = "444-4444",
                    City = "Paris"
                },
                new Person
                {
                    Id = 4,
                    Name = "Sven Karlsson",
                    PhoneNumber = "888-8888",
                    City = "London"
                },
                new Person
                {
                    Id = 5,
                    Name = "Katarina Fors",
                    PhoneNumber = "999-9999",
                    City = "Stockholm"
                },
                new Person
                {
                    Id = 6,
                    Name = "Wendely Blom",
                    PhoneNumber = "222-2222",
                    City = "Warsaw"
                },
                new Person
                {
                    Id = 7,
                    Name = "Hugo Magnusson",
                    PhoneNumber = "444-2222",
                    City = "Munich"
                },
                new Person
                {
                    Id = 8,
                    Name = "Alice Olsson",
                    PhoneNumber = "111-1111",
                    City = "Bangkok"
                },
                new Person
                {
                    Id = 9,
                    Name = "Belly Button",
                    PhoneNumber = "000-4444",
                    City = "Vladivostok"
                },
                new Person
                {
                    Id = 10,
                    Name = "Tom Andersson",
                    PhoneNumber = "999-7777",
                    City = "Buenos Aires"
                },
                new Person
                {
                    Id = 11,
                    Name = "Alma Starstruck",
                    PhoneNumber = "888-4444",
                    City = "Hanoi"
                });
        }
    }
}
