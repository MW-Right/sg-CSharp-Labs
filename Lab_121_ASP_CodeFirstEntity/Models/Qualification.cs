using Lab_121_ASP_CodeFirstEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_121_ASP_CodeFirstEntity
{
    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public virtual Student Student { get; set; }
    }
}