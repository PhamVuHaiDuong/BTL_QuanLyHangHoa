namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class create_Table_PhieuXuat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "dbo.PhieuXuat",
              c => new
              {
                  MaPX = c.String(nullable: false, maxLength: 128),
                  MaSP = c.String(nullable: false),
                  SoLuongXuat = c.String(nullable: false, maxLength: 50),
                  DonGia = c.String(nullable: false),
                  ThanhTien = c.String(nullable: false),
                  MaNCC = c.String(nullable: false),
                  NgayTaoPhieu = c.DateTime(nullable: false),
              })
                .PrimaryKey(t => t.MaPX);
        } 


        public override void Down()
        {
            DropTable("dbo.PhieuXuat");
        }
    }
}
