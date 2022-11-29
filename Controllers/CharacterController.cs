using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
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

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characterList);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characterList.FirstOrDefault(item => item.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character character)
        {
            characterList.Add(character);
            return Ok(characterList);
        }
        
    }
}