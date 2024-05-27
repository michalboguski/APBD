using System.ComponentModel.DataAnnotations;

namespace cw6;

public class Medikament
{
    [Key]
    public int IdMedikament { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [Required]
    [MaxLength(100)]
    public string Description { get; set; }
    [Required]
    [MaxLength(100)]
    public string Type { get; set; }
}