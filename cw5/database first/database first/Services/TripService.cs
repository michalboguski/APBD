using database_first.Models;
using database_first.Repositories;

namespace database_first.Services;

public class TripService
{
    private ITripRepository _tripRepository;

    public TripService(ITripRepository tripRepository)
    {
        _tripRepository = tripRepository;
    }

    public Task<List<Trip>> getAllTripsOrderedDescByDateStart()
    {
        return _tripRepository.getAllTripsOrderedDescByDateStart();
    }
}