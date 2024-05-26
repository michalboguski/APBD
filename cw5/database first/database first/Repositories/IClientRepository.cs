namespace database_first.Repositories;

public interface IClientRepository
{
    public Task<int> DeleteClientById(int id);
}