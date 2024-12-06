using Android_Travel.Dto.Respone;
using Android_Travel.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Android_Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DbTravelContext _context;
        public CategoryController(DbTravelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult getAll()
        {
            ResponeDto<List<DanhMuc>> res = new ResponeDto<List<DanhMuc>>();
            try
            {
                res.Data = _context.DanhMucs.ToList();
                res.Success = true;
            }
            catch (Exception ex) { 
                res.Success = false;
                res.Message = ex.Message;
                return BadRequest(res);
            }
            return Ok(res);
        }

        [HttpDelete]
        public ActionResult delete(int id) {
            try
            {
                DanhMuc dm = _context.DanhMucs.Where(x=>x.Id == id).First();
                if (dm != null) {
                    _context.DanhMucs.Remove(dm);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
