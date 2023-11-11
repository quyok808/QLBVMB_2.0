namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChucVuLogin")]
    public partial class ChucVuLogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChucVuLogin()
        {
            Roles = new HashSet<Role>();
        }

        [Key]
        [StringLength(10)]
        public string MaChucVu { get; set; }

        [StringLength(250)]
        public string LoaiChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
