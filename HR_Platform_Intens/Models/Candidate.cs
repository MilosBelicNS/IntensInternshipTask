using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Platform_Intens.Models
{
    [Table("Candidates")]
    public class Candidate
    {

        
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
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
        public IEnumerable<CandidateSkill> Skills { get; set; } 


    }
}
