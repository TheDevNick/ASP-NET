using System.ComponentModel.DataAnnotations;
 
namespace Validation.Models
{
    public class User
    {
        [Required]
        [MinLength(4, ErrorMessage = "Must be longer than 4 character")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Must be longer than 4 character")]
        public string LastName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Age {get;set;}
 
        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Must be between 5 and 15 characters", MinimumLength = 5)]
        public string Password { get; set; }
    }
}
