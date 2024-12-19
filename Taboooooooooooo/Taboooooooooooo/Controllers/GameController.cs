using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Taboooooooooooo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Method()
    {
        return BadRequest("Salam");
    }
}
