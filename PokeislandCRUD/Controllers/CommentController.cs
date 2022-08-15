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

    [HttpGet("comment/{postId}")]
    public async Task<Pagination<Comment>> getComments(int postId)
    {
        return await _bl.getComments(postId);
    }

    [HttpGet("comment/{postId}&{pageNum}")]
    public async Task<Pagination<Comment>> getMoreComments(int postId, int pageNum)
    {
        return await _bl.getMoreComments(postId, pageNum);
    }

    [HttpPost("comment")]
    public async Task addComment([FromBody] Comment newComment)
    {
        await _bl.addComment(newComment);
    }
}