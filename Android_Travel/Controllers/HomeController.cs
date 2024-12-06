using Android_Travel.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Android_Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DbTravelContext _context;
        public HomeController(DbTravelContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult getAll()
        {
            return Ok(new
            {
                data= _context.DanhMucs.ToList()
            });
        } 
    }
}
