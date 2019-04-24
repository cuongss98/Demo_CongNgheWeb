using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class ChiTietXuatKho
    {
        [Column("ChiTietXuatKhoID")]
        public int ChiTietXuatKhoId { get; set; }
        [Column("XuatKhoID")]
        public int? XuatKhoId { get; set; }
        [Column("SanPhamID")]
        public int? SanPhamId { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [ForeignKey("XuatKhoId")]
        [InverseProperty("ChiTietXuatKho")]
        public virtual SanPham XuatKho { get; set; }
        [ForeignKey("XuatKhoId")]
        [InverseProperty("ChiTietXuatKho")]
        public virtual XuatKho XuatKhoNavigation { get; set; }
    }
}