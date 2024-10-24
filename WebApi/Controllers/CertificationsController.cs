using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api /[controller]")]
    [ApiController]
    public class CertificationsController : ApiControllerBase
    {
        [HttpPost("Create", Name = "CreateCertifications")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateCertificationsViewModel>> CreateCertifications([FromBody] CreateCertificationsCommand createCertificationsCommand)
        {
            var response = await Mediator.Send(createCertificationsCommand);
            return Ok(response);
        }
        [HttpGet("all", Name = "GetAllCertificationss")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ReadCertificationsViewModel>>> GetAllCertificationss([FromQuery] ReadCertificationsQuery readCertificationsQuery)
        {
            var response = await Mediator.Send(readCertificationsQuery);
            return Ok(response);
        }
        [HttpPut("Update", Name = "UpdateCertifications")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UpdateCertificationsViewModel>> UpdateCertifications([FromBody] UpdateCertificationsCommand updateCertificationsCommand)
        {
            var response = await Mediator.Send(updateCertificationsCommand);
            return Ok(response);
        }
        [HttpDelete("Delete", Name = "DelteCertifications")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteCertifications([FromBody] DeleteCertificationsCommand deleteCertificationsCommand)
        {
            await Mediator.Send(deleteCertificationsCommand);
            return NoContent();
        }
    }
}
