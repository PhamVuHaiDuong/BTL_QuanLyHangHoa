using System.Data.Entity;
using QuanLyHangHoa.Models;

namespace QuanLyHangHoa.Models
{
    public partial class QLHHDbcontext : DbContext
    {
        public QLHHDbcontext() : base("name=QLHHDbcontext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet <PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet <NhaCungCap> NhaCungCaps { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
          .Property(e => e.Username)
          .IsUnicode(false);
            modelBuilder.Entity<NhanVien>()
       .Property(e => e.MaNV)
       .IsUnicode(false);
            modelBuilder.Entity<KhoHang>()
      .Property(e => e.MaSP)
      .IsUnicode(false);
            modelBuilder.Entity<PhieuNhap>()
      .Property(e => e.MaPN)
      .IsUnicode(false);
            modelBuilder.Entity<PhieuXuat>()
     .Property(e => e.MaPX)
     .IsUnicode(false);
            modelBuilder.Entity<NhaCungCap>()
   .Property(e => e.MaNCC)
   .IsUnicode(false);
        }
    }
}