using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class DiemNoiBat
{
    public int Id { get; set; }

    public int Idve { get; set; }

    public string NoiDung { get; set; } = null!;

    public virtual Ve IdveNavigation { get; set; } = null!;
}
