using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lab_121_ASP_CodeFirstEntityTutorial.Models;

namespace Lab_121_ASP_CodeFirstEntityTutorial.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Michael",LastName="Wright",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Amira",LastName="Shah",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Adam",LastName="Goddard",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Sebastian",LastName="Rodriguez",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Luke",LastName="Dawes",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Jake",LastName="Little",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="JDareen",LastName="Garces",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Maiwand",LastName="Hussain",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Aneisha",LastName="SomeComplexSpelling",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Sam",LastName="AlsoLongName",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Tyrone",LastName="Nembhard",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"},
            new Student{FirstMidName="Nadi",LastName="Adem",EnrollmentDate=DateTime.Parse("2018-12-17"), Course="Engineering 24"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1,Title="Engineering 24",numOfStudents=12, language="CSharp"},
            new Course{CourseID=2,Title="Engineering 26",numOfStudents=10, language="CSharp"},
            new Course{CourseID=3,Title="Engineering 22",numOfStudents=5, language="DevOps"},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
        }
    }
}