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

        public virtual DbSet<CHUYENBAY> CHUYENBAYs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<Ghe> Ghes { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<MAYBAY> MAYBAYs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SANBAY> SANBAYs { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.MaCB)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.MaSBDi)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .Property(e => e.MaSBDen)
                .IsFixedLength();

            modelBuilder.Entity<CHUYENBAY>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.CHUYENBAY)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaKM)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.TenKH)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CCCD)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaVe)
                .IsFixedLength();

            modelBuilder.Entity<KHUYENMAI>()
                .Property(e => e.MaKM)
                .IsFixedLength();

            modelBuilder.Entity<MAYBAY>()
                .HasMany(e => e.CHUYENBAYs)
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
                .HasMany(e => e.Roles)
                .WithRequired(e => e.NHANVIEN)
                .HasForeignKey(e => e.Username)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsFixedLength();

            modelBuilder.Entity<SANBAY>()
                .Property(e => e.MaSB)
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
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.Ve)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ve>()
                .HasMany(e => e.KHACHHANGs)
                .WithRequired(e => e.Ve)
                .WillCascadeOnDelete(false);
        }
    }
}
