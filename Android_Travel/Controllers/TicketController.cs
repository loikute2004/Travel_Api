using Android_Travel.Dto.Respone;
using Android_Travel.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Android_Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly DbTravelContext _context;
        public TicketController(DbTravelContext context) { 
            _context = context;
        }

        [HttpGet]
        public IActionResult getAll(int id) {
            List<Ve> list;
            if (id == 0) {
                list = _context.Ves.ToList();
            }
            else
            {
                list = _context.Ves.Where(x=>x.IddanhMuc == id).ToList();
            }
            List<TicketRespone> tickets = new List<TicketRespone>();
            foreach (var item in list)
            {
                tickets.Add(new TicketRespone()
                {
                    Id = item.Id,
                    TenVe = item.TenVe,
                    SoLuong = item.SoLuong,
                    GiaTre = item.GiaTre,
                    NgayBatDau = item.NgayBatDau,
                    NgayKetThuc = item.NgayKetThuc,
                    MoTa = item.MoTa,
                    HinhAnh = item.HinhAnh,
                    ThanhPho = item.IdthanhPhoNavigation,
                    GiaNguoiLon = item.GiaNguoiLon,
                    DiemNoiBats = item.DiemNoiBats
                });
            }
            return Ok(new ResponeDto<List<TicketRespone>>
            {
                Data = tickets,
                Message = "Danh sach ve",
                Success = true
            });
        }
    }
}
