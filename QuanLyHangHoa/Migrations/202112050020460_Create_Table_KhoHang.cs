namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhoHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhoHang",
                c => new
                    {
                        MaSP = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenSP = c.String(),
                        SoLuong = c.String(),
                        DonGia = c.String(),
                        PhanLoai = c.String(),
                    })
                .PrimaryKey(t => t.MaSP);
           
        }
        
        public override void Down()
        {
            DropTable("dbo.KhoHang");
        }
    }
}
