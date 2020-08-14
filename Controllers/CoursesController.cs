using Microsoft.AspNetCore.Mvc;

namespace MyCourse1.Controllers
{
    public class CoursesController: Controller
    {
        public IActionResult Index()
        {
            return Content("Sono Index");
        }
        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail, ho ricevuto l'id {id}");
        }


    }

}