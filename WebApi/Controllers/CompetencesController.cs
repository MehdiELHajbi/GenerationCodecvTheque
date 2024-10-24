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
    public class CompetencesController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateCompetences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateCompetencesViewModel>> CreateCompetences([FromBody] CreateCompetencesCommand createCompetencesCommand)
        {
            var response = await Mediator.Send(createCompetencesCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllCompetencess")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadCompetencesViewModel>>> GetAllCompetencess([FromQuery] ReadCompetencesQuery readCompetencesQuery)
        {
            var response = await Mediator.Send(readCompetencesQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateCompetences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateCompetencesViewModel>> UpdateCompetences([FromBody] UpdateCompetencesCommand updateCompetencesCommand)
        {
            var response = await Mediator.Send(updateCompetencesCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteCompetences")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteCompetences([FromBody] DeleteCompetencesCommand deleteCompetencesCommand)
        {
            await Mediator.Send(deleteCompetencesCommand);
            return NoContent();
        }
    }
}
