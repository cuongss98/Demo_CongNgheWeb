using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Column("DanhMucID")]
        public int DanhMucId { get; set; }
        [StringLength(50)]
        public string TenDanhMuc { get; set; }

        [InverseProperty("DanhMuc")]
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}