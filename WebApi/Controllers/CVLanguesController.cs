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
    public class CVLanguesController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateCVLangues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateCVLanguesViewModel>> CreateCVLangues([FromBody] CreateCVLanguesCommand createCVLanguesCommand)
        {
            var response = await Mediator.Send(createCVLanguesCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllCVLanguess")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadCVLanguesViewModel>>> GetAllCVLanguess([FromQuery] ReadCVLanguesQuery readCVLanguesQuery)
        {
            var response = await Mediator.Send(readCVLanguesQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateCVLangues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateCVLanguesViewModel>> UpdateCVLangues([FromBody] UpdateCVLanguesCommand updateCVLanguesCommand)
        {
            var response = await Mediator.Send(updateCVLanguesCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteCVLangues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteCVLangues([FromBody] DeleteCVLanguesCommand deleteCVLanguesCommand)
        {
            await Mediator.Send(deleteCVLanguesCommand);
            return NoContent();
        }
    }
}
