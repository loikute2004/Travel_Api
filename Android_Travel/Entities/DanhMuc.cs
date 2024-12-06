using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class DanhMuc
{
    public int Id { get; set; }

    public string TenDanhMuc { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
