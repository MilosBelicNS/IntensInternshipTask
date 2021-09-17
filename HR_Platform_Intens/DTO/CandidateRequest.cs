
using System;
using System.ComponentModel.DataAnnotations;


namespace HR_Platform_Intens.DTO
{
    public class CandidateRequest
    {

        [Required]
        [StringLength(300)]
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [Range(1, 9999)]
        public int ContractNumber { get; set; }
        [Required]
        [StringLength(300)]
        public string Email { get; set; }
       
    }
}
