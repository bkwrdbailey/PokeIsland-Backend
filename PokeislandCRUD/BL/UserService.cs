using PokeislandCRUD.Models;
using PokeislandCRUD.DataLayer;

namespace PokeislandCRUD.BL;

public class UserService : IUserService
{
    private readonly IUserRepository _dl;
    public UserService(IUserRepository dl)
    {
        _dl = dl;
    }

    public async Task<User> getUser(string username)
    {
        return await _dl.getUser(username);
    }

    public async Task createUser(User newUser)
    {
        await _dl.addUser(newUser);
    }

    public async Task<User> getUserById(int userId)
    {
        return await _dl.getUserById(userId); 
    }
}