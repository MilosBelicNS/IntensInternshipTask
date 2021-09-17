using HR_Platform_Intens.Models;


namespace HR_Platform_Intens.DTO
{
    public class CandidateSkillResponse
    {
       
        public int CandidateId { get; set; }
        public CandidateResponse Candidate { get; set; }

      
        public int SkillId { get; set; }
        public SkillResponse Skill { get; set; }
    }
}
