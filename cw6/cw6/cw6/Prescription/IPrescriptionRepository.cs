namespace cw6;

public interface IPrescriptionRepository
{
    public Task<List<Prescription>> getAllPrescryptions();
}