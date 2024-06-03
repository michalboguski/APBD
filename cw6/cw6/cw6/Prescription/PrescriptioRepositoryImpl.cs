using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cw6;

public class PrescriptionRepositoryImpl : IPrescriptionRepository
{
    private DbSet<Prescription> _prescriptionRepository;

    public PrescriptionRepositoryImpl(IPrescriptionRepository prescriptionRepository)
    {
        _prescriptionRepository = new s25236Database().Prescriptions;
    }

    public async Task<List<Prescription>> getAllPrescryptions()
    {
        return await _prescriptionRepository.ToListAsync();
    }
}