using System.ComponentModel.DataAnnotations;

namespace MyWellnessPlannerApi.Models
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
