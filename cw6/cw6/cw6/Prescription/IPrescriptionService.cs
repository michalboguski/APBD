namespace cw6;

public interface IPrescriptionService
{
    public Task<bool> ProcessNewPrescription(int doctorId, AddPrescriptionCommandDto addPrescriptionCommandDto);
}