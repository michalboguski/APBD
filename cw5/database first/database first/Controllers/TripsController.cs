using database_first.Context;
using database_first.DTO;
using database_first.Models;
using database_first.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace database_first.Controllers;

[Route("/api/trips")]
[ApiController]
public class TripsController : ControllerBase
{
    private TripService _tripService;
    public TripsController(TripService tripService)
    {
        _tripService = tripService;
    }

    [HttpGet]
    public async Task<IActionResult> GetTrips()
    {
        var dbContext = new ApbdContext();
        var result = await _tripService.getAllTripsOrderedDescByDateStart();
        return Ok(result);
    }

    [Route("/{idTrip}/clients")]
    [HttpPost]
    public IActionResult RegisterOnTrip(int idTrip, [FromBody] ClientDTO clientDTO)
    {
        var dbContext = new ApbdContext();
        var clientResult = dbContext.Clients.Where(c => c.Pesel.Equals(clientDTO.Pesel));
        int clientID;

        if (clientResult == null)
        {
            var maxid = dbContext.Clients.Max(i => i.IdClient);
            dbContext.Clients.Add(new Client()
                {
                    IdClient = maxid + 1,
                    FirstName = clientDTO.FirstName,
                    LastName = clientDTO.LastName,
                    Email = clientDTO.Email,
                    Telephone = clientDTO.Telephone,
                    Pesel = clientDTO.Pesel
                }
            );
            clientID = maxid + 1;
        }
        else
        {
            clientID = clientResult.OrderBy(c => c.IdClient).First().IdClient;
        }
      

        var result = dbContext.ClientTrips
            .Include(c => c.IdClientNavigation)
            .Include(t => t.IdTripNavigation)
            .Where(t => t.IdTrip == idTrip && clientDTO.IdTrip != t.IdTrip)
            .Select(s => new
            {
                cId = s.IdClient, tId = s.IdTrip
            }).ToList();
        
        if (result.Count() != 0)
        {
            return NoContent();
        }

        ClientTrip NewClientTrip = new ClientTrip   {
            IdClient = clientID,
            IdTrip = idTrip,
            RegisteredAt = DateTime.Now,
            PaymentDate = clientDTO.PaymentDate
        };
        
        
        dbContext.ClientTrips.Add(NewClientTrip);


        return Ok();
    }
}