using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_118_NorthwindTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeCustomerName(100);
        }
        static void ChangeCustomerName(int numOfTimes)
        {
            Task[] tasks = new Task[numOfTimes];
            Stopwatch s = new Stopwatch();
            Customer cust = new Customer();
            List<Customer> customers = new List<Customer>();
            s.Start();
            Random rnd = new Random();
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                for (int i = 0; i < numOfTimes; i++)
                {
                    string name = "";
                    name = "Michael" + i.ToString("D3");
                    cust = db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
                    cust.ContactName = name;
                    Console.WriteLine($"{cust.CustomerID}: Name - {cust.ContactName}");
                    db.SaveChanges();
                }
            }
            Console.WriteLine(s.ElapsedMilliseconds);
            s.Stop();
        }
    }
}
