using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class ChiTietNhapKho
    {
        [Column("ChiTietNhapKhoID")]
        public int ChiTietNhapKhoId { get; set; }
        [Column("NhapKhoID")]
        public int? NhapKhoId { get; set; }
        [Column("SanPhamID")]
        public int? SanPhamId { get; set; }
        public int? SoLuong { get; set; }

        [ForeignKey("NhapKhoId")]
        [InverseProperty("ChiTietNhapKho")]
        public virtual NhapKho NhapKho { get; set; }
        [ForeignKey("SanPhamId")]
        [InverseProperty("ChiTietNhapKho")]
        public virtual SanPham SanPham { get; set; }
    }
}