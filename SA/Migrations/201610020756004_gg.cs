namespace SA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gg : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodItems", "Order_id", "dbo.Orders");
            DropIndex("dbo.FoodItems", new[] { "Order_id" });
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        qty = c.Int(nullable: false),
                        foodItem_id = c.Int(),
                        Order_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.FoodItems", t => t.foodItem_id)
                .ForeignKey("dbo.Orders", t => t.Order_id)
                .Index(t => t.foodItem_id)
                .Index(t => t.Order_id);
            
            DropColumn("dbo.FoodItems", "Order_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodItems", "Order_id", c => c.Int());
            DropForeignKey("dbo.OrderItems", "Order_id", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "foodItem_id", "dbo.FoodItems");
            DropIndex("dbo.OrderItems", new[] { "Order_id" });
            DropIndex("dbo.OrderItems", new[] { "foodItem_id" });
            DropTable("dbo.OrderItems");
            CreateIndex("dbo.FoodItems", "Order_id");
            AddForeignKey("dbo.FoodItems", "Order_id", "dbo.Orders", "id");
        }
    }
}
