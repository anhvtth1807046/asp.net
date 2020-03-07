namespace myapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migra1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Money = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
