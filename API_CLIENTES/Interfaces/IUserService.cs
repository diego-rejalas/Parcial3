using API_CLIENTES.Dto;

namespace API_CLIENTES.Interfaces;

public interface IUserService
{
    Task<User> GetByCredentials(string username, string password);
}