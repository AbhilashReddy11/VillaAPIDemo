using VillaAPIDemo_Web.Models;

namespace VillaAPIDemo_web.Models.DTO
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
