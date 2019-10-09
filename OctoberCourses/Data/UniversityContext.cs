using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OctoberCourses.Models;

namespace OctoberCourses.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Courses> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=UniversityDB_062019;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
                //.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>().HasData(
                new Courses()
                {
                    Id = 1,
                    Name = "Machine Learning",
                    Description = "Machine learning for humans",
                    InstructorId = 1
                },

                new Courses()
                {
                    Id = 2,
                    Name = "C# for Smarties",
                    Description = "It's all you need to learn it all",
                    InstructorId = 1
                },

                new Courses()
                {
                    Id = 3,
                    Name = "HTML, CSS, JS, oh my!",
                    Description = "OMG, the front end will become your BFF",
                    InstructorId = 2
                });


            modelBuilder.Entity<Instructor>().HasData(
               new Instructor()
               {
                   Id = 1,
                   Name = "Jen"
               },

               new Instructor()
               {
                   Id = 2,
                   Name = "Ernest"
               });


            base.OnModelCreating(modelBuilder);
        }
    }
}

     