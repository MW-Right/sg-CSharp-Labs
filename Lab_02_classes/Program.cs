using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_02_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();     //Syntactic Sugar
            Parent p02 = new Parent();  //Regular code
            p01.Age = 22;
            p01.Age = -1;
            Console.WriteLine(p01.Age);
            dynamic x = 10;             //Loose typing
            x = "string";

        }
    }
    class Parent
    {
        //field
        private int x;
        //property
        private string y { get; set; }
        private string ReadMeOnly { get; }      //Read me only
        private int age;
        public int Age
        {
            get
            {
                //any code !!!
                return this.age;
            }
            set
            {
                //any code !!!
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }
        //method
    }
    class Child : Parent
    {    }
}
