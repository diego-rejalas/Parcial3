using API_CLIENTES.Dto;

namespace API_CLIENTES.Interfaces;

public interface IAuthenticationService
{
    Task<bool> Authenticate(string username, string password);
    Task<string> GenerateJwt(User user);
}