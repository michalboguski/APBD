using database_first.Repositories;

namespace database_first.Services;

public class ClientService
{
    private IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public Task<int> DeleteClientById(int id)
    {
        return _clientRepository.DeleteClientById(id);
    }
}