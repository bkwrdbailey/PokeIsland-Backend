using PokeislandCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace PokeislandCRUD.DataLayer;

public class PokemonRepository : IPokemonRepository
{
    private readonly PokeDBContext _context;
    public PokemonRepository(PokeDBContext context)
    {
        _context = context;
    }

    public async Task<List<Pokemon>> getAllUsersPokemon(int userId)
    {
        return await _context.Pokemons.Where(p => p.userId == userId).ToListAsync();
    }

    public async Task updateUserPokemon(List<Pokemon> updatedPokemon)
    {
        foreach (Pokemon poke in updatedPokemon)
        {
            _context.Pokemons.Update(poke);
        }
        await _context.SaveChangesAsync();
    }

    public async Task addNewPokemon(Pokemon newPokemon)
    {
        await _context.Pokemons.AddAsync(newPokemon);
        await _context.SaveChangesAsync();
    }
}