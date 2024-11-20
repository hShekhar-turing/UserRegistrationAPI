// User.cs
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAPI.Models
{
    /// <summary>
    /// Represents a user registration model.
    /// </summary>
    public class UserB
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password must be between 6 and 100 characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name must be between 2 and 50 characters", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name must be between 2 and 50 characters", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Street Address is required")]
        [StringLength(100, ErrorMessage = "Street Address must be between 5 and 100 characters", MinimumLength = 5)]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, ErrorMessage = "City must be between 2 and 50 characters", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(50, ErrorMessage = "State must be between 2 and 50 characters", MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        [StringLength(10, ErrorMessage = "Zip Code must be between 5 and 10 characters", MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(50, ErrorMessage = "Country must be between 2 and 50 characters", MinimumLength = 2)]
        public string Country { get; set; }
    }

    /// <summary>
    /// Represents a user registration model.
    /// </summary>
    public class UserRegistrationModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password must be between 6 and 100 characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name must be between 2 and 50 characters", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name must be between 2 and 50 characters", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Physical Address is required")]
        [StringLength(100, ErrorMessage = "Physical Address must be between 10 and 100 characters", MinimumLength = 10)]
        public string PhysicalAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, ErrorMessage = "City must be between 2 and 50 characters", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(50, ErrorMessage = "State must be between 2 and 50 characters", MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        [StringLength(10, ErrorMessage = "Zip Code must be between 5 and 10 characters", MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(50, ErrorMessage = "Country must be between 2 and 50 characters", MinimumLength = 2)]
        public string Country { get; set; }
    }
}