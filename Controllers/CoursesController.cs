using System;
using Microsoft.AspNetCore.Mvc;
using MyCourse1.Models.Services.Application;
using MyCourse1.Models.ViewModels;
using System.Collections.Generic;
namespace MyCourse1.Controllers
{
    public class CoursesController: Controller
    {
        private readonly ICourseService courseService;
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;

        }
        public IActionResult Index()
        {
            //l'action si limita a invocare il metodo Getcourses del servizio applicativo
            //CourseService per ottenere  una lista di CourseViewModel, che passa subito alla view
            ViewData["Title"] = "Catalogo dei corsi";
            List<CourseViewModel> courses = courseService.GetCourses();
            return View(courses);
        }
        public IActionResult Detail(int id)
        {
            var courseService = new CourseService();
            CourseDetailViewModel viewModel = courseService.GetCourse(id);
            ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }


    }

}