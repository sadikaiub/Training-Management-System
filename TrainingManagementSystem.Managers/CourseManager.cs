using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories;

namespace TrainingManagementSystem.Managers
{
    public class CourseManager
    {
        private CourseRepositories _courseRepositories;

        public CourseManager()
        {
            _courseRepositories=new CourseRepositories();
        }

        public bool Add(Course course)
        {
           return _courseRepositories.Add(course);
        }
        public bool Update(Course course)
        {
            return _courseRepositories.Update(course);
        }
        public bool Remove(Course course)
        {
            return _courseRepositories.Remove(course);
        }

    }
}
