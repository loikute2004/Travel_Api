using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class ThongBao
{
    public int Id { get; set; }

    public int IdnguoiDung { get; set; }

    public string TieuDe { get; set; } = null!;

    public string NoiDung { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public DateTime ThoiGian { get; set; }

    public virtual NguoiDung IdnguoiDungNavigation { get; set; } = null!;
}
