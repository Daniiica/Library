namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationsID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationsID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.BookID);
            
            AddColumn("dbo.WishBooks", "Author", c => c.String());
            AlterColumn("dbo.WishBooks", "ApproveDate", c => c.DateTime());
            AlterColumn("dbo.WishBooks", "DeleteDate", c => c.DateTime());
            DropColumn("dbo.WishBooks", "BookID");
            DropColumn("dbo.WishBooks", "AuthorID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WishBooks", "AuthorID", c => c.String());
            AddColumn("dbo.WishBooks", "BookID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Reservations", "UserID", "dbo.Users");
            DropForeignKey("dbo.Reservations", "BookID", "dbo.Books");
            DropIndex("dbo.Reservations", new[] { "BookID" });
            DropIndex("dbo.Reservations", new[] { "UserID" });
            AlterColumn("dbo.WishBooks", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WishBooks", "ApproveDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.WishBooks", "Author");
            DropTable("dbo.Reservations");
        }
    }
}
