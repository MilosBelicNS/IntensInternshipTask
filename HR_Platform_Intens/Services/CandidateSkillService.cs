using HR_Platform_Intens.Interfaces;
using HR_Platform_Intens.Interfaces.CandidateSkill;

namespace HR_Platform_Intens.Services
{
    public class CandidateSkillService : ICandidateSkillService
    {

        private ICandidateSkillRepository repository;

        public CandidateSkillService(ICandidateSkillRepository repository)
        {
            this.repository = repository;


        }

        public void AddSkillToCandidate(int idCandidate, int idSkill)
        {

            repository.AddSkillToCandidate(idCandidate, idSkill);

        }

        public void DeleteSkillFromCandidate(int idCandidate, int idSkill)
        {
            repository.DeleteSkillFromCandidate(idCandidate, idSkill);
        }


    }
}
