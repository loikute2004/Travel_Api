using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Android_Travel.Entities;

public partial class DbTravelContext : DbContext
{
    public DbTravelContext()
    {
    }

    public DbTravelContext(DbContextOptions<DbTravelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<DanhGium> DanhGia { get; set; }

    public virtual DbSet<DanhMuc> DanhMucs { get; set; }

    public virtual DbSet<DiemNoiBat> DiemNoiBats { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<ThanhPho> ThanhPhos { get; set; }

    public virtual DbSet<ThanhToan> ThanhToans { get; set; }

    public virtual DbSet<ThongBao> ThongBaos { get; set; }

    public virtual DbSet<UuDai> UuDais { get; set; }

    public virtual DbSet<Ve> Ves { get; set; }

    public virtual DbSet<VeUuDai> VeUuDais { get; set; }

    public virtual DbSet<YeuThich> YeuThiches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PC\\SQLEXPRESS;Database=DB_Travel;User ID=sa;Password=loi123;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChiTietH__3214EC270309C675");

            entity.ToTable("ChiTietHoaDon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");
            entity.Property(e => e.Idve).HasColumnName("IDVe");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.IdhoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHo__IDHoa__5CD6CB2B");

            entity.HasOne(d => d.IdveNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.Idve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHoa__IDVe__5BE2A6F2");
        });

        modelBuilder.Entity<DanhGium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DanhGia__3214EC27BF2816D3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnguoiDung).HasColumnName("IDNguoiDung");
            entity.Property(e => e.Idve).HasColumnName("IDVe");

            entity.HasOne(d => d.IdnguoiDungNavigation).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.IdnguoiDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DanhGia__IDNguoi__6A30C649");

            entity.HasOne(d => d.IdveNavigation).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.Idve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DanhGia__IDVe__693CA210");
        });

        modelBuilder.Entity<DanhMuc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DanhMuc__3214EC278AB4D409");

            entity.ToTable("DanhMuc");

            entity.HasIndex(e => e.TenDanhMuc, "UQ__DanhMuc__650CAE4E9C8F84CC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenDanhMuc).HasMaxLength(100);
        });

        modelBuilder.Entity<DiemNoiBat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DiemNoiB__3214EC27E2AF18E0");

            entity.ToTable("DiemNoiBat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idve).HasColumnName("IDVe");

            entity.HasOne(d => d.IdveNavigation).WithMany(p => p.DiemNoiBats)
                .HasForeignKey(d => d.Idve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DiemNoiBat__IDVe__76969D2E");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GioHang__3214EC27D479FBAC");

            entity.ToTable("GioHang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnguoiDung).HasColumnName("IDNguoiDung");
            entity.Property(e => e.Idve).HasColumnName("IDVe");

            entity.HasOne(d => d.IdnguoiDungNavigation).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.IdnguoiDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHang__IDNguoi__4F7CD00D");

            entity.HasOne(d => d.IdveNavigation).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.Idve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHang__IDVe__5070F446");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HoaDon__3214EC273965923E");

            entity.ToTable("HoaDon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnguoiDung).HasColumnName("IDNguoiDung");
            entity.Property(e => e.NgayDat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdnguoiDungNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdnguoiDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__IDNguoiD__5535A963");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NguoiDun__3214EC275D00700C");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.Email, "UQ__NguoiDun__A9D105343E3BD083").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.MatKhau).HasMaxLength(100);
            entity.Property(e => e.Quyen).HasMaxLength(50);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<ThanhPho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ThanhPho__3214EC27CEEC68B7");

            entity.ToTable("ThanhPho");

            entity.HasIndex(e => e.TenThanhPho, "UQ__ThanhPho__D91709701A13A0FC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenThanhPho).HasMaxLength(100);
        });

        modelBuilder.Entity<ThanhToan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ThanhToa__3214EC27824029FB");

            entity.ToTable("ThanhToan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HinhThuc).HasMaxLength(50);
            entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NgayThanhToan).HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.ThanhToans)
                .HasForeignKey(d => d.IdhoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ThanhToan__IDHoa__6383C8BA");
        });

        modelBuilder.Entity<ThongBao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ThongBao__3214EC272B40672B");

            entity.ToTable("ThongBao");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnguoiDung).HasColumnName("IDNguoiDung");
            entity.Property(e => e.ThoiGian)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TieuDe).HasMaxLength(200);
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdnguoiDungNavigation).WithMany(p => p.ThongBaos)
                .HasForeignKey(d => d.IdnguoiDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ThongBao__IDNguo__49C3F6B7");
        });

        modelBuilder.Entity<UuDai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UuDai__3214EC27EE6F0719");

            entity.ToTable("UuDai");

            entity.HasIndex(e => e.TenUuDai, "UQ__UuDai__BCE55A15233FDC9E").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenUuDai).HasMaxLength(100);
        });

        modelBuilder.Entity<Ve>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ve__3214EC278E7B5F18");

            entity.ToTable("Ve");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IddanhMuc).HasColumnName("IDDanhMuc");
            entity.Property(e => e.IdthanhPho).HasColumnName("IDThanhPho");
            entity.Property(e => e.TenVe).HasMaxLength(100);

            entity.HasOne(d => d.IddanhMucNavigation).WithMany(p => p.Ves)
                .HasForeignKey(d => d.IddanhMuc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__IDDanhMuc__4316F928");

            entity.HasOne(d => d.IdthanhPhoNavigation).WithMany(p => p.Ves)
                .HasForeignKey(d => d.IdthanhPho)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__IDThanhPho__45F365D3");
        });

        modelBuilder.Entity<VeUuDai>(entity =>
        {
            entity.HasKey(e => new { e.Idve, e.IduuDai }).HasName("PK__Ve_UuDai__4D8045E71AC06AD3");

            entity.ToTable("Ve_UuDai");

            entity.Property(e => e.Idve).HasColumnName("IDVe");
            entity.Property(e => e.IduuDai).HasColumnName("IDUuDai");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IduuDaiNavigation).WithMany(p => p.VeUuDais)
                .HasForeignKey(d => d.IduuDai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve_UuDai__IDUuDa__72C60C4A");

            entity.HasOne(d => d.IdveNavigation).WithMany(p => p.VeUuDais)
                .HasForeignKey(d => d.Idve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve_UuDai__IDVe__71D1E811");
        });

        modelBuilder.Entity<YeuThich>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__YeuThich__3214EC27D09258F8");

            entity.ToTable("YeuThich");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnguoiDung).HasColumnName("IDNguoiDung");
            entity.Property(e => e.Idve).HasColumnName("IDVe");

            entity.HasOne(d => d.IdnguoiDungNavigation).WithMany(p => p.YeuThiches)
                .HasForeignKey(d => d.IdnguoiDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__YeuThich__IDNguo__7A672E12");

            entity.HasOne(d => d.IdveNavigation).WithMany(p => p.YeuThiches)
                .HasForeignKey(d => d.Idve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__YeuThich__IDVe__797309D9");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
