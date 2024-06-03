namespace cw6;

public interface IPatientRepository
{
    public Task<List<Patient>> GetAllPatients();
    public Task<Patient> getPatientById(int id);
    public Task<bool> addNewPatient(Patient patient); 
}