using Microsoft.AspNetCore.Mvc;

namespace cw6;

[ApiController]
[Route("/api/prescriptions")]
public class PrescriptionsCantroller : ControllerBase
{
    private IPrescriptionService _prescriptionService;

    public PrescriptionsCantroller(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }

    [HttpPost]
    [Route("/add/{DoctorId}")]
    public async Task<IActionResult> addPrescription([FromQuery] int DoctorId, [FromBody] AddPrescriptionCommandDto addPrescriptionCommandDto)
    {
        var result = _prescriptionService.ProcessNewPrescription(DoctorId, addPrescriptionCommandDto);
        return Ok(result);
    }
}