using Android_Travel.Entities;

namespace Android_Travel.Dto.Respone
{
    public class TicketRespone
    {
        public int Id { get; set; }

        public string TenVe { get; set; } = null!;

        public int IddanhMuc { get; set; }

        public double GiaTre { get; set; }

        public int SoLuong { get; set; }

        public DateOnly? NgayBatDau { get; set; }

        public DateOnly? NgayKetThuc { get; set; }

        public string? MoTa { get; set; }

        public string? HinhAnh { get; set; }

        public ThanhPho ThanhPho { get; set; }

        public double? GiaNguoiLon { get; set; }
        public virtual ICollection<DiemNoiBat> DiemNoiBats { get; set; } = new List<DiemNoiBat>();
    }
}
