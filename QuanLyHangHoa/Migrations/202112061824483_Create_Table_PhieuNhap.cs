namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PhieuNhap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuNhap",
                c => new
                {
                    MaPN = c.String(nullable: false, maxLength: 128, unicode: false),
                    MaSP = c.String(),
                    SoLuongNhap = c.String(nullable: false),
                    DonGia = c.String(),
                    ThanhTien = c.String(),
                    MaNCC = c.String(),
                    NgayTaoPhieu = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.MaPN);
        }
        
        public override void Down()
        {
            DropTable("dbo.PhieuNhap");
        }
    }
}
