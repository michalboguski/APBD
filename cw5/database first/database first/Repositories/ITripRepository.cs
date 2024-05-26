using database_first.Models;

namespace database_first.Repositories;

public interface ITripRepository
{
    Task<List<Trip>> getAllTripsOrderedDescByDateStart();
}