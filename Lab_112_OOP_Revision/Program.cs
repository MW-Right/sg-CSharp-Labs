using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_112_OOP_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child t = new Child();
            p.field = 0;
            t.field = 0;
        }
    }
    interface IDoSomething { }

    public class Parent
    {
        public int field;
    }

    //Inherit one parent class
    //Inherit many interfaces
    public class Child : Parent, IDoSomething
    {

    }

    sealed class GrandChild : Child
    {

    }

    //class invalid : GrandChild { }
}
