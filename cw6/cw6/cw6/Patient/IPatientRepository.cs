namespace cw6;

public interface IPatientRepository
{
    public Task<List<Patient>> GetAllPatients();
}