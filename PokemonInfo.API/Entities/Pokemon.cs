using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonInfo.API.Entities
{
    /// <summary>
    /// The main entity class for a pokemon
    /// </summary>
    public class Pokemon
    {   // TODO:
        // doing Image as a file 

        /// <summary>
        /// The ID of the pokemon
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        /// <summary>
        /// The name of the pokemon
        /// </summary>
        [Required]
        [MaxLength(70)]
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// The description of the pokemon
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

        public Pokemon(int id, string name, string description, string primaryType, string secondaryType,
            int hp, int attack, int defense, int spAtk, int spDef, int speed)
        {
            Id = id;
            Name = name;
            Description = description;
            PrimaryType = primaryType;
            SecondaryType = secondaryType;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            SpAtk = spAtk;
            SpDef = spDef;
            Speed = speed;
        }

        public Pokemon() { }
    }
}
