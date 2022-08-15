using Microsoft.AspNetCore.Mvc;
using PokeislandCRUD.Models;
using PokeislandCRUD.BL;

namespace PokeislandCRUD.Controllers;

[ApiController]
public class PostController : ControllerBase
{
    private readonly IPostService _bl;

    public PostController(IPostService bl)
    {
        _bl = bl;
    }

    [HttpGet("post/{pageNum}")]
    public async Task<Pagination<Post>> getPosts(int pageNum)
    {
        return await _bl.getPosts(pageNum);
    }

    [HttpPost("post/{newPost}")]
    public async Task addPost([FromBody] Post newPost)
    {
        await _bl.addPost(newPost);
    }
}