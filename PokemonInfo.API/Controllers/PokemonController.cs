using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonInfo.API.Entities;
using PokemonInfo.API.Models;
using PokemonInfo.API.Services;

namespace PokemonInfo.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/pokemon")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            this._pokemonRepository = pokemonRepository ?? throw new ArgumentNullException(nameof(pokemonRepository));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        ///  Returns the list of all pokemon
        /// </summary>
        /// <param name="name">filter query</param>
        /// <param name="searchQuery">search query</param>
        /// <returns>An ActionResult of IEnumerable of PokemonDto </returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PokemonDto>>> GetPokemons([FromQuery] string? name, [FromQuery] string? searchQuery)
        {
            var pokemonEntities = await _pokemonRepository.GetPokemonsAsync(name, searchQuery);
            return Ok(_mapper.Map<IEnumerable<PokemonDto>>(pokemonEntities));
        }

        /// <summary>
        /// Get pokemon by id
        /// </summary>
        /// <param name="id"> the id of the pokemon to get</param>
        /// <returns>An IActionResult</returns>
        /// <response code="200">Returns the requested pokemon</response>
        [HttpGet("{pokemonId}", Name = "GetPokemon")] // use syntax to pass params in uri; return IAction Result to be more generic for differing Dto's
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPokemon(int pokemonId)
        {
            var pokemon = await _pokemonRepository.GetPokemonAsync(pokemonId);

            if(pokemon == null)
            {
                return NotFound();
            }
    
            return Ok(_mapper.Map<PokemonDto>(pokemon));
        }

        /// <summary>
        /// Will create a new pokemon entry for this pokemon and return created result
        /// </summary>
        /// <param name="pokemon">The DTO of the pokemon for creation</param>
        /// <returns>An ActionResult of PokemonDTO</returns>
        [HttpPost]
        public async Task<ActionResult<PokemonDto>> CreatePokemon([FromBody] PokemonForCreationDto pokemon)
        {
            // map dto to an entitiy and generate the id
            var pokeEntity = _mapper.Map<Pokemon>(pokemon);

            // add to database
            await _pokemonRepository.AddPokemon(pokeEntity);
            await _pokemonRepository.SaveChangesAsync();

            // map the entity back to a normal dto
            var pokeDto = _mapper.Map<PokemonDto>(pokeEntity);

            return CreatedAtRoute("GetPokemon",
                new
                {
                    Id = pokeDto.Id,
                    Description = pokeDto.Description,
                    PrimaryType = pokeDto.PrimaryType,
                    SecondaryType = pokeDto.SecondaryType,
                    Hp = pokeDto.Hp,
                    Attack = pokeDto.Attack,
                    Defense = pokeDto.Defense,
                    SpAtk = pokeDto.SpAtk,
                    SpDef = pokeDto.SpDef,
                    Speed = pokeDto.Speed
                }, pokeDto);
        }





    }
}
