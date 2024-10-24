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
    public class LoisirsController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateLoisirs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateLoisirsViewModel>> CreateLoisirs([FromBody] CreateLoisirsCommand createLoisirsCommand)
        {
            var response = await Mediator.Send(createLoisirsCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllLoisirss")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadLoisirsViewModel>>> GetAllLoisirss([FromQuery] ReadLoisirsQuery readLoisirsQuery)
        {
            var response = await Mediator.Send(readLoisirsQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateLoisirs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateLoisirsViewModel>> UpdateLoisirs([FromBody] UpdateLoisirsCommand updateLoisirsCommand)
        {
            var response = await Mediator.Send(updateLoisirsCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteLoisirs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteLoisirs([FromBody] DeleteLoisirsCommand deleteLoisirsCommand)
        {
            await Mediator.Send(deleteLoisirsCommand);
            return NoContent();
        }
    }
}
