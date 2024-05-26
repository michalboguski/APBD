using database_first.Context;
using database_first.Models;
using Microsoft.EntityFrameworkCore;

namespace database_first.Repositories;

public class TripRepositoryImpl : ITripRepository
{
    private DbSet<Trip> _trips = new ApbdContext().Trips;
    

    public Task<List<Trip>> getAllTripsOrderedDescByDateStart()
    {
        return _trips.OrderByDescending(d => d.DateFrom).ToListAsync();
    }
}