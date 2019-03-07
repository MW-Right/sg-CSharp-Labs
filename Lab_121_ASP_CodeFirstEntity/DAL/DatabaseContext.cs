using Lab_121_ASP_CodeFirstEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Lab_121_ASP_CodeFirstEntity.DAL
{
    public class CollegeContext : DbContext
    {
        //Constructor methods which bounces responsibility to Entity.DbContext, to do the heavy lifting using the base keyword
        public CollegeContext() : base("CollegeContext")
        { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}