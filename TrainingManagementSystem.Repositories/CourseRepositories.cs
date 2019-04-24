using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.DatabaseContext;
using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.Repositories
{
    public class CourseRepositories
    {
        private TrainingDbContext db;

        public CourseRepositories()
        {
            db=new TrainingDbContext();
        }

        public bool Add(Course course)
        {
            db.Courses.Add(course);
            return db.SaveChanges() > 0;
        }

        public bool Update(Course course)
        {
            db.Courses.Update(course);
            return db.SaveChanges() > 0;
        }

        public bool Remove(Course course)
        {
            db.Courses.Remove(course);
            return db.SaveChanges() > 0;
        }
    }
}
