namespace cw6;

public class PrescriptionServiceImpl : IPrescriptionService
{
    private IPrescriptionRepository _prescriptionRepository;
    private IPatientRepository _patientRepository;
    private IMedicamentRepository _medicamentRepository;
    private IPrescriptionMedicamentRepository _prescriptionMedicamentRepository;

    public PrescriptionServiceImpl(IPrescriptionRepository prescriptionRepository, IPatientRepository patientRepository,
        IMedicamentRepository medicamentRepository, IPrescriptionMedicamentRepository prescriptionMedicamentRepository)
    {
        _prescriptionRepository = prescriptionRepository;
        _patientRepository = patientRepository;
        _medicamentRepository = medicamentRepository;
        _prescriptionMedicamentRepository = prescriptionMedicamentRepository;
    }

    public async Task<bool> ProcessNewPrescription(int doctorId, AddPrescriptionCommandDto addPrescriptionCommandDto)
    {
        PatientDto patientDto = addPrescriptionCommandDto.PatientDto;
        List<MedicamentDto> medicamentDtos = addPrescriptionCommandDto.Medikaments;
        DateOnly Date = addPrescriptionCommandDto.Date;
        DateOnly DueDate = addPrescriptionCommandDto.DueDate;

        Patient patient = await _patientRepository.getPatientById(patientDto.IdPatient);
        
        if (Date > DueDate)
        {
            return false;
        }

        if (patient == null)
        {
            patient.IdPatient = patientDto.IdPatient;
            patient.FirstName = patientDto.FirstName;
            patient.LastName = patientDto.LastName;
            patient.Birthdate = patientDto.Birthdate;

            _patientRepository.addNewPatient(patient);
        }

        if (medicamentDtos.Count > 10)
        {
            return false;
        }

        List<Medicament> allMedicaments = await _medicamentRepository.getAllMedicaments();
        foreach (var medicamentDto in medicamentDtos)
        {
            Medicament tmpMedicament = new Medicament();
            tmpMedicament.IdMedicament = medicamentDto.IdMedicament;
            tmpMedicament.Name = medicamentDto.Name;
            tmpMedicament.Type = medicamentDto.Type;
            tmpMedicament.Description = medicamentDto.Description;

            if (!allMedicaments.Contains(tmpMedicament))
            {
                return false;
            }
            else
            {
                
            }
        }
        
        return true;
    }
}