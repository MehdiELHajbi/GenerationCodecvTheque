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
    public class ProjetsPersonnelsController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateProjetsPersonnels")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateProjetsPersonnelsViewModel>> CreateProjetsPersonnels([FromBody] CreateProjetsPersonnelsCommand createProjetsPersonnelsCommand)
        {
            var response = await Mediator.Send(createProjetsPersonnelsCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllProjetsPersonnelss")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadProjetsPersonnelsViewModel>>> GetAllProjetsPersonnelss([FromQuery] ReadProjetsPersonnelsQuery readProjetsPersonnelsQuery)
        {
            var response = await Mediator.Send(readProjetsPersonnelsQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateProjetsPersonnels")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateProjetsPersonnelsViewModel>> UpdateProjetsPersonnels([FromBody] UpdateProjetsPersonnelsCommand updateProjetsPersonnelsCommand)
        {
            var response = await Mediator.Send(updateProjetsPersonnelsCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteProjetsPersonnels")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteProjetsPersonnels([FromBody] DeleteProjetsPersonnelsCommand deleteProjetsPersonnelsCommand)
        {
            await Mediator.Send(deleteProjetsPersonnelsCommand);
            return NoContent();
        }
    }
}
