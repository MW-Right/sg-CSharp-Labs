using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_121_ASP_CodeFirstEntityTutorial.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int numOfStudents { get; set; }
        public string language { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}