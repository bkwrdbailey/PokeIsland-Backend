using PokeislandCRUD.Models;

namespace PokeislandCRUD.BL;

public interface IUserService
{
    Task<User> getUser(string username);
    Task createUser(User newUser);
}