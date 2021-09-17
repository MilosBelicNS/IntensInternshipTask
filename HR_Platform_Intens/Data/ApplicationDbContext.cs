using HR_Platform_Intens.Data.SeedHelperMethods;
using HR_Platform_Intens.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Platform_Intens.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CandidateSkill> CandidateSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.SeedCandidate();
            modelBuilder.SeedSkill();
            modelBuilder.SeedCandidateSkill();



        }
       



    }
}
