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
    public class FormationsController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateFormations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateFormationsViewModel>> CreateFormations([FromBody] CreateFormationsCommand createFormationsCommand)
        {
            var response = await Mediator.Send(createFormationsCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllFormationss")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadFormationsViewModel>>> GetAllFormationss([FromQuery] ReadFormationsQuery readFormationsQuery)
        {
            var response = await Mediator.Send(readFormationsQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateFormations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateFormationsViewModel>> UpdateFormations([FromBody] UpdateFormationsCommand updateFormationsCommand)
        {
            var response = await Mediator.Send(updateFormationsCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteFormations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteFormations([FromBody] DeleteFormationsCommand deleteFormationsCommand)
        {
            await Mediator.Send(deleteFormationsCommand);
            return NoContent();
        }
    }
}
