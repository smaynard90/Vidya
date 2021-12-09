namespace Vidya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConsole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consoles",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "ConsoleId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Games", "ConsoleId");
            AddForeignKey("dbo.Games", "ConsoleId", "dbo.Consoles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "ConsoleId", "dbo.Consoles");
            DropIndex("dbo.Games", new[] { "ConsoleId" });
            DropColumn("dbo.Games", "ConsoleId");
            DropTable("dbo.Consoles");
        }
    }
}
