using database_first.Context;
using database_first.Models;
using Microsoft.EntityFrameworkCore;

namespace database_first.Repositories;

public class ClientRepositoryImpl : IClientRepository
{
    private DbSet<Client> _clients = new ApbdContext().Clients;
    
    public Task<int> DeleteClientById(int id)
    {
        return _clients.Where(i => i.IdClient == id).ExecuteDeleteAsync();
    }
}