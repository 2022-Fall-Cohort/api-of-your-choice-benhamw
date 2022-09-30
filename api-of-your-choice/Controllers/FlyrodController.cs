using api_of_your_choice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace api_of_your_choice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlyrodController : ControllerBase
    {
        private FlyrodContext _db;

        public FlyrodController(FlyrodContext db)
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

        public async Task<ActionResult<IEnumerable<Flyrod>>> GetFlyrods()
        {
            return await _db.Flyrods.ToListAsync();
        }

        // GET: api/Flyrods/5 - "Read" 1 record from the database
        [HttpGet("{id}")]
        public async Task<ActionResult<Flyrod>> GetFlyrod(int id)
        {
            if (_db.Flyrods == null)
            {
                return NotFound();
            }
            var flyRod = await _db.Flyrods.FindAsync(id);

            if (flyRod == null)
            {
                return NotFound();
            }

            return flyRod;
        }

        // PUT: api/Flyrods/5 - "Update" a single record in the database
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlyrod(int id, Flyrod flyRod)
        {
            if (id != flyRod.Id)
            {
                return BadRequest();
            }

            _db.Entry(flyRod).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlyRodExists(id))
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

        // POST: api/Flyrods - "Create/Insert" a record into the database
        [HttpPost]
        public async Task<ActionResult<Flyrod>> PostFlyrod(Flyrod flyRod)
        {
            if (_db.Flyrods == null)
            {
                return Problem("Entity set 'FlyrodContext.Flyrods'  is null.");
            }

            //_db.Flyrods.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON"); ;
            _db.Flyrods.Add(flyRod);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetFlyrod", new { id = flyRod.Id }, flyRod);
        }

        // DELETE: api/Flyrods/5 - "Delete" a record from the database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlyrod(int id)
        {
            if (_db.Flyrods == null)
            {
                return NotFound();
            }
            var flyRod = await _db.Flyrods.FindAsync(id);
            if (flyRod == null)
            {
                return NotFound();
            }

            _db.Flyrods.Remove(flyRod);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool FlyRodExists(int id)
        {
            return (_db.Flyrods?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
