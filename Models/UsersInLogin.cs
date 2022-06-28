#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrangerEscape.Models;

[NotMapped]
public class UserInLogin
{
    [Required(ErrorMessage = "You must enter your email!")]
    [EmailAddress]
    [Display(Name = "Email")]

    public string LoginEmail { get; set; }


    [Required(ErrorMessage = "You must enter your password!")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LoginPassword { get; set; }
}