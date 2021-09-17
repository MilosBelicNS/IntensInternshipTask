using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Platform_Intens.Interfaces.CandidateSkill
{
   public  interface ICandidateSkillService
    {

        void AddSkillToCandidate(int idCandidate, int idSkill);
        void DeleteSkillFromCandidate(int idCandidate, int idSkill);

    }
}
