namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAYBAY")]
    public partial class MAYBAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAYBAY()
        {
            CHUYENBAYs = new HashSet<CHUYENBAY>();
            CT_MAYBAY_HANGHANGKHONG = new HashSet<CT_MAYBAY_HANGHANGKHONG>();
        }

        [Key]
        [StringLength(50)]
        public string MaMB { get; set; }

        [StringLength(50)]
        public string LoaiMB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENBAY> CHUYENBAYs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MAYBAY_HANGHANGKHONG> CT_MAYBAY_HANGHANGKHONG { get; set; }
    }
}
