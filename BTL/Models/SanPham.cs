using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietNhapKho = new HashSet<ChiTietNhapKho>();
            ChiTietXuatKho = new HashSet<ChiTietXuatKho>();
        }

        [Column("SanPhamID")]
        public int SanPhamId { get; set; }
        [Column("DanhMucID")]
        public int? DanhMucId { get; set; }
        [Column("KhuyenMaiID")]
        public int? KhuyenMaiId { get; set; }
        [StringLength(50)]
        public string TenSanPham { get; set; }
        [StringLength(30)]
        public string HinhAnh { get; set; }
        [Column(TypeName = "money")]
        public decimal? Giá { get; set; }
        [StringLength(100)]
        public string Model { get; set; }
        [Column("CPU")]
        [StringLength(50)]
        public string Cpu { get; set; }
        [Column("CPUSpeed")]
        [StringLength(50)]
        public string Cpuspeed { get; set; }
        [Column("HDisk")]
        [StringLength(50)]
        public string Hdisk { get; set; }
        [StringLength(50)]
        public string KickThuocMan { get; set; }
        [StringLength(50)]
        public string DoPhanGiai { get; set; }
        public double? TrongLuong { get; set; }
        [StringLength(50)]
        public string Ram { get; set; }

        [ForeignKey("DanhMucId")]
        [InverseProperty("SanPham")]
        public virtual DanhMuc DanhMuc { get; set; }
        [ForeignKey("KhuyenMaiId")]
        [InverseProperty("SanPham")]
        public virtual KhuyenMai KhuyenMai { get; set; }
        [InverseProperty("SanPham")]
        public virtual ICollection<ChiTietNhapKho> ChiTietNhapKho { get; set; }
        [InverseProperty("XuatKho")]
        public virtual ICollection<ChiTietXuatKho> ChiTietXuatKho { get; set; }
    }
}