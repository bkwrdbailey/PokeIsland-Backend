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

    public async Task<Pagination<Comment>> getComments(int postId)
    {
        Pagination<Comment> comments = new Pagination<Comment>();
        comments.items = await _context.Comments.Where(c => c.postId == postId).Take(5).ToListAsync();
        comments.totalElements = await _context.Comments.CountAsync();
        
        if (comments.totalElements < 5)
        {
            comments.hasNext = false;
        }
        else
        {
            comments.hasNext = true;
        }

        return comments;
    }

    public async Task<Pagination<Comment>> getMoreComments(int postId, int pageNum)
    {
        Pagination<Comment> comments = new Pagination<Comment>();
        comments.items = await _context.Comments.Where(c => c.postId == postId).Skip(pageNum * 5).Take(5).ToListAsync();
        comments.totalElements = await _context.Comments.CountAsync();

        if (comments.totalElements < ((pageNum + 1) * 5))
        {
            comments.hasNext = false;
        }
        else
        {
            comments.hasNext = true;
        }

        return comments;
    }

}