namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ve")]
    public partial class Ve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ve()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaVe { get; set; }

        public int? GiaTien { get; set; }

        public int TrangThai { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGhe { get; set; }

        [Required]
        [StringLength(10)]
        public string MaCB { get; set; }

        [StringLength(12)]
        public string MaKH { get; set; }

        public virtual CHUYENBAY CHUYENBAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual Ghe Ghe { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
