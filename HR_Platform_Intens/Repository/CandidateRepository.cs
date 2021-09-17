using HR_Platform_Intens.Data;
using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HR_Platform_Intens.Repository
{
    public class CandidateRepository : ICandidateRepository, IDisposable
    {


        private ApplicationDbContext context;
        public CandidateRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Candidate> GetAll(string name, int? skillId)
        {

            IEnumerable<Candidate> candidates = context.Candidates.Include(x => x.Skills).ThenInclude(x => x.Skill);

            if (!string.IsNullOrEmpty(name))
            {
                candidates = candidates.Where(x => x.FullName.Contains(name));
            }

            if (skillId != null)
            {
                var candidatesId = context.CandidateSkills.Where(x => x.SkillId == skillId);

                List<Candidate> candidatesWithSkill = new List<Candidate>();

                for (var i = 0; i < candidatesId.Count(); i++)
                {
                    candidatesWithSkill.Add(candidates.ElementAt(i));
                }

                return candidatesWithSkill;
            }

            return candidates;

        }

        public Candidate GetById(int id)
        {
            return context.Candidates.Find(id);
        }


        public void Create(Candidate candidate)
        {

            context.Candidates.Add(candidate);
            context.SaveChanges();
        }

        public void Delete(int id)
        {

            var candidate = context.Candidates.Find(id);
            context.Candidates.Remove(candidate);
            context.SaveChanges();
        }


        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
