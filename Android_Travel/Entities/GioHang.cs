using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class GioHang
{
    public int Id { get; set; }

    public int IdnguoiDung { get; set; }

    public int Idve { get; set; }

    public int SoLuongTre { get; set; }

    public int SoLuongNguoiLon { get; set; }

    public virtual NguoiDung IdnguoiDungNavigation { get; set; } = null!;

    public virtual Ve IdveNavigation { get; set; } = null!;
}
