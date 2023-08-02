using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {

        //not using service way
        // private static  List<Character> characters = new List<Character>{
        //     new Character(),
        //     new Character { Id = 1, Name = "San"}

        // };

        // [HttpGet("GetAll")]
        // public ActionResult<List<Character>> Get()
        // {
        //     return Ok(characters);
        // }

        // [HttpGet("{id}")]
        // public ActionResult<List<Character>> GetSingle(int id)
        // {
        //     return Ok(characters.FirstOrDefault(c => c.Id == id));
        // }

        // [HttpPost]
        // public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        // {
        //     characters.Add(newCharacter);
        //     return Ok(characters);
        // }


        //using service way
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}