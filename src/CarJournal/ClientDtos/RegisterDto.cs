using System.ComponentModel.DataAnnotations;

using CarJournal.Attributes;

namespace CarJournal.ClientDtos;

public class RegisterDto
{
    [Required]
    [MyEmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(30, ErrorMessage = "Password must be at least 4 characters long.", MinimumLength = 4)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = string.Empty;
}