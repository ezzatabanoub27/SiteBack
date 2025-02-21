using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ray2.Data.ContextApp;

namespace Ray2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        private readonly RaykContext _db;
        public TracksController(RaykContext db)
        {
            _db = db;
        }

        [HttpGet("AllTracks")]

        public async Task<IActionResult> AllTracks()
        {
            var AllTracks = await _db.Tracks.ToListAsync();
            return Ok(AllTracks);
        }


        


    }
}
