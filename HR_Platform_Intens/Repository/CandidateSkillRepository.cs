using HR_Platform_Intens.Data;
using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Models;
using System;
using System.Linq;

namespace HR_Platform_Intens.Repository
{
    public class CandidateSkillRepository : ICandidateSkillRepository, IDisposable
    {

        private ApplicationDbContext context;
        public CandidateSkillRepository(ApplicationDbContext context)
        {
            this.context = context;
        }



        public void AddSkillToCandidate(int idCandidate, int idSkill)
        {


            var candidateSkillCheck = context.CandidateSkills.Where(x => x.SkillId == idSkill && x.CandidateId == idCandidate)
                                                             .FirstOrDefault();


            CandidateSkill candidateSkill = new CandidateSkill()
            {
                CandidateId = idCandidate,
                Candidate = context.Candidates.Where(x => x.Id == idCandidate).FirstOrDefault(),
                SkillId = idSkill,
                Skill = context.Skills.Where(x => x.Id == idSkill).FirstOrDefault()
            };




            if (candidateSkillCheck == null)

                context.CandidateSkills.Add(candidateSkill);
            context.SaveChanges();



        }

        public void DeleteSkillFromCandidate(int idCandidate, int idSkill)
        {
            var candidateSkillCheck = context.CandidateSkills.Where(x => x.CandidateId == idCandidate && idSkill == x.SkillId)
                                                             .FirstOrDefault();

            if (candidateSkillCheck != null)
            {
                context.CandidateSkills.Remove(candidateSkillCheck);
                context.SaveChanges();
            }
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
