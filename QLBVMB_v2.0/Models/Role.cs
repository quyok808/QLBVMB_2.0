namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role
    {
        public int RoleID { get; set; }

        [Required]
        [StringLength(10)]
        public string Username { get; set; }

        [Required]
        [StringLength(13)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
