using HR_Platform_Intens.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Platform_Intens.Data.SeedHelperMethods
{
    public static class SeedHelperMethods
    {
        public static void SeedCandidate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();



            modelBuilder.Entity<Candidate>().HasData(
         new Candidate { Id = 1, FullName = "Marko Petrovic", BirthDate = new DateTime(1995, 05, 24), ContractNumber = 1, Email = "marko@mail.com" },
         new Candidate { Id = 2, FullName = "Petar Nikolic", BirthDate = new DateTime(1997, 08, 17), ContractNumber = 2, Email = "pera@mail.com" });

        }

        public static void SeedSkill(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Skill>()
                        .Property(f => f.Id)
                        .ValueGeneratedOnAdd();


            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "Java" },
                new Skill { Id = 2, Name = "C#" },
                new Skill { Id = 3, Name = "Python" },
                new Skill { Id = 4, Name = "Javascript" },
                new Skill { Id = 5, Name = "HTML" },
                new Skill { Id = 6, Name = "CSS" },
                new Skill { Id = 7, Name = "PHP" },
                new Skill { Id = 8, Name = "React" },
                new Skill { Id = 9, Name = "Angular" },
                new Skill { Id = 10, Name = "Azure" },
                new Skill { Id = 11, Name = "AWS" },
                new Skill { Id = 12, Name = "OOP" },
                new Skill { Id = 13, Name = "SQL" },
                new Skill { Id = 14, Name = "Git" },
                new Skill { Id = 15, Name = "Django" },
                new Skill { Id = 16, Name = "MongoDb" },
                new Skill { Id = 17, Name = "QA" },
                new Skill { Id = 18, Name = "Xamarin" },
                new Skill { Id = 19, Name = "JSON" },
                new Skill { Id = 20, Name = "XML" },
                new Skill { Id = 21, Name = "English" },
                new Skill { Id = 22, Name = "Russian" },
                new Skill { Id = 23, Name = "German" },
                new Skill { Id = 24, Name = "French" }
            );

        } 

        public static void SeedCandidateSkill(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidateSkill>().HasKey(cs => new { cs.CandidateId, cs.SkillId });

            modelBuilder.Entity<CandidateSkill>()
                        .HasOne(cs => cs.Candidate)
                        .WithMany(cs => cs.Skills)
                        .HasForeignKey(cs => cs.CandidateId);

            modelBuilder.Entity<CandidateSkill>()
                       .HasOne(cs => cs.Skill)
                       .WithMany(cs => cs.Candidates)
                       .HasForeignKey(cs => cs.SkillId);

            modelBuilder.Entity<CandidateSkill>().HasData(
                new CandidateSkill { CandidateId = 1, SkillId = 1 },
                new CandidateSkill { CandidateId = 1, SkillId = 2 },
                new CandidateSkill { CandidateId = 1, SkillId = 4 },
                new CandidateSkill { CandidateId = 1, SkillId = 5 },
                new CandidateSkill { CandidateId = 1, SkillId = 6 },
                new CandidateSkill { CandidateId = 1, SkillId = 8 },
                new CandidateSkill { CandidateId = 1, SkillId = 10 },
                new CandidateSkill { CandidateId = 1, SkillId = 12 },
                new CandidateSkill { CandidateId = 1, SkillId = 13 },
                new CandidateSkill { CandidateId = 1, SkillId = 17 },
                new CandidateSkill { CandidateId = 1, SkillId = 19 },
                new CandidateSkill { CandidateId = 1, SkillId = 21 },
                new CandidateSkill { CandidateId = 2, SkillId = 2 },
                new CandidateSkill { CandidateId = 2, SkillId = 3 },
                new CandidateSkill { CandidateId = 2, SkillId = 4 },
                new CandidateSkill { CandidateId = 2, SkillId = 5 },
                new CandidateSkill { CandidateId = 2, SkillId = 6 },
                new CandidateSkill { CandidateId = 2, SkillId = 9 },
                new CandidateSkill { CandidateId = 2, SkillId = 10 },
                new CandidateSkill { CandidateId = 2, SkillId = 12 },
                new CandidateSkill { CandidateId = 2, SkillId = 13 },
                new CandidateSkill { CandidateId = 2, SkillId = 20 },
                new CandidateSkill { CandidateId = 2, SkillId = 19 },
                new CandidateSkill { CandidateId = 2, SkillId = 21 }
                );

        }
    }
}
