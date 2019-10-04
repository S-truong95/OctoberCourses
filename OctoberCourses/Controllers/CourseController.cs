using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OctoberCourses.Repositories;
using OctoberCourses.Models;

namespace OctoberCourses.Controllers
{
    public class CourseController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        IRepository<Courses> courseRepo;

        public CourseController(IRepository<Courses> courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        public ViewResult Index()
        {
            //CourseRepository courseRepo = new CourseRepository();

            var model = courseRepo.GetAll();

            return View(model);

        }

        public ViewResult Details(int id)
        {
            var model = courseRepo.GetById(id);

            return View(model);
        }

    }
}