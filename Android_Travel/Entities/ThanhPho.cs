using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class ThanhPho
{
    public int Id { get; set; }

    public string TenThanhPho { get; set; } = null!;

    public string? HinhAnh { get; set; }

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
