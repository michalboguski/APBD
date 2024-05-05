using Microsoft.AspNetCore.Mvc;

namespace GakkoAppVertical.Animals;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok("kuna, lis ...");
    }
}