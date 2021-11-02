using System.Data.Entity;
using QuanLyHangHoa.Models;

namespace QuanLyHangHoa.Models
{
    public partial class QLHHDbcontext : DbContext
    {
        public QLHHDbcontext() : base("name=QLHHDbcontext")
        {
        }
       
        public virtual DbSet<HangHoa> Hanghoas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
            .Property(e => e.MaHH)
            .IsUnicode(false);
        }
    }
}