using Microsoft.EntityFrameworkCore;
using PokemonInfo.API.Entities;

namespace PokemonInfo.API.DbContexts
{
    public class PokemonInfoContext : DbContext
    {
        public DbSet<Pokemon> pokemons { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // put pokemon info here
            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon(1, "Bulbasaur", "Seed Dino", "grass", "poison", 45, 49, 49, 65, 65, 45),
                new Pokemon(2, "Ivysaur", "Seed Dino", "grass", "poison", 60, 62, 63, 80, 80, 60),
                new Pokemon(3, "Venusaur", "Final Seed Dinosaur", "grass", "poison", 80, 82, 83, 100, 100, 80),
                new Pokemon(4, "Charmander", "Fire lizard", "fire", "", 39, 52, 43, 60, 50, 65),
                new Pokemon(5, "Charmeleon", "Next fire lizard", "fire", "", 58, 64, 58, 80, 65, 80),
                new Pokemon(6, "Charizard", "Biggest fire lizard", "fire", "flying", 78, 84, 78, 109, 85, 100),
                new Pokemon(7, "Squirtle", "Small turtle", "water", "", 44, 48, 65, 50, 64, 43),
                new Pokemon(8, "Wartortle", "medium turtle", "water", "", 59, 63, 80, 65, 80, 58),
                new Pokemon(9, "Blastoise", "Hydropower turtle", "water", "", 79, 83, 100, 85, 105, 78));
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql(configuration.GetConnectionString("PokemonDb"));
        //}

        // provide config at inheritance config
        public PokemonInfoContext(DbContextOptions<PokemonInfoContext> options) : base(options)
        {
            
        }

    }
}
