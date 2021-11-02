namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoa",
                c => new
                    {
                        MaHH = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenHH = c.String(),
                    })
                .PrimaryKey(t => t.MaHH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoa");
        }
    }
}
