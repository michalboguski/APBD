using Microsoft.EntityFrameworkCore;

namespace cw6;

public class MedicamentRepositoryImpl : IMedicamentRepository
{
    private DbSet<Medicament> _medicaments;

    public MedicamentRepositoryImpl()
    {
        _medicaments = new s25236Database().Medikaments;
    }

    public async Task<List<Medicament>> GetAllMedicament()
    {
        return await _medicaments.ToListAsync();
    }

    public async Task<List<Medicament>> getAllMedicaments()
    {
        return await _medicaments.ToListAsync();
    }
}