using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonInfo.API.Migrations
{
    public partial class SecondSeedingMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrimaryType",
                table: "pokemons",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryType",
                table: "pokemons",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PrimaryType", "SecondaryType" },
                values: new object[] { "Seed Dino", "grass", "poison" });

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PrimaryType", "SecondaryType" },
                values: new object[] { "Seed Dino", "grass", "poison" });

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PrimaryType", "SecondaryType" },
                values: new object[] { "Final Seed Dinosaur", "grass", "poison" });

            migrationBuilder.InsertData(
                table: "pokemons",
                columns: new[] { "Id", "Attack", "Defense", "Description", "Hp", "Name", "PrimaryType", "SecondaryType", "SpAtk", "SpDef", "Speed" },
                values: new object[,]
                {
                    { 4, 52, 43, "Fire lizard", 39, "Charmander", "fire", "", 60, 50, 65 },
                    { 5, 64, 58, "Next fire lizard", 58, "Charmeleon", "fire", "", 80, 65, 80 },
                    { 6, 84, 78, "Biggest fire lizard", 78, "Charizard", "fire", "flying", 109, 85, 100 },
                    { 7, 48, 65, "Small turtle", 44, "Squirtle", "water", "", 50, 64, 43 },
                    { 8, 63, 80, "medium turtle", 59, "Wartortle", "water", "", 65, 80, 58 },
                    { 9, 83, 100, "Hydropower turtle", 79, "Blastoise", "water", "", 85, 105, 78 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "PrimaryType",
                table: "pokemons");

            migrationBuilder.DropColumn(
                name: "SecondaryType",
                table: "pokemons");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Dinosaur grass pokemon");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Next Dinosaur grass pokemon");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Final Dinosaur grass pokemon");
        }
    }
}
