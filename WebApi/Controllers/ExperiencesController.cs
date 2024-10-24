using Application;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api /[controller]")]
    [ApiController]
    public class ExperiencesController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateExperiences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateExperiencesViewModel>> CreateExperiences([FromBody] CreateExperiencesCommand createExperiencesCommand)
        {
            var response = await Mediator.Send(createExperiencesCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllExperiencess")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadExperiencesViewModel>>> GetAllExperiencess([FromQuery] ReadExperiencesQuery readExperiencesQuery)
        {
            var response = await Mediator.Send(readExperiencesQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateExperiences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateExperiencesViewModel>> UpdateExperiences([FromBody] UpdateExperiencesCommand updateExperiencesCommand)
        {
            var response = await Mediator.Send(updateExperiencesCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteExperiences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteExperiences([FromBody] DeleteExperiencesCommand deleteExperiencesCommand)
        {
            await Mediator.Send(deleteExperiencesCommand);
            return NoContent();
        }
    }
}
