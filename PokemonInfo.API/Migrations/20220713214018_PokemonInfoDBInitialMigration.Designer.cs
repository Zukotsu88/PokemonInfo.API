﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PokemonInfo.API.DbContexts;

#nullable disable

namespace PokemonInfo.API.Migrations
{
    [DbContext(typeof(PokemonInfoContext))]
    [Migration("20220713214018_PokemonInfoDBInitialMigration")]
    partial class PokemonInfoDBInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PokemonInfo.API.Entities.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Attack")
                        .HasColumnType("integer");

                    b.Property<int>("Defense")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Hp")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SpAtk")
                        .HasColumnType("integer");

                    b.Property<int>("SpDef")
                        .HasColumnType("integer");

                    b.Property<int>("Speed")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("pokemons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attack = 49,
                            Defense = 49,
                            Description = "Dinosaur grass pokemon",
                            Hp = 45,
                            Name = "Bulbasaur",
                            SpAtk = 65,
                            SpDef = 65,
                            Speed = 45
                        },
                        new
                        {
                            Id = 2,
                            Attack = 62,
                            Defense = 63,
                            Description = "Next Dinosaur grass pokemon",
                            Hp = 60,
                            Name = "Ivysaur",
                            SpAtk = 80,
                            SpDef = 80,
                            Speed = 60
                        },
                        new
                        {
                            Id = 3,
                            Attack = 82,
                            Defense = 83,
                            Description = "Final Dinosaur grass pokemon",
                            Hp = 80,
                            Name = "Venusaur",
                            SpAtk = 100,
                            SpDef = 100,
                            Speed = 80
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
