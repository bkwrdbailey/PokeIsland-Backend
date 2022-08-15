using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public interface IUserRepository
{
    Task<User> getUser(string username);
    Task<User> getUserById(int userId);
    Task addUser(User newUser);
    Task updateUserInfo(User updatedUser);
}