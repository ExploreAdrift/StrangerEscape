#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finding_Will.Models;

[NotMapped]
public class UserInLogin
{
    [Required]
    public string LoginEmail { get;set; }
    [Required]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters in length.")]
    public string LoginPassword { get;set; }
}