namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_columns_Top_New_Color : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Top");
            DropColumn("dbo.Products", "New");
            DropColumn("dbo.Products", "Color");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Color", c => c.String());
            AddColumn("dbo.Products", "New", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Top", c => c.Boolean(nullable: false));
        }
    }
}
