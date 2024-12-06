using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class UuDai
{
    public int Id { get; set; }

    public string TenUuDai { get; set; } = null!;

    public double GiamGia { get; set; }

    public string? MoTa { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public virtual ICollection<VeUuDai> VeUuDais { get; set; } = new List<VeUuDai>();
}
