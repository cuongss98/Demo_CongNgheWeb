using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class XuatKho
    {
        public XuatKho()
        {
            ChiTietXuatKho = new HashSet<ChiTietXuatKho>();
        }

        [Column("XuatKhoID")]
        public int XuatKhoId { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayXuat { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("XuatKho")]
        public virtual User User { get; set; }
        [InverseProperty("XuatKhoNavigation")]
        public virtual ICollection<ChiTietXuatKho> ChiTietXuatKho { get; set; }
    }
}