﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvtur_Viagens_API.Context;
using Mvtur_Viagens_API.Models;

namespace Mvtur_Viagens_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagensController : ControllerBase
    {
        private readonly DataContext _context;

        public PassagensController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Passagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passagens>>> GetPassagens()
        {
          if (_context.Passagens == null)
          {
              return NotFound();
          }
            return await _context.Passagens.ToListAsync();
        }

        // GET: api/Passagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passagens>> GetPassagens(int id)
        {
          if (_context.Passagens == null)
          {
              return NotFound();
          }
            var passagens = await _context.Passagens.FindAsync(id);

            if (passagens == null)
            {
                return NotFound();
            }

            return passagens;
        }

        // PUT: api/Passagens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassagens(int id, Passagens passagens)
        {
            if (id != passagens.Id)
            {
                return BadRequest();
            }

            _context.Entry(passagens).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassagensExists(id))
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

        // POST: api/Passagens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Passagens>> PostPassagens(Passagens passagens)
        {
          if (_context.Passagens == null)
          {
              return Problem("Entity set 'DataContext.Passagens'  is null.");
          }
            _context.Passagens.Add(passagens);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPassagens", new { id = passagens.Id }, passagens);
        }

        // DELETE: api/Passagens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassagens(int id)
        {
            if (_context.Passagens == null)
            {
                return NotFound();
            }
            var passagens = await _context.Passagens.FindAsync(id);
            if (passagens == null)
            {
                return NotFound();
            }

            _context.Passagens.Remove(passagens);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PassagensExists(int id)
        {
            return (_context.Passagens?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
