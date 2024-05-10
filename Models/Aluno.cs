using System.ComponentModel.DataAnnotations;
namespace EFApp.Models;

public class Aluno 
{
    [Key]
    public int Id { get; set;}

    [Required(ErrorMessage = "The {0} field is required")]
    [StringLength(120, MinimumLength = 2)]
    public string? Name { get; set;}

    [Required(ErrorMessage = "The {0} field is required")]
    [StringLength(80)]
    public string? Email { get; set;}

    [DataType(DataType.DateTime)]
    [ScaffoldColumn(false)]
    public DateTime CreatedAt { get; set;}
}