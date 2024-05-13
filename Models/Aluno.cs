using System.ComponentModel.DataAnnotations;

namespace EFApp.Models 
{
    public class Aluno 
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set;}

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(120, MinimumLength = 2, ErrorMessage = "The {0} field must have between {2} and {1} characters")]
        public string? Name { get; set;}

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(80, ErrorMessage = "The {0} field must have up to {1} characters")]
        public string? Email { get; set;}

        [DataType(DataType.DateTime)]
        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set;}
    }
}