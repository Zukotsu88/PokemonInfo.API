using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonInfo.API.Migrations
{
    public partial class PokemonInfoDBInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Hp = table.Column<int>(type: "integer", nullable: false),
                    Attack = table.Column<int>(type: "integer", nullable: false),
                    Defense = table.Column<int>(type: "integer", nullable: false),
                    SpAtk = table.Column<int>(type: "integer", nullable: false),
                    SpDef = table.Column<int>(type: "integer", nullable: false),
                    Speed = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "pokemons",
                columns: new[] { "Id", "Attack", "Defense", "Description", "Hp", "Name", "SpAtk", "SpDef", "Speed" },
                values: new object[,]
                {
                    { 1, 49, 49, "Dinosaur grass pokemon", 45, "Bulbasaur", 65, 65, 45 },
                    { 2, 62, 63, "Next Dinosaur grass pokemon", 60, "Ivysaur", 80, 80, 60 },
                    { 3, 82, 83, "Final Dinosaur grass pokemon", 80, "Venusaur", 100, 100, 80 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pokemons");
        }
    }
}
