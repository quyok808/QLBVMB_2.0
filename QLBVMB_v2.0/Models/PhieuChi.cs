namespace QLBVMB_v2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuChi")]
    public partial class PhieuChi
    {
        [Key]
        [StringLength(10)]
        public string MaPhieuChi { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(250)]
        public string LoaiNghiepVu { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
