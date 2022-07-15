using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonInfo.API.Entities
{
    public class Pokemon
    {   // TODO:
        // doing Image as a file 


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public string PrimaryType { get; set; } = string.Empty;

        public string SecondaryType { get; set; } = string.Empty;

        public int Hp { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAtk { get; set; }

        public int SpDef { get; set; }

        public int Speed { get; set; }

        public Pokemon(int id, string name, string description, string primaryType, string secondaryType, int hp, int attack, int defense, int spAtk, int spDef, int speed)
        {
            Id = id;
            Name = name;
            Description = description;
            this.PrimaryType = primaryType;
            this.SecondaryType = secondaryType;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            SpAtk = spAtk;
            SpDef = spDef;
            Speed = speed;
        }
    }
}
