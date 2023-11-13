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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        public int MaKH { get; set; }

        [StringLength(250)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(13)]
        public string SoCCCD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
