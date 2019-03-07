using System;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core;
using System.Collections.Generic;

namespace Lab_32_CodeFirstDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CollegeContext())
            {
                Student student01 = new Student
                {
                    StudentID = 001,
                    StudentName = "Michael Wright",
                    DateOfBirth = new DateTime(1996, 3, 6),
                    Height = 184.15M,
                    Weight = 83.2F
                };
                Console.WriteLine($"StudentNum: {student01.StudentID}, StudentName: {student01.StudentName}, DOB: {student01.DateOfBirth}");
            }
        }
    }

    public class CollegeContext : DbContext
    {
        //Constructor methods which bounces responsibility to Entity.DbContext, to do the heavy lifting using the base keyword
        public CollegeContext() : base()
        { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Qualification Qualification { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
