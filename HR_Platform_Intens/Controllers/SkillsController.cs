using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace HR_Platform_Intens.Controllers
{
    [Route("api/Skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {

        ISkillService service { get; set; }

        public SkillsController(ISkillService service)
        {

            this.service = service;
        }

        [HttpPost()]
        public IActionResult Post(SkillRequest skillRequest)
        {


            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            service.Create(skillRequest);

            return Created("DefaultApi", skillRequest);



        }
    }
}
