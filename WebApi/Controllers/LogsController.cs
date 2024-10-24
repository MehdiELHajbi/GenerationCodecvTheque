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
    public class LogsController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateLogs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateLogsViewModel>> CreateLogs([FromBody] CreateLogsCommand createLogsCommand)
        {
            var response = await Mediator.Send(createLogsCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllLogss")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadLogsViewModel>>> GetAllLogss([FromQuery] ReadLogsQuery readLogsQuery)
        {
            var response = await Mediator.Send(readLogsQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateLogs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateLogsViewModel>> UpdateLogs([FromBody] UpdateLogsCommand updateLogsCommand)
        {
            var response = await Mediator.Send(updateLogsCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteLogs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteLogs([FromBody] DeleteLogsCommand deleteLogsCommand)
        {
            await Mediator.Send(deleteLogsCommand);
            return NoContent();
        }
    }
}
