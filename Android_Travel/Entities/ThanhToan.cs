using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class ThanhToan
{
    public int Id { get; set; }

    public int IdhoaDon { get; set; }

    public string HinhThuc { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public DateTime NgayTao { get; set; }

    public DateTime? NgayThanhToan { get; set; }

    public virtual HoaDon IdhoaDonNavigation { get; set; } = null!;
}
