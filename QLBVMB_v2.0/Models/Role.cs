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
        [Key]
        [StringLength(10)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [StringLength(10)]
        public string machucvu { get; set; }

        public virtual ChucVuLogin ChucVuLogin { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
