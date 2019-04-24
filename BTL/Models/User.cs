using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    [Table("USER")]
    public partial class User
    {
        public User()
        {
            XuatKho = new HashSet<XuatKho>();
        }

        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(15)]
        public string Password { get; set; }
        [StringLength(50)]
        public string TenKhachHang { get; set; }
        [Column("SDT")]
        [StringLength(13)]
        public string Sdt { get; set; }
        [Column("email")]
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<XuatKho> XuatKho { get; set; }
    }
}