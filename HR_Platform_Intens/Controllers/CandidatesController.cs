using HR_Platform_Intens.DTO;
using HR_Platform_Intens.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HR_Platform_Intens.Controllers
{
    [Route("api/Candidates")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {

        ICandidateService service { get; set; }

        public CandidatesController(ICandidateService service)
        {

            this.service = service;
        }

        [HttpGet()]
        public IEnumerable<CandidateResponse> GetAll(string name, int? skillId)
        {
            return service.GetAll(name, skillId);

        }

        [HttpGet()]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var candidate = service.GetById(id);

            if (candidate == null)
            {
                return NotFound();
            }
            return Ok(candidate);
        }


        [HttpPost()]
        public IActionResult Post(CandidateRequest candidateRequest)
        {


            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            service.Create(candidateRequest);

            return Created("DefaultApi", candidateRequest);

        }

        [HttpDelete()]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {

            var candidate = service.GetById(id);

            if (candidate == null)
            {
                return NotFound();
            }

            service.Delete(id);

            return Ok();

        }
    }
}
