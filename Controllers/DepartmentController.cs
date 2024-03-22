using assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment.Controllers
{
    public class DepartmentController : Controller
    {
        firstContext db = new firstContext();
        public IActionResult Index()
        {
            var listOfdeps = db.Departments.ToList();
            return View(listOfdeps);
        }
        [HttpGet]
        public IActionResult save() {
        
            return View();
        }

        [HttpPost]
        public IActionResult saveData(Departments d)
        {
           if (d.Name != null) {
                db.Departments.Add(d);
                db.SaveChanges();
      
            }
              return RedirectToAction("Index");
        }
    }
}
