using System;
using System.Collections.Generic;
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


        public List<Character> AddCharacter(Character character)
        {
            characterList.Add(character);
            return characterList;
        }

        public List<Character> GetAllCharacters()
        {
            return characterList;
        }

        public Character GetCharacterById(int id)
        {
            return characterList.FirstOrDefault(item => item.Id == id);
        }
    }
}