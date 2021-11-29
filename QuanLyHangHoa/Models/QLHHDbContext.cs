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
        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
            .Property(e => e.MaHH)
            .IsUnicode(false);
            modelBuilder.Entity<Account>()
          .Property(e => e.Username)
          .IsUnicode(false);
        }
    }
}