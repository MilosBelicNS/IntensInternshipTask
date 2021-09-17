using HR_Platform_Intens.Interfaces.CandidateSkill;
using Microsoft.AspNetCore.Mvc;

namespace HR_Platform_Intens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateSkillsController : ControllerBase
    {
        ICandidateSkillService service { get; set; }

        public CandidateSkillsController(ICandidateSkillService service)
        {

            this.service = service;
        }

        [HttpPost()]
        public IActionResult PostCandidateSkill(int idCandidate, int idSkill)
        {
            service.AddSkillToCandidate(idCandidate, idSkill);
            return Ok();

        }

        [HttpDelete()]
        public IActionResult DeleteCandidateSkill(int idCandidate, int idSkill)
        {
            service.AddSkillToCandidate(idCandidate, idSkill);
            return Ok();
        }
    }
}

