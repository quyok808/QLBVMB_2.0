namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUYENBAY")]
    public partial class CHUYENBAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUYENBAY()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        [StringLength(10)]
        public string MaCB { get; set; }

        [Required]
        [StringLength(250)]
        public string NoiDi { get; set; }

        [Required]
        [StringLength(250)]
        public string NoiDen { get; set; }

        public DateTime? GioKhoiHanh { get; set; }

        [Required]
        [StringLength(3)]
        public string MaSBDi { get; set; }

        [Required]
        [StringLength(3)]
        public string MaSBDen { get; set; }

        [Required]
        [StringLength(50)]
        public string MaMB { get; set; }

        [Required]
        [StringLength(10)]
        public string Iatahang { get; set; }

        public virtual HANGHANGKHONG HANGHANGKHONG { get; set; }

        public virtual MAYBAY MAYBAY { get; set; }

        public virtual SANBAY SANBAY { get; set; }

        public virtual SANBAY SANBAY1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
