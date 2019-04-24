using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingManagementSystem.Managers;
using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        private CourseManager _courseManager;

        public CourseController()
        {
            _courseManager = new CourseManager();
        }
        [HttpGet]
        public IActionResult CourseView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CourseView(Course entity)
        {
            if (ModelState.IsValid)
            {
                _courseManager.Add(entity);
               
            }
            ModelState.Clear();
            return View();
        }
    }
}