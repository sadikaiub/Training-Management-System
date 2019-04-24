using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.DatabaseContext
{
    public class TrainingDbContext:DbContext
    {
        public TrainingDbContext()
        {
            
        }

        public TrainingDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer("Server=(local);Database=TrainingDb;Integrated Security=true");
         }
    }
}
