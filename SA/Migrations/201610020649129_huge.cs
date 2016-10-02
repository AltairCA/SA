namespace SA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class huge : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        itemName = c.String(),
                        price = c.Single(nullable: false),
                        Category_id = c.Int(),
                        Order_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.Category_id)
                .ForeignKey("dbo.Orders", t => t.Order_id)
                .Index(t => t.Category_id)
                .Index(t => t.Order_id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        states = c.Int(nullable: false),
                        user_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.user_id)
                .Index(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "user_id", "dbo.Users");
            DropForeignKey("dbo.FoodItems", "Order_id", "dbo.Orders");
            DropForeignKey("dbo.FoodItems", "Category_id", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "user_id" });
            DropIndex("dbo.FoodItems", new[] { "Order_id" });
            DropIndex("dbo.FoodItems", new[] { "Category_id" });
            DropTable("dbo.Orders");
            DropTable("dbo.FoodItems");
            DropTable("dbo.Categories");
        }
    }
}
