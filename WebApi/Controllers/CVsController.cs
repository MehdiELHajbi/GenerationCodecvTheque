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
    public class CVsController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateCVs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateCVsViewModel>> CreateCVs([FromBody] CreateCVsCommand createCVsCommand)
        {
            var response = await Mediator.Send(createCVsCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllCVss")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadCVsViewModel>>> GetAllCVss([FromQuery] ReadCVsQuery readCVsQuery)
        {
            var response = await Mediator.Send(readCVsQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateCVs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateCVsViewModel>> UpdateCVs([FromBody] UpdateCVsCommand updateCVsCommand)
        {
            var response = await Mediator.Send(updateCVsCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteCVs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteCVs([FromBody] DeleteCVsCommand deleteCVsCommand)
        {
            await Mediator.Send(deleteCVsCommand);
            return NoContent();
        }
    }
}
