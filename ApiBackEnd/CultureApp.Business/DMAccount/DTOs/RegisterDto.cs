using System.ComponentModel.DataAnnotations;

namespace ApiBackEnd.CultureApp.Business.DMAccount.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Email { get; set; }
         [Required]
        public string FirstName { get; set; }
         [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }    
    }
}