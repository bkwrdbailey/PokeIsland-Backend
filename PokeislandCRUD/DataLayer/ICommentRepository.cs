using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public interface ICommentRepository
{
    Task addComment(Comment newComment);
    Task<Pagination<Comment>> getComments(int postId);
    Task<Pagination<Comment>> getMoreComments(int postId, int pageNum);
}