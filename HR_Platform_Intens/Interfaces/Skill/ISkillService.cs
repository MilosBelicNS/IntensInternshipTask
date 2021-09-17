using HR_Platform_Intens.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Platform_Intens.Interfaces
{
    public interface ISkillService
    {

        void Create(SkillRequest skillRequest);
    }
}
