using Microsoft.AspNetCore.Mvc;

namespace cw6;

[ApiController]
[Route("/api/prescriptions")]
public class PrescriptionsCantroller : ControllerBase
{
    public async Task<IActionResult> addPrescription()
    {

        return Ok();
    }
}