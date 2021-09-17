using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Platform_Intens.DTO
{
    public class SkillRequest
    {
        [Required]
        [StringLength(300)]
        public string Name { get; set; }

    }
}
