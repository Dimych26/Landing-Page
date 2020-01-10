namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deletesomecolumns : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Products", "Count");
            //DropColumn("dbo.Products", "Size");
            //DropColumn("dbo.Products", "Gender");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Products", "Gender", c => c.String());
            //AddColumn("dbo.Products", "Size", c => c.String());
            //AddColumn("dbo.Products", "Count", c => c.Int(nullable: false));
        }
    }
}
