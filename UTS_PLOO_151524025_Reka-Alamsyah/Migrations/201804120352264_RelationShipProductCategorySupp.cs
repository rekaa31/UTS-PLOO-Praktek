namespace UTS_PLOO_151524025_Reka_Alamsyah.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipProductCategorySupp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.category",
                c => new
                    {
                        category_id = c.Int(nullable: false),
                        category_name = c.String(maxLength: 100),
                        category_description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.category_id);
            
            CreateTable(
                "dbo.product",
                c => new
                    {
                        product_id = c.Int(nullable: false),
                        product_name = c.String(maxLength: 100),
                        category_id = c.Int(nullable: false),
                        supplier_id = c.Int(nullable: false),
                        product_price = c.Int(nullable: false),
                        minimum_stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.product_id)
                .ForeignKey("dbo.category", t => t.category_id, cascadeDelete: true)
                .ForeignKey("dbo.supplier", t => t.supplier_id, cascadeDelete: true)
                .Index(t => t.category_id)
                .Index(t => t.supplier_id);
            
            CreateTable(
                "dbo.supplier",
                c => new
                    {
                        supplier_id = c.Int(nullable: false),
                        supplier_name = c.String(maxLength: 100),
                        address = c.String(maxLength: 100),
                        phone = c.String(maxLength: 100),
                        supplier_description = c.String(maxLength: 100),
                        Supplier_supplier_id = c.Int(),
                    })
                .PrimaryKey(t => t.supplier_id)
                .ForeignKey("dbo.supplier", t => t.Supplier_supplier_id)
                .Index(t => t.Supplier_supplier_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.product", "supplier_id", "dbo.supplier");
            DropForeignKey("dbo.supplier", "Supplier_supplier_id", "dbo.supplier");
            DropForeignKey("dbo.product", "category_id", "dbo.category");
            DropIndex("dbo.supplier", new[] { "Supplier_supplier_id" });
            DropIndex("dbo.product", new[] { "supplier_id" });
            DropIndex("dbo.product", new[] { "category_id" });
            DropTable("dbo.supplier");
            DropTable("dbo.product");
            DropTable("dbo.category");
        }
    }
}
