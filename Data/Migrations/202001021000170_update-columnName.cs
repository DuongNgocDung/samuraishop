namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecolumnName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.slides", "DisplayOrder", c => c.Int());
            DropColumn("dbo.slides", "DisplayPrder");
        }
        
        public override void Down()
        {
            AddColumn("dbo.slides", "DisplayPrder", c => c.Int());
            DropColumn("dbo.slides", "DisplayOrder");
        }
    }
}
