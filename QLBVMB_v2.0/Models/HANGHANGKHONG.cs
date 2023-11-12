namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHANGKHONG")]
    public partial class HANGHANGKHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGHANGKHONG()
        {
            CHUYENBAYs = new HashSet<CHUYENBAY>();
            CT_MAYBAY_HANGHANGKHONG = new HashSet<CT_MAYBAY_HANGHANGKHONG>();
        }

        [Key]
        [StringLength(10)]
        public string Iatahang { get; set; }

        [StringLength(10)]
        public string Icaohang { get; set; }

        [StringLength(250)]
        public string TenHang { get; set; }

        public DateTime? NgayHoatDong { get; set; }

        public int? SoMayBay { get; set; }

        [StringLength(250)]
        public string TruSoChinh { get; set; }

        public int? SoDiemDen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENBAY> CHUYENBAYs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MAYBAY_HANGHANGKHONG> CT_MAYBAY_HANGHANGKHONG { get; set; }
    }
}
