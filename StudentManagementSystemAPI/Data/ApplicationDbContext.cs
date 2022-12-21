using Microsoft.EntityFrameworkCore;
using StudentManagementSystemAPI.Models;

namespace StudentManagementSystemAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Grade> Grades { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = 1,
                    FirstName = "Jon",
                    LastName = "Snow",
                    Email = "jon@snow.com",
                    PasswordHash = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                    PhotoPath = "https://avatars.githubusercontent.com/u/59293768?v=4",
                    UserType = "student",

                },
                 new User()
                 {
                     UserId = 2,
                     FirstName = "Jon",
                     LastName = "Stark",
                     Email = "jon@jon.com",
                     PasswordHash = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                     PhotoPath = "https://avatars.githubusercontent.com/u/59293768?v=4",
                     UserType = "lecturer",

                 });

            modelBuilder.Entity<Grade>().HasData(
               new Grade()
               {
                   GradeId = 1,
                   LessonName = "Maths",
                   LecturerId = 2,
                   StudentId = 1,
                   Score = 78,
                   LessonDate = "monday",

               },
                new Grade()
                {
                    GradeId = 2,
                    LessonName = "Intro to CS",
                    LecturerId = 2,
                    StudentId = 1,
                    Score = 77,
                    LessonDate = "tuesday",
                });
        }

    }
}
