using System;
using System.Data.Entity;
using Lab_121_ASP_CodeFirst02.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lab_121_ASP_CodeFirst02.DAL
{
    public class SchoolContext : DbContext
    {
        //Constructor methods which bounces responsibility to Entity.DbContext, to do the heavy lifting using the base keyword
        public SchoolContext() : base("SchoolContext")
        { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}