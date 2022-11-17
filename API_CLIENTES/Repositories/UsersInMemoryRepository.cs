using API_CLIENTES.Interfaces;
using API_CLIENTES.Dto;

namespace API_CLIENTES.Repositories;

public class UsersInMemoryRepository : IUserRepository
{
    private readonly List<User> _users = new List<User>
    {
        new()
        {
            Id       = 1,
            Fullname = "Diego Rejalas",
            Username = "diego",
            Password = "123456"
        }
    };

    public async Task<User?> GetUserByCredentials(string username, string password)
    {
        return _users.FirstOrDefault(p => p.Username.Equals(username) && p.Password.Equals(password));
    }
}
