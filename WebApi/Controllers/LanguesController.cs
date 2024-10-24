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
    public class LanguesController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateLangues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateLanguesViewModel>> CreateLangues([FromBody] CreateLanguesCommand createLanguesCommand)
        {
            var response = await Mediator.Send(createLanguesCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllLanguess")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadLanguesViewModel>>> GetAllLanguess([FromQuery] ReadLanguesQuery readLanguesQuery)
        {
            var response = await Mediator.Send(readLanguesQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateLangues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateLanguesViewModel>> UpdateLangues([FromBody] UpdateLanguesCommand updateLanguesCommand)
        {
            var response = await Mediator.Send(updateLanguesCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteLangues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteLangues([FromBody] DeleteLanguesCommand deleteLanguesCommand)
        {
            await Mediator.Send(deleteLanguesCommand);
            return NoContent();
        }
    }
}
