using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class ChiTietHoaDon
{
    public int Id { get; set; }

    public int Idve { get; set; }

    public int IdhoaDon { get; set; }

    public double GiaTre { get; set; }

    public int SoLuongTre { get; set; }

    public int SoLuongNguoiLon { get; set; }

    public double GiaNguoiLon { get; set; }

    public virtual HoaDon IdhoaDonNavigation { get; set; } = null!;

    public virtual Ve IdveNavigation { get; set; } = null!;
}
