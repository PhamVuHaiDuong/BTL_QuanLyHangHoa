namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_NhaCungCap1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNCC = c.String(),
                        Diachi = c.String(),
                        SĐT = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            AlterColumn("dbo.KhoHang", "SoLuong", c => c.Int(nullable: false));
            AlterColumn("dbo.PhieuNhap", "SoLuongNhap", c => c.Int(nullable: false));
            AlterColumn("dbo.PhieuXuat", "SoLuongXuat", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhieuXuat", "SoLuongXuat", c => c.String());
            AlterColumn("dbo.PhieuNhap", "SoLuongNhap", c => c.String());
            AlterColumn("dbo.KhoHang", "SoLuong", c => c.String());
            DropTable("dbo.NhaCungCap");
        }
    }
}
