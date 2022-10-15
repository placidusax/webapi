using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Dto.Character;
using webapi.Models;

namespace webapi.Services.CharacterService

{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacter(); 
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id); 
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}
