namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "ReturnDate", c => c.DateTime());
            CreateIndex("dbo.WishBooks", "UserID");
            AddForeignKey("dbo.WishBooks", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WishBooks", "UserID", "dbo.Users");
            DropIndex("dbo.WishBooks", new[] { "UserID" });
            AlterColumn("dbo.Rentals", "ReturnDate", c => c.DateTime(nullable: false));
        }
    }
}
