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
    public class ThanhToansController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ThanhToansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ThanhToans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThanhToan>>> GetThanhToan()
        {
            return await _context.ThanhToan.ToListAsync();
        }

        // GET: api/ThanhToans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThanhToan>> GetThanhToan(int id)
        {
            var thanhToan = await _context.ThanhToan.FindAsync(id);

            if (thanhToan == null)
            {
                return NotFound();
            }

            return thanhToan;
        }

        // PUT: api/ThanhToans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThanhToan(int id, ThanhToan thanhToan)
        {
            if (id != thanhToan.Id)
            {
                return BadRequest();
            }

            _context.Entry(thanhToan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThanhToanExists(id))
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

        // POST: api/ThanhToans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ThanhToan>> PostThanhToan(ThanhToan thanhToan)
        {
            _context.ThanhToan.Add(thanhToan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThanhToan", new { id = thanhToan.Id }, thanhToan);
        }

        // DELETE: api/ThanhToans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThanhToan(int id)
        {
            var thanhToan = await _context.ThanhToan.FindAsync(id);
            if (thanhToan == null)
            {
                return NotFound();
            }

            _context.ThanhToan.Remove(thanhToan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThanhToanExists(int id)
        {
            return _context.ThanhToan.Any(e => e.Id == id);
        }
    }
}
