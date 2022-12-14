using PokeislandCRUD.Models;
using PokeislandCRUD.DataLayer;

namespace PokeislandCRUD.BL;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _dl;
    public CommentService(ICommentRepository dl)
    {
        _dl = dl;
    }

    public async Task<Pagination<Comment>> getComments(int postId)
    {
        return await _dl.getComments(postId);
    }

    public async Task<Pagination<Comment>> getMoreComments(int postId, int pageNum)
    {
        return await _dl.getMoreComments(postId, pageNum);
    }

    public async Task addComment(Comment newComment)
    {
        await _dl.addComment(newComment);
    }
}