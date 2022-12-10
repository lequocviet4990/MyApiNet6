using System.ComponentModel.DataAnnotations;

namespace API.CORE
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]

        public string Password { get; set; }
    }
}