using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;           //For using collections

namespace Lab_10_entity
{
    class Program
    {
        public static List<Customer> customers = new List<Customer>();                       //Creates an empty list of customer objects

        static void Main(string[] args)
        {
            Console.WriteLine("\n\n --+== Displaying all customers ==+-- \n");

            using (NorthwindEntities db = new NorthwindEntities())      //Encapsulates database connection so it's closed cleanly
            {
                customers = db.Customers.ToList<Customer>();            //Take data from customers and add them to the list 'customers'
            }
            DisplayAll();

            Console.WriteLine("\n\n --+== Displaying a single customer ==+-- \n");

            //CRUD - Create, Read, Update, Delete
            //Selecting one customer
            using (NorthwindEntities db = new NorthwindEntities())      //Encapsulates database connection so it's closed cleanly
            {
                var customerToUpdate =                                  //LINQ Query : Microsoft's Language Independent Query
                    //Select all customers in Northwind
                    (from customer in db.Customers
                    //Choose the one where the ID matches
                    where customer.CustomerID == "ALFKI"
                    //Return this value
                    select customer).FirstOrDefault();
                Console.WriteLine("\n --+== Finding one customer ==+-- \n");
                Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.City}");
            }

            Console.WriteLine("\n\n --+== Checking if customer has been updated ==+-- \n");
            using (NorthwindEntities db = new NorthwindEntities())      //Encapsulates database connection so it's closed cleanly
            {
                var customerToUpdate =                                  //LINQ Lambda
                    db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
                //Update
                customerToUpdate.ContactName = "Yeet Meistra";
                db.SaveChanges();
                Console.WriteLine("\n --+== Using a linq lamdba query ==+-- \n");
                Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.City}");
            }

            Console.WriteLine("\n\n --+== Checking if new Customer has been Added ==+-- \n");
            //Insert a new customer
            using (var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer
                {
                    CustomerID = "YEET?",
                    ContactName = "YEET YEET",
                    ContactTitle = "Question Mark",
                    City = "Sandhurst",
                    CompanyName = "SpartaGlobal"
                };
                //Add the created customer to the local database
                db.Customers.Add(customerToCreate);
                //Write the changes permanently to real database
                db.SaveChanges();
            }
            DisplayAll();
            //Delete
            Console.WriteLine("\n\n --+== Checking if new Customer has been deleted ==+-- \n");
            using (var db = new NorthwindEntities())
            {
                var customerToDelete =
                    db.Customers.Where(c => c.CustomerID == "YEET?").FirstOrDefault();
                try
                {
                    db.Customers.Remove(customerToDelete);
                    db.SaveChanges();
                }
                catch { }
            }
            DisplayAll();
        }
        public static void DisplayAll()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Yeet! {customer.ContactTitle} {customer.ContactName}, you're a moron");
            }
        }
    }
}
