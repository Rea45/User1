using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace User.Models.SignUp
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public Guid Oid { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression(@"(?=.*\W)?(?=.*\d)", ErrorMessage = "Error message")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}