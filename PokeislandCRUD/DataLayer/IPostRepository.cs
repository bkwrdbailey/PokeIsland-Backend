using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public interface IPostRepository
{
    Task createNewPost(Post newPost);
    Task<List<Post>> getPosts(int pageNum);
}