using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Column("KhuyenMaiID")]
        public int KhuyenMaiId { get; set; }
        [StringLength(50)]
        public string TenKhuyenMai { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TuNgay { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DenNgay { get; set; }

        [InverseProperty("KhuyenMai")]
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}