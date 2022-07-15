using AutoMapper;

namespace PokemonInfo.API.Profiles
{
    public class PokemonProfile : Profile
    {
       public PokemonProfile()
       {
            CreateMap<Entities.Pokemon, Models.PokemonDto>();
            CreateMap<Models.PokemonForUpdateDto, Entities.Pokemon>();
            CreateMap<Models.PokemonForCreationDto, Entities.Pokemon>();
            CreateMap<Entities.Pokemon, Models.PokemonForUpdateDto>();
       }
    }
}
