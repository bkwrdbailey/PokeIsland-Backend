
namespace PokeislandCRUD.Models;

public class Post
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public int userId { get; set; }
}