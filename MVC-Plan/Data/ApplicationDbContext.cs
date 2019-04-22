using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Plan.Models;

namespace MVC_Plan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<StudentTerm> StudentTerms { get; set; }
        public DbSet<Requirement> Requirements{ get; set; }
        public DbSet<DegreeRequirement> DegreeRequirements { get; set; }
        public DbSet<DegreePlanTermRequirement> DegreePlanTermRequirements { get; set; }

        
       
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            modelBuilder.Entity<Degree>().ToTable("Degree");
        }
    }
}
