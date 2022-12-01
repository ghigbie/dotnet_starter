using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace First_API.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

        private static Character hobbit = new Character();
        private static Character ranger = new Character()
        {
            Name = "Strider",
            Class = RpgClass.Ranger,
        };
        private static Character dwarf = new Character()
        {
            Name = "Gemli",
            Class = RpgClass.Ranger,
        };
        private static List<Character> characterList = new List<Character>()
        {
            hobbit,
            ranger,
            dwarf
        };


        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character character)
        {
            characterList.Add(character);
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characterList;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return new ServiceResponse<List<Character>>(){ Data = characterList };
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            return new ServiceResponse<Character>() { Data = characterList.FirstOrDefault(item => item.Id == id) };
        }
    }
}