using AutoMapper;
using webapi.Dto.Character;
using webapi.Models;

namespace webapi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
