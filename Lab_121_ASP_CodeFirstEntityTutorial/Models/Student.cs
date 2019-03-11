using System;
using System.Collections.Generic;
using System.Media;

namespace Lab_121_ASP_CodeFirstEntityTutorial.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Course { get; set; }
        //public  ImageString
        //{
        //    get
        //    {
        //        return $"~/Images/Profiles/{this.ID}.jpg";
        //    }
        //    set { }
        //}

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}