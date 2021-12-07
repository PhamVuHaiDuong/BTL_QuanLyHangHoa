namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class e : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhieuXuat", "SoLuongXuat", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhieuXuat", "SoLuongXuat", c => c.Int(nullable: false));
        }
    }
}
