using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    /// <summary>
    /// This is used on the register page for very basic validation.
    /// Player model was not used due to errors since player model required access code.
    /// </summary>
    public class RegisterModel
    {
        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Display name too long or short")]
        public string? DisplayName { get; set; }
        
        /// <summary>
        /// Very basic validation. Only checks format not if valid email
        /// </summary>
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        /// <summary>
        /// Better authentication needed. 10 chars could be typed in here
        /// </summary>
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter 10 digit phone number")]
        public string? PhoneNumber { get; set; }
    }
}
