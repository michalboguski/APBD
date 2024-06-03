namespace cw6;

public interface IMedicamentRepository
{
    public Task <List<Medicament>> getAllMedicaments();
}