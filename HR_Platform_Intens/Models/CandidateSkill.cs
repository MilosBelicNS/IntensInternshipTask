


using System.ComponentModel.DataAnnotations;

namespace HR_Platform_Intens.Models
{
    public class CandidateSkill
    {
      
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
