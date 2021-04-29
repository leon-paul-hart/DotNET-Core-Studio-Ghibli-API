using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using StudioGhibliApi.Data.CharacterDbContext;
using StudioGhibliApi.Models.Character;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGhibliApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly CharacterContext _context;

        public CharactersController(CharacterContext context)
        {
            _context = context;
        }

        // GET: api/Characters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacter()
        {
            return await _context.Character.ToListAsync();
        }

        // GET: api/Characters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            Character character = await _context.Character.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }

        // PUT: api/Character/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacter(int id, Character character)
        {
            if (id != character.CharacterId)
            {
                return BadRequest();
            }

            _context.Entry(character).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Character
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Character>> PostCharacter(Character character)
        {
            _context.Character.Add(character);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacter", new { id = character.CharacterId }, character);
        }

        // DELETE: api/Character/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Character>> DeleteCharacter(int id)
        {
            Character character = await _context.Character.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            _context.Character.Remove(character);

            await _context.SaveChangesAsync();

            return character;
        }

        private bool CharacterExists(int id)
        {
            return _context.Character.Any(character => character.CharacterId == id);
        }
    }
}
