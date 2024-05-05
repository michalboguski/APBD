using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace GakkoAppVertical.Animals;

public class Animal
{
    public int IdAnimal { get; set; }
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    [MaxLength(200)]
    public string Decription { get; set; }
    [Required]
    [MaxLength(200)]
    public string Category { get; set; }
    [Required]
    [MaxLength(200)]
    public string Area { get; set; }
}