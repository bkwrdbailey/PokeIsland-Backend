using PokeislandCRUD.Models;

namespace PokeislandCRUD.BL;

public interface ICommentService
{
    Task<List<Comment>> getComments(int postId);
    Task addComment(Comment newComment);
}