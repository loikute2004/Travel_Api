using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class HoaDon
{
    public int Id { get; set; }

    public int IdnguoiDung { get; set; }

    public DateTime NgayDat { get; set; }

    public int SoLuong { get; set; }

    public double TongTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual NguoiDung IdnguoiDungNavigation { get; set; } = null!;

    public virtual ICollection<ThanhToan> ThanhToans { get; set; } = new List<ThanhToan>();
}
