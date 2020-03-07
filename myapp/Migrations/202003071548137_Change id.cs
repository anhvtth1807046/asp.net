namespace myapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changeid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Students", "Id");
        }
    }
}
