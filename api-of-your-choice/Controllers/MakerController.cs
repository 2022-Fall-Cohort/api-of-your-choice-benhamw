using api_of_your_choice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace api_of_your_choice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakerController : ControllerBase
    {
        private FlyrodContext _db;

        public MakerController(FlyrodContext db)
        {
            _db = db;
        }

        // GET/POST/UPDATE/DELETE STARTS HERE

        [HttpGet]
        // Previous table join using virtual list in maker.cs, below:
        // public virtual List<Flyrod> Flyrods { get; set; }
        //
        //public async Task<ActionResult<IEnumerable<Maker>>> GetMakers()
        //{
        //    return await _db.Makers.Include(x => x.Flyrods).ToListAsync();
        //}

        public async Task<ActionResult<IEnumerable<Maker>>> GetMakers()
        {
            return await _db.Makers.ToListAsync();
        }

        // GET: api/Makers/5 - "Read" 1 record from the database
        [HttpGet("{id}")]
        public async Task<ActionResult<Maker>> GetMaker(int id)
        {
            if (_db.Makers == null)
            {
                return NotFound();
            }
            var maker = await _db.Makers.FindAsync(id);

            if (maker == null)
            {
                return NotFound();
            }

            return maker;
        }

        // PUT: api/Maker/5 - "Update" a single record in the database
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaker(int id, Maker maker)
        {
            if (id != maker.Id)
            {
                return BadRequest();
            }

            _db.Entry(maker).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MakerExists(id))
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

        // POST: api/Makers - "Create/Insert" a record into the database
        [HttpPost]
        public async Task<ActionResult<Maker>> PostMaker(Maker maker)
        {
            if (_db.Makers == null)
            {
                return Problem("Entity set 'MakerContext.Makers'  is null.");
            }

            _db.Makers.Add(maker);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetMaker", new { id = maker.Id }, maker);
        }

        // DELETE: api/Makers/5 - "Delete" a record from the database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaker(int id)
        {
            if (_db.Makers == null)
            {
                return NotFound();
            }
            var maker = await _db.Makers.FindAsync(id);
            if (maker == null)
            {
                return NotFound();
            }

            _db.Makers.Remove(maker);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool MakerExists(int id)
        {
            return (_db.Makers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
