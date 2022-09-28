using api_of_your_choice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Maker>>> GetMakers()
        //{
        //    return await _db.Makers.ToListAsync();
        //}

        //public async Task<ActionResult<IEnumerable<Flyrod>>> GetFlyrods()
        //{
        //    return await _db.Flyrods.ToListAsync();
        //}

        //public async Task<ActionResult<IEnumerable<Flyrod>>> GetFlyrods()
        //{
        //    return await _db.Flyrods.Include(x => x.Maker).ToListAsync();
        //}

        public async Task<ActionResult<IEnumerable<Maker>>> GetMakers()
        {
            return await _db.Makers.Include(x => x.Flyrods).ToListAsync();
        }

        //public IEnumerable<Maker> GetMakers()
        //{
        //    IEnumerable<Maker> makers =
        //        _db.Makers.Include(x => x.Flyrods).ToList();

        //    return makers;
        //}
    }
}
