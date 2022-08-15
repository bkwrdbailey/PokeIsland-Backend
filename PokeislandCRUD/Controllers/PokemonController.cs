using Microsoft.AspNetCore.Mvc;
using PokeislandCRUD.Models;
using PokeislandCRUD.BL;

namespace PokeislandCRUD.Controllers;

[ApiController]
public class PokemonController : ControllerBase
{
    private readonly IPokemonService _bl;
    public PokemonController(IPokemonService bl)
    {
        _bl = bl;
    }

    [HttpGet("pokemon/{userId}")]
    public async Task<List<Pokemon>> getPokemon(int userId)
    {
        return await _bl.getUserPokemon(userId);
    }

    [HttpPost("pokemon")]
    public async Task addPokemon([FromBody] Pokemon poke)
    {
        await _bl.addUserPokemon(poke);
    }

    [HttpPut("pokemon")]
    public async Task updatePokemon([FromBody] List<Pokemon> poke)
    {
        await _bl.updateUserPokemon(poke);
    }

}