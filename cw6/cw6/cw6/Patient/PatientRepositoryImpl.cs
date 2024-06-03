using Microsoft.EntityFrameworkCore;

namespace cw6;

public class PatientRepositoryImpl : IPatientRepository
{
     private DbSet<Patient> _patients;

     public PatientRepositoryImpl()
     {
          _patients = new s25236Database().Patients;
     }

     public async Task<List<Patient>> GetAllPatients()
     {
          return await _patients.ToListAsync();
     }
}