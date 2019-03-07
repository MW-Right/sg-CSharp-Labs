using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using Lab_121_ASP_CodeFirstEntity.Models;

namespace Lab_121_ASP_CodeFirstEntity.DAL
{
    public class StudentInitialiser : System.Data.Entity. DropCreateDatabaseIfModelChanges<CollegeContext>
    {
        protected override void Seed(CollegeContext context)
        {
            var students = new List<Student>
            {
                new Student
                {
                    StudentName = "Michael Wright",
                    DateOfBirth = new DateTime(1996, 3, 6),
                    Height = 184.15M,
                    Weight = 83.2F,
                },
                new Student
                {
                    StudentName = "Mage Hussain",
                    DateOfBirth = new DateTime(1995, 1, 5),
                    Height = 211.15M,
                    Weight = 83.2F
                },
                new Student
                {
                    StudentName = "Amira Shah",
                    DateOfBirth = new DateTime(1995, 5, 25),
                    Height = 162.00M,
                    Weight = 60,
                },
                new Student
                {
                    StudentName = "Amira Shah",
                    DateOfBirth = new DateTime(1995, 5, 25),
                    Height = 162.00M,
                    Weight = 60
                },
                new Student
                {
                    StudentName = "Jake Little",
                    DateOfBirth = new DateTime(1996, 10, 15),
                    Height = 177.50M,
                    Weight = 71.0F,
                },
                new Student
                {
                    StudentName = "Tyrone Nembhard",
                    DateOfBirth = new DateTime(1908, 12, 12),
                    Height = 203,
                    Weight = 54
                }
            };
            students.ForEach(p => context.Students.Add(p));
            context.SaveChanges();
        }
    } 
}