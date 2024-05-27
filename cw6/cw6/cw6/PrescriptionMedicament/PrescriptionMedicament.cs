using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace cw6;

[Table("Prescription_Medicament")]
[PrimaryKey(nameof(IdMedicament), nameof(IdPrescription))]
public class PrescriptionMedicament
{
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    [ForeignKey(nameof(IdMedicament))] public Medicament Medicament { get; set; }
    [ForeignKey(nameof(IdPrescription))] public Prescription Prescription { get; set; }
    public int Dose { get; set; }
    [Required]
    [MaxLength(100)]
    public string Details { get; set; }
}