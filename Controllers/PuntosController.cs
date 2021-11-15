using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TercerParcial.Data;
using TercerParcial.Models;

namespace TercerParcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuntosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PuntosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Puntos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Puntos>>> GetPuntos()
        {
            return await _context.Puntos.ToListAsync();
        }

        // GET: api/Puntos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Puntos>> GetPuntos(string id)
        {
            var puntos = await _context.Puntos.FindAsync(id);

            if (puntos == null)
            {
                return NotFound();
            }

            return puntos;
        }

        // PUT: api/Puntos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPuntos(string id, Puntos puntos)
        {
            if (id != puntos.nombre)
            {
                return BadRequest();
            }

            _context.Entry(puntos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PuntosExists(id))
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

        // POST: api/Puntos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Puntos>> PostPuntos(Puntos puntos)
        {
            _context.Puntos.Add(puntos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PuntosExists(puntos.nombre))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPuntos", new { id = puntos.nombre }, puntos);
        }

        // DELETE: api/Puntos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePuntos(string id)
        {
            var puntos = await _context.Puntos.FindAsync(id);
            if (puntos == null)
            {
                return NotFound();
            }

            _context.Puntos.Remove(puntos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PuntosExists(string id)
        {
            return _context.Puntos.Any(e => e.nombre == id);
        }
    }
}
