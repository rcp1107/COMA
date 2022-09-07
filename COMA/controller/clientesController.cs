using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMA.contexto;
using COMA.model;

namespace COMA.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class clientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public clientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/clientes. Permite enlistar los datos de la base de datos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<clientes>>> Getclientes()
        {
          if (_context.clientes == null)
          {
              return NotFound();
          }
            return await _context.clientes.ToListAsync();
        }

        // GET: api/clientes/ Permite realizar una consulta de un id en particular
        [HttpGet("{id}")]
        public async Task<ActionResult<clientes>> Getclientes(int id)
        {
          if (_context.clientes == null)
          {
              return NotFound();
          }
            var clientes = await _context.clientes.FindAsync(id);

            if (clientes == null)
            {
                return NotFound();
            }

            return clientes;
        }

        // PUT: api/clientes/ actualizar  dato en la tabla con id en particular
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putclientes(int id, clientes clientes)
        {
            if (id != clientes.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clientesExists(id))
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

        // POST: api/clientes. Permite insertar nuevo dato 
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<clientes>> Postclientes(clientes clientes)
        {
          if (_context.clientes == null)
          {
              return Problem("Entity set 'ApplicationDbContext.clientes'  is null.");
          }
            _context.clientes.Add(clientes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getclientes", new { id = clientes.Id }, clientes);
        }

        // DELETE: api/clientes/ Permite eliminar un id en particualar
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteclientes(int id)
        {
            if (_context.clientes == null)
            {
                return NotFound();
            }
            var clientes = await _context.clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }

            _context.clientes.Remove(clientes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool clientesExists(int id)
        {
            return (_context.clientes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
