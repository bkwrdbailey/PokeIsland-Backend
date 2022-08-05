using Microsoft.EntityFrameworkCore;
using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public class PokeDBContext : DbContext
{
    public PokeDBContext() : base() { }
    public PokeDBContext(DbContextOptions options) : base(options) {}
    public DbSet<User> Users { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}