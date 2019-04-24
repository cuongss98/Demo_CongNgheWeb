using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BTL.Models
{
    public partial class CongnghewebContext : DbContext
    {
        public CongnghewebContext()
        {
        }

        public CongnghewebContext(DbContextOptions<CongnghewebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<ChiTietNhapKho> ChiTietNhapKho { get; set; }
        public virtual DbSet<ChiTietXuatKho> ChiTietXuatKho { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<NhapKho> NhapKho { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<XuatKho> XuatKho { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EG1LFD7\\SQLEXPRESS;Initial Catalog=CongNgheWeb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.TenDangNhap).ValueGeneratedNever();
            });

           

            modelBuilder.Entity<ChiTietNhapKho>(entity =>
            {
                entity.Property(e => e.ChiTietNhapKhoId).ValueGeneratedNever();

                entity.HasOne(d => d.NhapKho)
                    .WithMany(p => p.ChiTietNhapKho)
                    .HasForeignKey(d => d.NhapKhoId)
                    .HasConstraintName("FK_ChiTietNhapKho_NhapKho");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.ChiTietNhapKho)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_ChiTietNhapKho_SanPham");
            });

            modelBuilder.Entity<ChiTietXuatKho>(entity =>
            {
                entity.Property(e => e.ChiTietXuatKhoId).ValueGeneratedNever();

                entity.HasOne(d => d.XuatKho)
                    .WithMany(p => p.ChiTietXuatKho)
                    .HasForeignKey(d => d.XuatKhoId)
                    .HasConstraintName("FK_ChiTietXuatKho_SanPham");

                entity.HasOne(d => d.XuatKhoNavigation)
                    .WithMany(p => p.ChiTietXuatKho)
                    .HasForeignKey(d => d.XuatKhoId)
                    .HasConstraintName("FK_ChiTietXuatKho_XuatKho");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.Property(e => e.DanhMucId).ValueGeneratedNever();
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.Property(e => e.KhuyenMaiId).ValueGeneratedNever();
            });

            modelBuilder.Entity<NhapKho>(entity =>
            {
                entity.Property(e => e.NhapKhoId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.SanPhamId).ValueGeneratedNever();

                entity.HasOne(d => d.DanhMuc)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.DanhMucId)
                    .HasConstraintName("FK_SanPham_DanhMuc");

                entity.HasOne(d => d.KhuyenMai)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.KhuyenMaiId)
                    .HasConstraintName("FK_SanPham_KhuyenMai");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();
            });

            modelBuilder.Entity<XuatKho>(entity =>
            {
                entity.Property(e => e.XuatKhoId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.XuatKho)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_XuatKho_USER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}