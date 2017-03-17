using Langcademy.Common;
using System.ComponentModel.DataAnnotations;

namespace Langcademy.Web.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = GlobalConstants.PasswordMinLength)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [MinLength(GlobalConstants.UserNameMinLength)]
        [MaxLength(GlobalConstants.UserNameMaxLength)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [MinLength(GlobalConstants.FirstNameMinLength)]
        [MaxLength(GlobalConstants.FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(GlobalConstants.LastNameMinLength)]
        [MaxLength(GlobalConstants.LastNameMaxLength)]
        public string LastName { get; set; }

        [Display(Name = "Image url")]
        [MaxLength(GlobalConstants.AvatarImageUrlMaxLength)]
        public string ImageUrl { get; set; }
    }
}
