using System.ComponentModel.DataAnnotations;
namespace CretaceousPark.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Range(0, 200, ErrorMessage= "Age must be between 0 and 200.")]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}