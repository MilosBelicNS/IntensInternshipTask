
using HR_Platform_Intens.Models;

namespace HR_Platform_Intens.Interfaces
{
    public  interface ICandidateSkillRepository
    {
        void AddSkillToCandidate(int idCandidate, int idSkill);
        void DeleteSkillFromCandidate(int idCandidate, int idSkill);
       
      
    }
}
