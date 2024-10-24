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
    public class CVCompetencesController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateCVCompetences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateCVCompetencesViewModel>> CreateCVCompetences([FromBody] CreateCVCompetencesCommand createCVCompetencesCommand)
        {
            var response = await Mediator.Send(createCVCompetencesCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllCVCompetencess")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadCVCompetencesViewModel>>> GetAllCVCompetencess([FromQuery] ReadCVCompetencesQuery readCVCompetencesQuery)
        {
            var response = await Mediator.Send(readCVCompetencesQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateCVCompetences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateCVCompetencesViewModel>> UpdateCVCompetences([FromBody] UpdateCVCompetencesCommand updateCVCompetencesCommand)
        {
            var response = await Mediator.Send(updateCVCompetencesCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteCVCompetences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteCVCompetences([FromBody] DeleteCVCompetencesCommand deleteCVCompetencesCommand)
        {
            await Mediator.Send(deleteCVCompetencesCommand);
            return NoContent();
        }
    }
}
