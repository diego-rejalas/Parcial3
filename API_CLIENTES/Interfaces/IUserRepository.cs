using API_CLIENTES.Dto;

namespace API_CLIENTES.Interfaces;

public interface IUserRepository
{
    Task<User?> GetUserByCredentials(string username, string password);
}
