using System.ComponentModel.DataAnnotations;

namespace PokemonInfo.API.Models
{
    public class PokemonForUpdateDto
    {
        /// <summary>
        /// Pokemon Name
        /// </summary>
        [Required(ErrorMessage = "Please name your pokemon")]
        [MaxLength(70)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Pokemon description
        /// </summary>
        [MaxLength(250)]
        [Required]
        public string? Description { get; set; }

        /// <summary>
        /// the first type of the pokemon
        /// </summary>
        [Required]
        public string PrimaryType { get; set; } = string.Empty;

        /// <summary>
        /// The second type of the pokemon
        /// </summary>
        [Required]
        public string SecondaryType { get; set; } = string.Empty;

        /// <summary>
        /// the hp points
        /// </summary>
        [Required]
        public int Hp { get; set; } = 0;
        /// <summary>
        /// the attack points
        /// </summary>

        [Required] public int Attack { get; set; } = 0;
        /// <summary>
        /// The defense points
        /// </summary>
        [Required] public int Defense { get; set; } = 0;
        /// <summary>
        /// the special attack points
        /// </summary>
        [Required] public int SpAtk { get; set; } = 0;

        /// <summary>
        /// the special defense points
        /// </summary>
        [Required] public int SpDef { get; set; } = 0;

        /// <summary>
        /// the speed points
        /// </summary>
        [Required] public int Speed { get; set; } = 0;
    }
}
