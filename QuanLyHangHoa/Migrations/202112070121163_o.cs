
namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class o : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhieuNhap", "SoLuongNhap", c => c.Int(nullable: false));
            AlterColumn("dbo.PhieuNhap", "DonGia", c => c.Double(nullable: false));
            DropColumn("dbo.PhieuNhap", "ThanhTien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhieuNhap", "ThanhTien", c => c.String());
            AlterColumn("dbo.PhieuNhap", "DonGia", c => c.String());
            AlterColumn("dbo.PhieuNhap", "SoLuongNhap", c => c.String());
        }
    }
}
