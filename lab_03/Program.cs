using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p01 = new Parent("Bill", 44);    //Uses Set constructor
            p01.Name = "Thomas";                    //Uses default constructor
            Parent p02 = new Parent(age: 22, name: "Richard");  //Uses named property setting
            Parent p03 = new Parent("Ricardo");     //As age is not defined, it will be initialised with the default integer value
            Console.WriteLine(p03.Age);
        }
    }
    class Parent                                //Class, methods and properties follow uppercase naming convention
    {
        private int _secret;                    //PRIVATE FIELD, lower case, _toStartName
        public string Name { get; set; }        //Usually used for any PROPERTY that is PUBLIC
        public int Age { get; set; }
        public Parent() {}                      //Default constructor
        public Parent(string name)              //Set constructor
        {
            this.Name = name;
        }
        public Parent(string name, int age)     //Having multiple constructors allows you to call a class without providing all the data
        {
            this.Age = age;
        }
    }
}
