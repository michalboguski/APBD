using Microsoft.EntityFrameworkCore;

namespace cw6;

public class PrescriptionMedicamentImpl : IPrescriptionMedicamentRepository
{
    private DbSet<PrescriptionMedicament> _prescriptionsMedicaments;

    public PrescriptionMedicamentImpl(DbSet<PrescriptionMedicament> prescriptionsMedicaments)
    {
        _prescriptionsMedicaments = new s25236Database().PrescriptionMedicamentDetails;
    }

    public async Task<List<PrescriptionMedicament>> getAllPrescriptionMedicament()
    {
        return await _prescriptionsMedicaments.ToListAsync();
    }
}