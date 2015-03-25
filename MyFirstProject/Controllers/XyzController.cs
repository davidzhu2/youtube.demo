using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstProject.Models;
using MyFirstProject.ViewModels;

namespace MyFirstProject.Controllers
{
    public class XyzController : Controller
    {
        private SchoolContext db = new SchoolContext();
        //
        // GET: /Xyz/

        public ActionResult Abc()
        {
            var students = db.Students.ToList();
            return View(students);
            //Course math = new Course();
            //math.CourseName = "Math 101";
            //math.TotalCredit = 4;


            //Student alex = new Student();
            //alex.FirstName = "Alex";
            //alex.LastName = "Rod";

            //Student Lynda = new Student();
            //Lynda.FirstName = "Lynda";
            //Lynda.LastName = "Rod";

            //Student john = new Student();
            //john.FirstName = "john";
            //john.LastName = "Rod";

            //List<Student> students = new List<Student>();
            //students.Add(alex);
            //students.Add(Lynda);
            //students.Add(john);

            //Course_Students obj = new Course_Students();
            //obj.course = math;
            //obj.students = students;



            //return View(obj);
        }

        public ActionResult Index()
        {

            return View();
        }
    }
}
