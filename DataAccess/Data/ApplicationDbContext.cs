using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // To create a table on the database
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateOnly.TryParse("12/08/02", out DateOnly dateOfBirth);

            modelBuilder.Entity<Student>().HasData(
                new Student(Id: 1, FirstName: "Nathaniel", LastName: "Alvarez", DateOfBirth: dateOfBirth, Address: "Manila, Philippines", ProfilePicture: ""),
                new Student(Id: 2, FirstName: "Alyssa", LastName: "Gonzales", DateOfBirth: dateOfBirth, Address: "Quezon City, Philippines", ProfilePicture: ""),
                new Student(Id: 3, FirstName: "Joshua", LastName: "Reyes", DateOfBirth: dateOfBirth, Address: "Cebu City, Philippines", ProfilePicture: ""),
                new Student(Id: 4, FirstName: "Isabella", LastName: "Santos", DateOfBirth: dateOfBirth, Address: "Davao City, Philippines", ProfilePicture: ""),
                new Student(Id: 5, FirstName: "Miguel", LastName: "Torres", DateOfBirth: dateOfBirth, Address: "Makati, Philippines", ProfilePicture: ""),
                new Student(Id: 6, FirstName: "Sophia", LastName: "Cruz", DateOfBirth: dateOfBirth, Address: "Pasig, Philippines", ProfilePicture: "")
            );
        }


    }
}
