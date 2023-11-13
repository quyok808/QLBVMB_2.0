namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICH")]
    public partial class LICH
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime Ngay { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string catruc { get; set; }

        [StringLength(50)]
        public string thoigian { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
