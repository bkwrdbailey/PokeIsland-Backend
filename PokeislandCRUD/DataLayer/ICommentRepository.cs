using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public interface ICommentRepository
{
    Task addComment(Comment newComment);
    Task<List<Comment>> getComments(int postId);
}