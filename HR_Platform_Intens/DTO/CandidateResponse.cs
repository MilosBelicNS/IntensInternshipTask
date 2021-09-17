using System;
using System.Collections.Generic;

namespace HR_Platform_Intens.DTO
{
    public class CandidateResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int ContractNumber { get; set; }
        public string Email { get; set; }
        public IEnumerable<CandidateSkillResponse> Skills { get; set; }
    }
}
