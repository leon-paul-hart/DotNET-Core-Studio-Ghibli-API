﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudioGhibliApi.Data;
using StudioGhibliApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGhibliApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly FilmContext _context;

        public FilmsController(FilmContext context)
        {
            _context = context;
        }

        // GET: api/Films
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film>>> GetFilm()
        {
            return await _context.Film.ToListAsync();
        }

        // GET: api/Films/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetFilm(int id)
        {
            var film = await _context.Film.FindAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return film;
        }

        // PUT: api/Films/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilm(int id, Film film)
        {
            if (id != film.Id)
            {
                return BadRequest();
            }

            _context.Entry(film).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmExists(id))
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

        // POST: api/Films
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Film>> PostFilm(Film film)
        {
            _context.Film.Add(film);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilm", new { id = film.Id }, film);
        }

        // DELETE: api/Films/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Film>> DeleteFilm(int id)
        {
            var film = await _context.Film.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }

            _context.Film.Remove(film);
            await _context.SaveChangesAsync();

            return film;
        }

        private bool FilmExists(int id)
        {
            return _context.Film.Any(e => e.Id == id);
        }
    }
}
