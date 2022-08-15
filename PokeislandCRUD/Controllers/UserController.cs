using Microsoft.AspNetCore.Mvc;
using PokeislandCRUD.Models;
using PokeislandCRUD.BL;

namespace PokeislandCRUD.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _bl;

    public UserController(IUserService bl)
    {
        _bl = bl;
    }

    [HttpPost("user")]
    public async Task CreateUser([FromBody] User newUser)
    {
        await _bl.createUser(newUser);
    }

    [HttpGet("user/{username}")]
    public async Task<User> GetUser(string username)
    {
        return await _bl.getUser(username);
    }

    [HttpGet("user/{userId}")]
    public async Task GetUserById(int userId)
    {
        await _bl.getUserById(userId);
    }
}