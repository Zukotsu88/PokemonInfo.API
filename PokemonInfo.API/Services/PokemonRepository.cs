using Microsoft.EntityFrameworkCore;
using PokemonInfo.API.DbContexts;
using PokemonInfo.API.Entities;

namespace PokemonInfo.API.Services
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonInfoContext _context;

        public PokemonRepository(PokemonInfoContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddPokemon(Pokemon pokemon)
        {
            await _context.AddAsync(pokemon);
        }

        public void DeletePokemon(Pokemon pokemon)
        {
            _context.pokemons.Remove(pokemon);
        }

        // returns the pokemon matching this Id
        public async Task<Pokemon?> GetPokemonAsync(int pokemonId)
        {
            return await _context.pokemons.Where(p => p.Id == pokemonId).FirstOrDefaultAsync();
        }

        // returns the list of all pokemon
        public async Task<IEnumerable<Pokemon>> GetPokemonsAsync()
        {
            return await _context.pokemons.OrderBy(c => c.Id).ToListAsync();
        }

        // returns the list but filtered and searched as well 
        public async Task<IEnumerable<Pokemon>> GetPokemonsAsync(string? name, string? searchQuery)
        {
            var collection = _context.pokemons as IQueryable<Pokemon>;

            // use deferred execution here

            if(!string.IsNullOrEmpty(name)) // filtering 
            {
                name = name.Trim();
                collection = collection.Where(c => c.Name == name);
            }

            if(!string.IsNullOrEmpty(searchQuery)) // searching
            {
                searchQuery = searchQuery.Trim();
                collection = collection.Where(p => p.Name.Contains(searchQuery) || (p.Description != null 
                    && p.Description.Contains(searchQuery)));
            }

            return await collection.OrderBy(p => p.Id).ToListAsync();
        }

        // returns whether the pokemon with the given id exists or not
        public async Task<bool> PokemonExistsAsync(int pokemonId)
        {
            return await _context.pokemons.AnyAsync(p => p.Id == pokemonId);
        }

        // returns whether the name matches the given Id
        public async Task<bool> PokemonNameMatchesPokemonId(string? pokeName, int pokemonId)
        {
            return await _context.pokemons.AnyAsync(p => p.Id == pokemonId && p.Name == pokeName);
        }

        // persist the changes to the database
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0; // returns number of changed entities in this database
        }
    }
}
