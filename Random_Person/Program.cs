using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Random_Person
{
    class Program
    {
        public static void ThreadStartMethod()
        {}
        static void Main(string[] args)
        {
            string[] firstNameArr = new string[] { "Michael", "Maiwand", "Jake", "Desmond", "Adam", "Jdareen", "Seb", "Nadi", "Amira", "Aneisha" };
            string[] lastNameArr = new string[] { "Wright", "Hussain", "Little", "Nembhard", "Goddard", "Garces", "Rodriguez", "Adem", "Shah", "Mallikaratchy" };
            List<object> nameList = new List<object>();
            Random rnd = new Random();
            ThreadStart thStart = new ThreadStart(ThreadStartMethod);
            Thread th = new Thread(thStart);
            th.Start();
            for (int i = 0; i < 10; i++)
            {
                int fnPick = rnd.Next(0, 10);
                int lnPick = rnd.Next(0, 10);
                Parent person = new Parent(firstNameArr[fnPick], lastNameArr[lnPick]);
                nameList.Add(person);
                Console.WriteLine($"Hello, my name is {person.FirstName} {person.LastName} and I was born on {person.Dob} which means I am {person.Age} years old.");
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
    class Parent
    {
        string firstName;
        string lastName;
        int age;
        public string dob;

        public Parent()
        {

        }
        public Parent(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = DateOfBirthGen(out age);
            this.Age = age;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Dob { get => dob; set => dob = value; }

        static string DateOfBirthGen(out int age)
        {
            int year;
            int day = 0;
            int month = 1;
            Random rnd = new Random();
            year = rnd.Next(1900, 2018);
            month = rnd.Next(1, 12);
            if (month == 2 && year % 4 == 0)
            {
                day = rnd.Next(1, 29);
            }
            else if (month == 2)
            {
                day = rnd.Next(1, 28);
            }
            else if (new[] { 4, 6, 9, 11 }.Contains(month))
            {
                day = rnd.Next(1, 30);
            }
            else if (new[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(month))
            {
                day = rnd.Next(1, 31);
            }

            //Working out the age
            int ageCalc = 0;
            if (DateTime.Now.Month > month)
            {
                ageCalc = DateTime.Now.Year - year;
            }
            else if (DateTime.Now.Month < month)
            {
                ageCalc = DateTime.Now.Year - year - 1;
            }
            else if (DateTime.Now.Month == month)
            {
                if (DateTime.Now.Day < day)
                {
                    ageCalc = DateTime.Now.Year - year - 1;
                }
                else if (DateTime.Now.Day >= day)
                {
                    ageCalc = DateTime.Now.Year - year;
                }
            }
            age = ageCalc;
            return $"{day.ToString("D2")}/{month.ToString("D2")}/{year}";
        }
    }
}
