using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_121_ASP_CodeFirst02.Models
{
    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}