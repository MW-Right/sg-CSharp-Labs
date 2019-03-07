﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace Lab_30_Northwind_to_XML
{
    class Program
    {
        public static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            //Add Product/ Category / Northwind classes from last 
            //CORE project


            //Read Northwind
            using (var db = new Northwind())
            {
                products = db.Products.OrderBy(p => p.ProductName).Take(5).ToList();


                //Extract Products



                //Write to XML


            }
            products.ForEach(p => Console.WriteLine(p.ProductName));
            Console.WriteLine("\n\nExtracing To XML\n");

            //Create XML Document from this list of products
            var xml5 = new XElement("Products",
                from p in products
                select new XElement("Product",
                    new XElement("ProductID", p.ProductID),
                    new XElement("ProductName", p.ProductName),
                    new XElement("Cost", p.Cost)
                )
            );

            //Write to disk
            var xmlDocument5 = new XDocument(xml5);
            xmlDocument5.Save("FiveProducts.xml");

            //Read back the raw xml data as a string
            Console.WriteLine("\nFirstly read back the raw xml data as a string");
            Console.WriteLine(File.ReadAllText("FiveProducts.xml"));

            //Deserialise the xml file and put it into a product object
            var productList = new Products();
            using (var reader = new StreamReader("FiveProducts.xml"))
            {
                //Create a serializer
                var serializer = new XmlSerializer(typeof(Products));
                //Do the work
                productList = (Products)serializer.Deserialize(reader);
            }

        }
        //This class with hold the deserialised object (casting XML back into List of Products)
        [XmlRoot("Products")]
        public class Products
        {
            [XmlElement("Product")]
            public List<Product> ProductList { get; set; }
        }

        public class Category
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            [Column(TypeName = "ntext")]
            public string Description { get; set; }
            public virtual ICollection<Product> Products { get; set; }
            public Category()
            {
                this.Products = new List<Product>();
            }
        }
        public class Product
        {
            public int ProductID { get; set; }
            [Required]
            [StringLength(40)]
            public string ProductName { get; set; }
            [Column("UnitPrice", TypeName = "money")]
            public decimal? Cost { get; set; }
            [Column("UnitsInStock")]
            public short? Stock { get; set; }
            public bool Discontinued { get; set; }
            public int CategoryID { get; set; }
            //public virtual Category Category { get; set; }
        }


        public class Northwind : DbContext
        {
            public DbSet<Category> Categories { get; set; }
            public DbSet<Product> Products { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "../../../../data/Northwind.db");
                // use SQLite
                optionsBuilder.UseSqlite($"Filename={path}");
                // use SQL
                //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=Northwind;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>()
                    .Property(category => category.CategoryName)
                    .IsRequired()
                    .HasMaxLength(40);
                // filter out discontinued products
                modelBuilder.Entity<Product>()
                    .HasQueryFilter(p => !p.Discontinued);
            }
        }
    }
}

