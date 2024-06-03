namespace cw6;

public class AddPrescriptionCommandDto
{
    public PatientDto PatientDto;
    public List<MedicamentDto> Medikaments { get; set; }
    public DateOnly Date { get; set; }
    public DateOnly DueDate { get; set; }
    
}