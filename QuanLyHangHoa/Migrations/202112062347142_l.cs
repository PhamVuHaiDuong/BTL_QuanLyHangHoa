namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class l : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NhanVien", "CCCD", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhanVien", "CCCD", c => c.Int(nullable: false));
        }
    }
}
