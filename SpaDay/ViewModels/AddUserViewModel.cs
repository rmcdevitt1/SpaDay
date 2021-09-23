using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        //Add properties for the user’s username, password, and email. Also, add a new property called VerifyPassword.
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be more between 5 and 15 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be more between 6 and 20 characters.")]
        [Compare("VeryifyPassword", ErrorMessage = "Passwords do not match")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string VerifyPassword { get; set; }
    }
}
