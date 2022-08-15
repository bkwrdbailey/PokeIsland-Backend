using PokeislandCRUD.Models;

namespace PokeislandCRUD.BL;

public interface IPokemonService
{
    Task<List<Pokemon>> getUserPokemon(int userId);
    Task addUserPokemon(Pokemon poke);
    Task updateUserPokemon(List<Pokemon> poke);
}