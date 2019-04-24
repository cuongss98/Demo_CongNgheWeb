using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class NhapKho
    {
        public NhapKho()
        {
            ChiTietNhapKho = new HashSet<ChiTietNhapKho>();
        }

        [Column("NhapKhoID")]
        public int NhapKhoId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        [InverseProperty("NhapKho")]
        public virtual ICollection<ChiTietNhapKho> ChiTietNhapKho { get; set; }
    }
}