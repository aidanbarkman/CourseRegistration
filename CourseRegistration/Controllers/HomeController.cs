using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseRegistration.Models;


namespace CourseRegistration.Controllers
{
    public class HomeController : Controller
    {
        
   

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        public IActionResult Student()
        {
            StudentViewModel svm = new StudentViewModel();
            

            List<DTO.Student> students = new List<DTO.Student>()
            {
                new DTO.Student{ StudentId = 1, Name = "Bernard Boosle", Email = "bb@example.com", Address = "27 apple rd", PhoneNum = "204-323-2132" },
                new DTO.Student{ StudentId = 2, Name = "Ben Boosley", Email = "bb@example.com", Address = "28 apple rd", PhoneNum = "204-453-4172" },
                new DTO.Student{ StudentId = 3, Name = "Nancy Orange", Email = "no@example.com", Address = "45 park rd", PhoneNum = "204-555-2342" },

            };
            svm.Students = students;
            //_regRepo.GetStudentViewModels(svm);
            return View(svm);
        }
        public IActionResult Instructor() //
        {
            InstructorViewModel ivm = new InstructorViewModel();


            List<DTO.Instructor> instructors = new List<DTO.Instructor>()
            {
                new DTO.Instructor{ InstructorId = 1, Name = "John Newton", Email = "jn@example.com", Course = "Physics"},
                new DTO.Instructor{ InstructorId = 2, Name = "Veronica Book", Email = "vb@example.com", Course = "English" },
                new DTO.Instructor{ InstructorId = 3, Name = "Dennis Push", Email = "dp@example.com", Course = "Physical Education" },

            };
            ivm.Instructors = instructors;
            return View(ivm);
        }
        public IActionResult Course()
        {
            CourseViewModel cvm = new CourseViewModel();


            List<DTO.Course> courses = new List<DTO.Course>()
            {
                new DTO.Course{ CourseId = 1, CourseName = "Physics", CourseNumber = "712893", Description = "Learn Physics! Yay"},
                new DTO.Course{ CourseId = 2, CourseName = "English", CourseNumber = "734212", Description = "Learn About books or something" },
                new DTO.Course{ CourseId = 3, CourseName = "Physical Education", CourseNumber = "628349", Description = "Excersise Yay!" },

            };
            cvm.Courses = courses;
            return View(cvm);
        }

    }
}
