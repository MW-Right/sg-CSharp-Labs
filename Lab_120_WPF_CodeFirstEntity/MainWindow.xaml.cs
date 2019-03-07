using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Lab_120_WPF_CodeFirstEntity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Student stud = new Student();
        public static List<string> sdl = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        public void Initialise()
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
                Student student02 = new Student
                {
                    StudentName = "Mage Hussain",
                    DateOfBirth = new DateTime(1995, 1, 5),
                    Height = 211.15M,
                    Weight = 83.2F
                };
              
                db.Student.Add(student01);
                db.Student.Add(student02);
                db.SaveChanges();
            }
            List<Student> students = new List<Student>();
            using (var db = new CollegeContext())
            {
                students = db.Student.ToList<Student>();
            }
            students.ForEach(c => Console.WriteLine($"StudentNum: {c.StudentID}, StudentName: {c.StudentName}, DOB: {c.DateOfBirth}"));
            studentList.ItemsSource = students;
            studentList.DisplayMemberPath = "StudentName";
        }

        private void StudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stud = studentList.SelectedItem as Student;
            StudentText.Text = stud.StudentName.ToString();
            sdl.Clear();
            sdl.Add($"ID: {stud.StudentID}");
            sdl.Add($"Name: {stud.StudentName}");
            sdl.Add($"DOB: {stud.DateOfBirth}");
            sdl.Add($"Height: {stud.Height}");
            sdl.Add($"Weight: {stud.Weight}");
            studentDetailsList.ItemsSource = sdl;
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