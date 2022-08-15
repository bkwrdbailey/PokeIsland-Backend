using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public interface IPostRepository
{
    Task createNewPost(Post newPost);
    Task<Pagination<Post>> getPosts(int pageNum);
}