using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

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

     public async Task<Patient> getPatientById(int id)
     {
          return await _patients.FirstAsync(i => i.IdPatient == id);
     }

     public async Task<bool> addNewPatient(Patient patient)
     {
          _patients.Add(patient);
          int count = await _patients.GetService<ICurrentDbContext>().Context.SaveChangesAsync();
          return count == 1 ? true : false;
     }
}