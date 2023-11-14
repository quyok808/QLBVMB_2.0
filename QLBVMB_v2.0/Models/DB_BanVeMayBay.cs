using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBVMB_v2._0.Models
{
    public partial class DB_BanVeMayBay : DbContext
    {
        public DB_BanVeMayBay()
            : base("name=DB_BanVeMayBay")
        {
        }

        public virtual DbSet<ChucVuLogin> ChucVuLogins { get; set; }
        public virtual DbSet<CHUYENBAY> CHUYENBAYs { get; set; }
        public virtual DbSet<CT_MAYBAY_HANGHANGKHONG> CT_MAYBAY_HANGHANGKHONG { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<Ghe> Ghes { get; set; }
        public virtual DbSet<HANGHANGKHONG> HANGHANGKHONGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LICH> LICHes { get; set; }
        public virtual DbSet<MAYBAY> MAYBAYs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PhieuChi> PhieuChis { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SANBAY> SANBAYs { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVuLogin>()
                .Property(e => e.MaChucVu)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.MaCB)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.SohieuCB)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.MaSBDi)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.MaSBDen)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.MaMB)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.Iatahang)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.CHUYENBAY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_MAYBAY_HANGHANGKHONG>()
                .Property(e => e.MaMB)
                .IsFixedLength();

            modelBuilder.Entity<CT_MAYBAY_HANGHANGKHONG>()
                .Property(e => e.Iatahang)
                .IsFixedLength();

            modelBuilder.Entity<CT_MAYBAY_HANGHANGKHONG>()
                .Property(e => e.SoLuong)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaVe)
                .IsFixedLength();

            modelBuilder.Entity<Ghe>()
                .Property(e => e.MaGhe)
                .IsFixedLength();

            modelBuilder.Entity<Ghe>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.Ghe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHANGKHONG>()
                .Property(e => e.Iatahang)
                .IsFixedLength();

            modelBuilder.Entity<HANGHANGKHONG>()
                .Property(e => e.Icaohang)
                .IsFixedLength();

            modelBuilder.Entity<HANGHANGKHONG>()
                .HasMany(e => e.CHUYENBAYs)
                .WithRequired(e => e.HANGHANGKHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHANGKHONG>()
                .HasMany(e => e.CT_MAYBAY_HANGHANGKHONG)
                .WithRequired(e => e.HANGHANGKHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaKM)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SoCCCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .Property(e => e.MaKM)
                .IsFixedLength();

            modelBuilder.Entity<LICH>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<MAYBAY>()
                .Property(e => e.MaMB)
                .IsFixedLength();

            modelBuilder.Entity<MAYBAY>()
                .HasMany(e => e.CHUYENBAYs)
                .WithRequired(e => e.MAYBAY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAYBAY>()
                .HasMany(e => e.CT_MAYBAY_HANGHANGKHONG)
                .WithRequired(e => e.MAYBAY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SoCCCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.LICHes)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasOptional(e => e.Role)
                .WithRequired(e => e.NHANVIEN);

            modelBuilder.Entity<PhieuChi>()
                .Property(e => e.MaPhieuChi)
                .IsFixedLength();

            modelBuilder.Entity<PhieuChi>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.machucvu)
                .IsFixedLength();

            modelBuilder.Entity<SANBAY>()
                .Property(e => e.MaSB)
                .IsFixedLength();

            modelBuilder.Entity<SANBAY>()
                .Property(e => e.IcaoSB)
                .IsFixedLength();

            modelBuilder.Entity<SANBAY>()
                .HasMany(e => e.CHUYENBAYs)
                .WithRequired(e => e.SANBAY)
                .HasForeignKey(e => e.MaSBDi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANBAY>()
                .HasMany(e => e.CHUYENBAYs1)
                .WithRequired(e => e.SANBAY1)
                .HasForeignKey(e => e.MaSBDen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaVe)
                .IsFixedLength();

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaGhe)
                .IsFixedLength();

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaCB)
                .IsFixedLength();

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<Ve>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.Ve)
                .WillCascadeOnDelete(false);
        }
    }
}
