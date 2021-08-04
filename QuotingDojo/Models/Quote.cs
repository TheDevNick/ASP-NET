using System.ComponentModel.DataAnnotations;
namespace QuotingDojo.Models
{

    public class GenerateQuote
{
    [Required]
    public string User {get;set;}
    [Required]
    public string UserQuote {get;set;}
}

}