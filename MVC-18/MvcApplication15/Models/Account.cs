using System.ComponentModel.DataAnnotations;

namespace MvcApplication15.Models
{
    public class Account
    {
        [Required(ErrorMessage = "Username is required to login.")]
        [StringLength(20)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required to login.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}