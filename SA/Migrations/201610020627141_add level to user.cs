namespace SA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addleveltouser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "level");
        }
    }
}
