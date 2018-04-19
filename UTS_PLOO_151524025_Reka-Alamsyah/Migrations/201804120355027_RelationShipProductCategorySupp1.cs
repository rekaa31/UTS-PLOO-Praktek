namespace UTS_PLOO_151524025_Reka_Alamsyah.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipProductCategorySupp1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.supplier", "Supplier_supplier_id", "dbo.supplier");
            DropIndex("dbo.supplier", new[] { "Supplier_supplier_id" });
            DropColumn("dbo.supplier", "Supplier_supplier_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.supplier", "Supplier_supplier_id", c => c.Int());
            CreateIndex("dbo.supplier", "Supplier_supplier_id");
            AddForeignKey("dbo.supplier", "Supplier_supplier_id", "dbo.supplier", "supplier_id");
        }
    }
}
