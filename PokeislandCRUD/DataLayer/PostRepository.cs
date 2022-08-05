using PokeislandCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace PokeislandCRUD.DataLayer;

public class PostRepository : IPostRepository
{
    private readonly PokeDBContext _context;
    public PostRepository(PokeDBContext context)
    {
        _context = context;
    }

    public async Task createNewPost(Post newPost)
    {
        await _context.Posts.AddAsync(newPost);
    }

    public async Task<List<Post>> getPosts(int pageNum)
    {
        return await _context.Posts.OrderBy(i => i.id > 1).Skip(pageNum * 5).Take(5).ToListAsync();
    }
}