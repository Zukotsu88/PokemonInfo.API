namespace PokemonInfo.API.Models
{
    /// <summary>
    /// This DTO exists for output related to a pokemon
    /// </summary>
    public class PokemonDto
    {
        /// <summary>
        /// Pokemon unique ID 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Pokemon Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Pokemon description
        /// </summary>
        public string? Description { get; set; }
        
        /// <summary>
        /// the first type of the pokemon
        /// </summary>
        public string PrimaryType { get; set; } = string.Empty;

        /// <summary>
        /// The second type of the pokemon
        /// </summary>
        public string SecondaryType { get; set; } = string.Empty;

        /// <summary>
        /// the hp points
        /// </summary>
        public int Hp { get; set; } = 0;
        /// <summary>
        /// the attack points
        /// </summary>
        public int Attack { get; set; } = 0;
        /// <summary>
        /// The defense points
        /// </summary>
        public int Defense { get; set; } = 0;
        /// <summary>
        /// the special attack points
        /// </summary>
        public int SpAtk { get; set; } = 0;

        /// <summary>
        /// the special defense points
        /// </summary>
        public int SpDef { get; set; } = 0;

        /// <summary>
        /// the speed points
        /// </summary>
        public int Speed { get; set; } = 0;

    }
}
