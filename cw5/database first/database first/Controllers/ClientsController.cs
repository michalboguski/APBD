using database_first.Context;
using database_first.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace database_first.Controllers;


[Route("/api/clients")]
[ApiController]
public class ClientsController : ControllerBase
{

    private ClientService _clientService;

    public ClientsController(ClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpDelete]
    [Route("/{id}")]
    public async Task<IActionResult> deleteClient(int id)
    {
        var c = await _clientService.DeleteClientById(id);
       
        if (c == 1)
        {
            return Ok();
        }

        return BadRequest();
    }
}