using Microsoft.AspNetCore.Mvc;
using PokeislandCRUD.Models;
using PokeislandCRUD.BL;

namespace PokeislandCRUD.Controllers;

[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentService _bl;
    public CommentController(ICommentService bl)
    {
        _bl = bl;
    }

    [HttpGet("comment/{}")]
    public async Task<List<Comment>> getComments(int postId)
    {
        return await _bl.getComments(postId);
    }

    [HttpPost("comment/{}")]
    public async Task addComment(Comment newComment)
    {
        await _bl.addComment(newComment);
    }
}