namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANBAY")]
    public partial class SANBAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANBAY()
        {
            CHUYENBAYs = new HashSet<CHUYENBAY>();
            CHUYENBAYs1 = new HashSet<CHUYENBAY>();
        }

        [Key]
        [StringLength(3)]
        public string MaSB { get; set; }

        [Required]
        [StringLength(3)]
        public string IcaoSB { get; set; }

        [StringLength(250)]
        public string TenSB { get; set; }

        [StringLength(10)]
        public string Iatahang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENBAY> CHUYENBAYs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENBAY> CHUYENBAYs1 { get; set; }

        public virtual HANGHANGKHONG HANGHANGKHONG { get; set; }
    }
}
