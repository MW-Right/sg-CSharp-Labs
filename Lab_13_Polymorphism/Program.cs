using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Parent
    {
        //method
        public virtual void DoThis() { }
    }

    class Child : Parent
    {
        //Can override parent method : polymorphism
        public override void DoThis() { }
    }
}
