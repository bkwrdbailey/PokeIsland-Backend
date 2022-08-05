using PokeislandCRUD.Models;

namespace PokeislandCRUD.DataLayer;

public interface IPokemonRepository
{
    Task<List<Pokemon>> getAllUsersPokemon(int userId);
    Task updateUserPokemon(List<Pokemon> updatedPokemon);
    Task addNewPokemon(Pokemon newPokemon);
}