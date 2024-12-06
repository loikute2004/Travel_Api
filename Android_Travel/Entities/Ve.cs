using System;
using System.Collections.Generic;

namespace Android_Travel.Entities;

public partial class Ve
{
    public int Id { get; set; }

    public string TenVe { get; set; } = null!;

    public int IddanhMuc { get; set; }

    public double GiaTre { get; set; }

    public int SoLuong { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public string? MoTa { get; set; }

    public string? HinhAnh { get; set; }

    public int IdthanhPho { get; set; }

    public double? GiaNguoiLon { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual ICollection<DanhGium> DanhGia { get; set; } = new List<DanhGium>();

    public virtual ICollection<DiemNoiBat> DiemNoiBats { get; set; } = new List<DiemNoiBat>();

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();

    public virtual DanhMuc IddanhMucNavigation { get; set; } = null!;

    public virtual ThanhPho IdthanhPhoNavigation { get; set; } = null!;

    public virtual ICollection<VeUuDai> VeUuDais { get; set; } = new List<VeUuDai>();

    public virtual ICollection<YeuThich> YeuThiches { get; set; } = new List<YeuThich>();
}
