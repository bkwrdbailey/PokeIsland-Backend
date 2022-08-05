using PokeislandCRUD.Models;
using PokeislandCRUD.DataLayer;

namespace PokeislandCRUD.BL;

public class PokemonService : IPokemonService
{
    private readonly IPokemonRepository _dl;
    public PokemonService(IPokemonRepository dl)
    {
        _dl = dl;
    }

    public async Task<List<Pokemon>> getUserPokemon(int userId)
    {
        return await _dl.getAllUsersPokemon(userId);
    }
}