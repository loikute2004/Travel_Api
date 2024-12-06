using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class DanhGium
{
    public int Id { get; set; }

    public int Idve { get; set; }

    public int IdnguoiDung { get; set; }

    public double Rating { get; set; }

    public string? BinhLuan { get; set; }

    public virtual NguoiDung IdnguoiDungNavigation { get; set; } = null!;

    public virtual Ve IdveNavigation { get; set; } = null!;
}
