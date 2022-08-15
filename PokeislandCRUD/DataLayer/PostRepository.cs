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

    public async Task<Pagination<Post>> getPosts(int pageNum)
    {
        Pagination<Post> posts = new Pagination<Post>();
        posts.items = await _context.Posts.OrderBy(i => i.id > 1).Skip(pageNum * 5).Take(5).ToListAsync();
        posts.totalElements = await _context.Posts.CountAsync();
        if (posts.totalElements < ((pageNum + 1) * 5))
        {
            posts.hasNext = false;
        }
        else
        {
            posts.hasNext = true;
        }

        return posts;
    }
}