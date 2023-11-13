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
            HOADONs = new HashSet<HOADON>();
            LICHes = new HashSet<LICH>();
            PhieuChis = new HashSet<PhieuChi>();
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

        [StringLength(50)]
        public string Dantoc { get; set; }

        [StringLength(50)]
        public string QuocTich { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string SoCCCD { get; set; }

        [Required]
        [StringLength(250)]
        public string NoiCap { get; set; }

        public DateTime NgayCap { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        public DateTime? NgayVaoLam { get; set; }

        public DateTime? NgayNghiLam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICH> LICHes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuChi> PhieuChis { get; set; }

        public virtual Role Role { get; set; }
    }
}
