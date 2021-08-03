using System.ComponentModel.DataAnnotations;
namespace SimpleLogin.Models
{
    public class UserLogin
{
    [Required(ErrorMessage = "This field is required")]
    public string Email {get;set;}
    [Required]
    [DataType(DataType.Password)]
    [MinLength(8,ErrorMessage ="Password must be at least 8 characters")]
    public string Password {get;set;}
}

    public class UserRegister
{
    [Required]
    [MinLength(2,ErrorMessage ="Name must be at least 2 characters")]
    public string FirstName {get;set;}
    [Required]
    [MinLength(2,ErrorMessage ="Name must be at least 2 characters")]
    public string LastName {get;set;}
    [Required]
    public string RegEmail {get;set;}

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8,ErrorMessage ="Password must be at least 8 characters")]
    public string RegPassword {get;set;}
    [Required]
    [DataType(DataType.Password)]
    [Compare("RegPassword",ErrorMessage ="Passwords do not match")]
    [MinLength(8)]
    public string RegPasswordConfirm {get;set;}
}

}