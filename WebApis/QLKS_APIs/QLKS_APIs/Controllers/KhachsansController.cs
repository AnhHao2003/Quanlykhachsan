using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLKS_APIs.Controllers.Data;
using QLKS_APIs.Controllers.Models;

namespace QLKS_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachsansController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KhachsansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Khachsans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Khachsan>>> GetKhachsan()
        {
            return await _context.Khachsan.ToListAsync();
        }

        // GET: api/Khachsans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Khachsan>> GetKhachsan(int? id)
        {
            var khachsan = await _context.Khachsan.FindAsync(id);

            if (khachsan == null)
            {
                return NotFound();
            }

            return khachsan;
        }

        // PUT: api/Khachsans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhachsan(int? id, Khachsan khachsan)
        {
            if (id != khachsan.Id)
            {
                return BadRequest();
            }

            _context.Entry(khachsan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhachsanExists(id))
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

        // POST: api/Khachsans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Khachsan>> PostKhachsan(Khachsan khachsan)
        {
            _context.Khachsan.Add(khachsan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKhachsan", new { id = khachsan.Id }, khachsan);
        }

        // DELETE: api/Khachsans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhachsan(int? id)
        {
            var khachsan = await _context.Khachsan.FindAsync(id);
            if (khachsan == null)
            {
                return NotFound();
            }

            _context.Khachsan.Remove(khachsan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KhachsanExists(int? id)
        {
            return _context.Khachsan.Any(e => e.Id == id);
        }
    }
}
