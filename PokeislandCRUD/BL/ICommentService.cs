using PokeislandCRUD.Models;

namespace PokeislandCRUD.BL;

public interface ICommentService
{
    Task<Pagination<Comment>> getComments(int postId);
    Task<Pagination<Comment>> getMoreComments(int postId, int pageNum);
    Task addComment(Comment newComment);
}