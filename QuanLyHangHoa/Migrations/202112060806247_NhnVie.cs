namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhnVie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NhanVien", "SĐT", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhanVien", "SĐT", c => c.Int(nullable: false));
        }
    }
}
