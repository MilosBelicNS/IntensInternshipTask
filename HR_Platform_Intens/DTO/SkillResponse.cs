using System;
using System.Collections.Generic;

namespace HR_Platform_Intens.DTO
{
    public class SkillResponse
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }

        public IEnumerable<CandidateSkillResponse> Candidates { get; set; }
    }
}
