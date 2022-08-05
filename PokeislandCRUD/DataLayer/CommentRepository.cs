using PokeislandCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace PokeislandCRUD.DataLayer;

public class CommentRepository : ICommentRepository
{
    private readonly PokeDBContext _context;
    public CommentRepository(PokeDBContext context)
    {
        _context = context;
    }

    public async Task addComment(Comment newComment)
    {
        await _context.Comments.AddAsync(newComment);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Comment>> getComments(int postId)
    {
        return await _context.Comments.Where(c => c.postId == postId).ToListAsync();
    }

}