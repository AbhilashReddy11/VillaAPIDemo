
using System.ComponentModel.DataAnnotations;
using VillaAPIDemo_Web.Models;

namespace VillaAPIDemo_web.Models.Dto
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
