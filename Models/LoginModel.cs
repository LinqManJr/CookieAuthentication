using System.ComponentModel.DataAnnotations;

namespace CookieAuthentication.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Input Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Incorrect password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
