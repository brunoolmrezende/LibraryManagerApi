using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagerApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public abstract class LibraryManagerApiBaseController : ControllerBase
{
    [HttpGet("healthy-status")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Healthy()
    {
        return Ok("It´s working..");
    }
}
