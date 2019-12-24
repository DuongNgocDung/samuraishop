namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.footers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.menu_groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        URL = c.String(nullable: false, maxLength: 250),
                        DisplayOrder = c.Int(),
                        GroupID = c.Int(nullable: false),
                        Target = c.String(maxLength: 10),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.order_details",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.OrderID });
            
            CreateTable(
                "dbo.orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 250),
                        CustomerAddress = c.String(nullable: false, maxLength: 250),
                        CustomerEmail = c.String(nullable: false, maxLength: 250),
                        CustomerMobile = c.String(nullable: false, maxLength: 20),
                        CustomerMessage = c.String(maxLength: 250),
                        PaymentMethod = c.String(maxLength: 250),
                        PaymentStatus = c.String(nullable: false, maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        Content = c.String(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.post_categories",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 250),
                        HomeFlag = c.Boolean(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(maxLength: 250),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.post_tags",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID });
            
            CreateTable(
                "dbo.product_categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 250),
                        HomeFlag = c.Boolean(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 250, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(maxLength: 250),
                        MoreImages = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Promotion = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.product_tags",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID });
            
            CreateTable(
                "dbo.slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 250),
                        Image = c.String(nullable: false, maxLength: 250),
                        URL = c.String(nullable: false, maxLength: 250),
                        DisplayPrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.support_onlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Department = c.String(maxLength: 50),
                        Skype = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Yahoo = c.String(maxLength: 50),
                        Facebook = c.String(maxLength: 50),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.system_configs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValueString = c.String(maxLength: 50),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.visistor_statistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VisistedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.visistor_statistics");
            DropTable("dbo.tags");
            DropTable("dbo.system_configs");
            DropTable("dbo.support_onlines");
            DropTable("dbo.slides");
            DropTable("dbo.product_tags");
            DropTable("dbo.products");
            DropTable("dbo.product_categories");
            DropTable("dbo.post_tags");
            DropTable("dbo.posts");
            DropTable("dbo.post_categories");
            DropTable("dbo.pages");
            DropTable("dbo.orders");
            DropTable("dbo.order_details");
            DropTable("dbo.menus");
            DropTable("dbo.menu_groups");
            DropTable("dbo.footers");
        }
    }
}
