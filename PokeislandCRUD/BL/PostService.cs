using PokeislandCRUD.Models;
using PokeislandCRUD.DataLayer;

namespace PokeislandCRUD.BL;

public class PostService : IPostService
{
    private readonly IPostRepository _dl;
    public PostService(IPostRepository dl)
    {
        _dl = dl;
    }

    public async Task addPost(Post newPost)
    {
        await _dl.createNewPost(newPost);
    }

    public async Task<Pagination<Post>> getPosts(int pageNum)
    {
        return await _dl.getPosts(pageNum);
    }
}