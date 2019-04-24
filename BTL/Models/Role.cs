using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    public partial class Role
    {
        [Column("RoleID")]
        public int RoleId { get; set; }
        [StringLength(100)]
        public string TenQuyen { get; set; }
    }
}