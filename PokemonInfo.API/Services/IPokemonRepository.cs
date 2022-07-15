using PokemonInfo.API.Entities;

namespace PokemonInfo.API.Services
{
    public interface IPokemonRepository
    {
        Task<IEnumerable<Pokemon>> GetPokemonsAsync();

        Task<IEnumerable<Pokemon>> GetPokemonsAsync(string? name, string? searchQuery); // filtering and searching

        Task<Pokemon?> GetPokemonAsync(int pokemonId);
        Task<bool> PokemonExistsAsync(int pokemonId);

        Task AddPokemon(Pokemon pokemon);
        void DeletePokemon(Pokemon pokemon);

        Task<bool> PokemonNameMatchesPokemonId(string? pokeName, int pokemonId);
        Task<bool> SaveChangesAsync();
    }
}
