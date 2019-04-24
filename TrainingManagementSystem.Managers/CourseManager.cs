using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Managers.Base;
using TrainingManagementSystem.Managers.Contracts;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories;
using TrainingManagementSystem.Repositories.Base;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Managers
{
    public class CourseManager:BaseManager<Course>,ICourseManager
    {
        private ICourseRepository _courseRepository;

        public CourseManager(ICourseRepository courseRepository):base(courseRepository)
        {
            _courseRepository = courseRepository;
        }
    }
}
