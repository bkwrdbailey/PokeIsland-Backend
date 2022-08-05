using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public interface IUserRepository
{
    Task<User> getUser(string username);
    Task addUser(User newUser);
    Task updateUserInfo(User updatedUser);
}