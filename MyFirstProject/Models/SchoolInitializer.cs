using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    public class SchoolInitializer:DropCreateDatabaseIfModelChanges<SchoolContext >
    {
        protected override void Seed(SchoolContext context)
        {
            // base.Seed(context);
            var students = new List<Student>
            {
                new Student{FirstName = "James", LastName ="Dean", EnrollmentDate = DateTime.Parse ("2014-01-08")},
                new Student{FirstName = "Lynda", LastName ="Dean", EnrollmentDate = DateTime.Parse ("2014-01-08") }, 
                new Student{FirstName = "David", LastName ="Dean", EnrollmentDate = DateTime.Parse ("2014-01-08")}

            };

            foreach (var temp in students )
            {
                context.Students.Add (temp);
            }
            context.SaveChanges ();

            var courses = new List<Course>
            {
                new Course {CourseName ="Java", TotalCredits =4},
                new Course {CourseName ="C#", TotalCredits =4}

            };

            foreach (var temp in courses)
            {
                context.Courses.Add(temp);
            }
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentId =1 , CourseId =1, Grade =3},
                new Enrollment{StudentId =1 , CourseId =1, Grade =4}

            };
            foreach (var temp in enrollments )
            {
                context.Enrollments.Add(temp);
            }
            context.SaveChanges();
        }
    }
}
