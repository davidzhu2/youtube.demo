using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstProject.Models;

namespace MyFirstProject.ViewModels
{
    public class Course_Students
    {
        //View Models
        public Course course { get; set; }
        public List<Student> students { get; set; }
    }
}