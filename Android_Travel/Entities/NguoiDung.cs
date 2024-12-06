using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class NguoiDung
{
    public int Id { get; set; }

    public string HoTen { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string? HinhAnh { get; set; }

    public string MatKhau { get; set; } = null!;

    public string Quyen { get; set; } = null!;

    public virtual ICollection<DanhGium> DanhGia { get; set; } = new List<DanhGium>();

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<ThongBao> ThongBaos { get; set; } = new List<ThongBao>();

    public virtual ICollection<YeuThich> YeuThiches { get; set; } = new List<YeuThich>();
}
