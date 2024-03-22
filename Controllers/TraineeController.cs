using assignment.Models;
using assignment.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment.Controllers
{
    public class TraineeController : Controller
    {
        firstContext db=new firstContext();
        public IActionResult Index()
        {
            var listOfTrainees = db.Trainees.Include(t=>t.Department).ToList();
            return View(listOfTrainees);
        }

        public IActionResult Detail(int id)
        {//i can't do single first because it does immediate excute and then i can't include stuff on it
            var result = db.crsResult.Where(t => t.TraineeId == id).Include(t => t.Trainee).Include(t=>t.Course).First();
            TraineeWithCourseDegreeAndStatues x=new TraineeWithCourseDegreeAndStatues();
            x.Name=result.Trainee.Name;
            x.Id=result.Trainee.Id;
            x.degree=result.Grade;
            x.CourseName = result.Course.Name;
            if (result.Grade>=result.Course.MinDegree) {
                x.color = "green";
                ViewData["statues"] = "passed";
            }
            else
            {
                x.color = "red";
                ViewData["statues"] = "failed";
            }

            return View(x);
        }

        public IActionResult DetailCourses(int id)
        {
            List<TraineeWithCourseDegreeAndStatues> result = db.crsResult.Where(t => t.TraineeId == id)
                .Include(t => t.Trainee)
                .Include(t => t.Course)
                .Select(d => new TraineeWithCourseDegreeAndStatues()
                {
                    Name = d.Trainee.Name,
                    Id = d.Trainee.Id,
                    CourseName = d.Course.Name,
                    degree = d.Grade,
                    color = d.Grade >= d.Course.MinDegree ? "green" : "red",
                    status = d.Grade >= d.Course.MinDegree ? status.passed : status.failed
                }).ToList();

            return View(result);
        }


    }
}
