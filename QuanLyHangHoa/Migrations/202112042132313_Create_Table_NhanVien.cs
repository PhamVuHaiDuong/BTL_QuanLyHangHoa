namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "dbo.NhanVien",
              c => new
              {
                  MaNV = c.String(nullable: false, maxLength: 128),
                  Username = c.String(nullable: false),
                  HoTen = c.String(nullable: false, maxLength: 50),
                  NgaySinh = c.DateTime(nullable: false),
                  DiaChi = c.String (nullable: false),
                  CCCD = c.String (nullable: false),
                  SĐT = c.Int (nullable:false),
                  ChucVu = c.Int (nullable:false),
              })
              .PrimaryKey(t => t.MaNV);
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanVien");
        }
    }
}
