using VillaAPIDemo_Web.Models.DTO;

namespace VillaAPIDemo_Web.Services.IServices
{
	public interface IAuthService
	{
		Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
		Task<T> RegisterAsync<T>(RegistrationRequestDTO objToCreate);
	}
}
