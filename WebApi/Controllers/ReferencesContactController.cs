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
    public class ReferencesContactController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateReferencesContact")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateReferencesContactViewModel>> CreateReferencesContact([FromBody] CreateReferencesContactCommand createReferencesContactCommand)
        {
            var response = await Mediator.Send(createReferencesContactCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllReferencesContacts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadReferencesContactViewModel>>> GetAllReferencesContacts([FromQuery] ReadReferencesContactQuery readReferencesContactQuery)
        {
            var response = await Mediator.Send(readReferencesContactQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateReferencesContact")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateReferencesContactViewModel>> UpdateReferencesContact([FromBody] UpdateReferencesContactCommand updateReferencesContactCommand)
        {
            var response = await Mediator.Send(updateReferencesContactCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteReferencesContact")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteReferencesContact([FromBody] DeleteReferencesContactCommand deleteReferencesContactCommand)
        {
            await Mediator.Send(deleteReferencesContactCommand);
            return NoContent();
        }
    }
}
