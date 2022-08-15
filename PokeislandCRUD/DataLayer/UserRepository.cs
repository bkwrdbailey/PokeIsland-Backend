using PokeislandCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace PokeislandCRUD.DataLayer;

public class UserRepository : IUserRepository
{
    private readonly PokeDBContext _context;
    public UserRepository(PokeDBContext context)
    {
        _context = context;
    }

    public async Task<User> getUser(string username)
    {
        return await _context.Users.FirstAsync(u => u.username == username);
    }

    public async Task<User> getUserById(int userId)
    {
        return await _context.Users.FirstAsync(u => u.id == userId);
    }

    public async Task addUser(User newUser)
    {
        await _context.Users.AddAsync(newUser);
        await _context.SaveChangesAsync();
    }

    public async Task updateUserInfo(User updatedUser)
    {
        _context.Users.Update(updatedUser);
        await _context.SaveChangesAsync();
    }
}