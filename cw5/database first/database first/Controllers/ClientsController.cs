using database_first.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace database_first.Controllers;


[Route("/api/clients")]
[ApiController]
public class ClientsController : ControllerBase
{
    [HttpDelete]
    [Route("/{id}")]
    public async Task<IActionResult> deleteClent(int id)
    {
        var dbContext = new ApbdContext();
        var count = dbContext.ClientTrips.Where(c => c.IdClient == id).Count().CompareTo(0);
        if (count == 0)
        {
            await dbContext.Clients.Where(c => c.IdClient == id).ExecuteDeleteAsync();
            return Ok();
        }

        return NoContent();
    }
}