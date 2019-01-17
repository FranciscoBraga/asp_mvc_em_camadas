namespace Repository_Mvc_DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_Products : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "Product");
            AddColumn("dbo.Product", "PathImage", c => c.String());
            AlterColumn("dbo.Product", "Name", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Name", c => c.String());
            DropColumn("dbo.Product", "PathImage");
            RenameTable(name: "dbo.Product", newName: "Products");
        }
    }
}
