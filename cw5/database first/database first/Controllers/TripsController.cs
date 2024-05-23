using database_first.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace database_first.Controllers;

[Route("/api/trips")]
[ApiController]
public class TripsController : ControllerBase
{
    
    [HttpGet]
    public async Task <IActionResult> GetTrips()
    {
        var dbContext = new ApbdContext();
        var result = await dbContext.Trips.OrderByDescending(t => t.DateFrom).ToListAsync();
        return Ok(result);
    }
}