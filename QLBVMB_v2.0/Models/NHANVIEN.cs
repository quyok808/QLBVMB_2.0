namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            Roles = new HashSet<Role>();
        }

        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(250)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(250)]
        public string ChucVu { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        public DateTime NgaySinh { get; set; }

        public int Luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
