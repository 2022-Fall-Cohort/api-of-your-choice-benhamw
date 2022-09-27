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
        public async Task<ActionResult<IEnumerable<Flyrod>>> GetFlyrods()
        {
            return await _db.Flyrod.ToListAsync();
        }
    }
}
