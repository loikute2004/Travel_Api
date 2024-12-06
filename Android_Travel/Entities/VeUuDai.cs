using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class VeUuDai
{
    public int Idve { get; set; }

    public int IduuDai { get; set; }

    public string? TrangThai { get; set; }

    public virtual UuDai IduuDaiNavigation { get; set; } = null!;

    public virtual Ve IdveNavigation { get; set; } = null!;
}
