namespace cw6;

public class PrescriptionServiceImpl : IPrescriptionService
{
    private IPrescriptionRepository _prescriptionRepository;
    private IPatientRepository _patientRepository;
    private IMedicamentRepository _medicamentRepository;
    private IPrescriptionMedicamentRepository _prescriptionMedicamentRepository;

    public PrescriptionServiceImpl(IPrescriptionRepository prescriptionRepository, IPatientRepository patientRepository, IMedicamentRepository medicamentRepository, IPrescriptionMedicamentRepository prescriptionMedicamentRepository)
    {
        _prescriptionRepository = prescriptionRepository;
        _patientRepository = patientRepository;
        _medicamentRepository = medicamentRepository;
        _prescriptionMedicamentRepository = prescriptionMedicamentRepository;
    }

    public bool ProcessNewPrescription(int doctorId, AddPrescriptionCommandDto addPrescriptionCommandDto)
    {
        throw new NotImplementedException();
    }
}