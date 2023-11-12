namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_MAYBAY_HANGHANGKHONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaMB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Iatahang { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        public virtual HANGHANGKHONG HANGHANGKHONG { get; set; }

        public virtual MAYBAY MAYBAY { get; set; }
    }
}
