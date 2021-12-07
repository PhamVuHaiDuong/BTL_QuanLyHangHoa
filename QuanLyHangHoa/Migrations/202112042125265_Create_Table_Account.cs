namespace QuanLyHangHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Account",
               c => new
               {
                   UserName = c.String(nullable: false, maxLength: 128),
                   PassWord = c.String(nullable: false),
               })
               .PrimaryKey(t => t.UserName);
        }
        
        public override void Down()
        {
            DropTable("dbo.Account");
        }
    }
}
