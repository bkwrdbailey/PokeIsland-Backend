using PokeislandCRUD.Models;

namespace PokeislandCRUD.BL;

public interface IPostService
{
    Task addPost(Post newPost);
    Task<List<Post>> getPosts(int pageNum);
}