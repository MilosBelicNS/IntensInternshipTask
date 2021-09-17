using HR_Platform_Intens.Data;
using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Models;
using System;
using System.Collections.Generic;

namespace HR_Platform_Intens.Repository
{
    public class SkillRepository : ISkillRepository, IDisposable
    {
        private ApplicationDbContext context;

        public SkillRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Skill> GetAll()
        {
            return context.Skills;
        }

        public void Create(Skill skill)
        {
            
                context.Skills.Add(skill);
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
