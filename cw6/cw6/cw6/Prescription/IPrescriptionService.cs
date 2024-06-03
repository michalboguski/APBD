namespace cw6;

public interface IPrescriptionService
{
    public bool ProcessNewPrescription(int doctorId, AddPrescriptionCommandDto addPrescriptionCommandDto);
}