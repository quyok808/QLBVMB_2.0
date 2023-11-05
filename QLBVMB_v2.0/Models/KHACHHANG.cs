namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [Key]
        public int MaKH { get; set; }

        [StringLength(10)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(10)]
        public string CCCD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaVe { get; set; }

        public virtual Ve Ve { get; set; }
    }
}
