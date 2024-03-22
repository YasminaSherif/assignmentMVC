using assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment.Controllers
{
    public class Instructor : Controller
    {
        firstContext db=new firstContext();

        public IActionResult Index()
        {
            var instructors = db.instructors.ToList();
            
            return View(instructors);
        }

        public IActionResult Details(int id)
        {
            var result = db.instructors.Single(i => i.Id == id);
            return View(result);
        }
    }
}
