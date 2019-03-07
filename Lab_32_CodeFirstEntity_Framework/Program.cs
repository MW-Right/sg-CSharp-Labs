using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

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
                    StudentName = "Michael Wright",
                    DateOfBirth = new DateTime(1996, 3, 6),
                    Height = 184.15M,
                    Weight = 83.2F
                };
                db.Student.Add(student01);
                db.SaveChanges();
            }
            List<Student> students = new List<Student>();
            using(var db = new CollegeContext())
            {
                students = db.Student.ToList<Student>();
            }
            students.ForEach(c => Console.WriteLine($"StudentNum: {c.StudentID}, StudentName: {c.StudentName}, DOB: {c.DateOfBirth}"));
        }
    }

    public class CollegeContext : DbContext
    {
        //Constructor methods which bounces responsibility to Entity.DbContext, to do the heavy lifting using the base keyword
        public CollegeContext() : base()
        { }

        public virtual DbSet<Student> Student { get; set; }
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
