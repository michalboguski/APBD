using System.ComponentModel.DataAnnotations;


namespace cw6;

public class Patient
{
    [Key]
    public int IdPatient { get; set; }
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } 
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(100)]
    public DateOnly Birthdate { get; set; } 
}