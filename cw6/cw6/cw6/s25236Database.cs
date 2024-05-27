using Microsoft.EntityFrameworkCore;

namespace cw6;


public class s25236Database : DbContext
{
    public s25236Database()
    {
    }
    public s25236Database(DbContextOptions<s25236Database> options) :base(options)
    {
    }
    public DbSet<Medicament> Medikaments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<PrescriptionMedicament> PrescriptionMedicamentDetails { get; set; }
}