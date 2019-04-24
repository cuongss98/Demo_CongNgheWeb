using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    [Table("ADMIN")]
    public partial class Admin
    {
        [Key]
        [StringLength(10)]
        public string TenDangNhap { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [Column("RoleID")]
        public int? RoleId { get; set; }
    }
}