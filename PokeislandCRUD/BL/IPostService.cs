using PokeislandCRUD.Models;

namespace PokeislandCRUD.BL;

public interface IPostService
{
    Task addPost(Post newPost);
    Task<Pagination<Post>> getPosts(int pageNum);
}