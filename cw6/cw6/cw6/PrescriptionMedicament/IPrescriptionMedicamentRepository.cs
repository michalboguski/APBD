namespace cw6;

public interface IPrescriptionMedicamentRepository
{
    public Task<List<PrescriptionMedicament>> getAllPrescriptionMedicament();
}