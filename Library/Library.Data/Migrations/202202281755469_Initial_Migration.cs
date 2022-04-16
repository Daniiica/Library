namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Biography = c.String(),
                        Country = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfDeath = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        AuthorID = c.Int(nullable: false),
                        PublishingHouseId = c.Int(nullable: false),
                        LanguageID = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Amount = c.Int(nullable: false),
                        ISBN = c.Int(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.LanguageID, cascadeDelete: true)
                .ForeignKey("dbo.PublishingHouses", t => t.PublishingHouseId, cascadeDelete: true)
                .Index(t => t.AuthorID)
                .Index(t => t.PublishingHouseId)
                .Index(t => t.LanguageID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageID = c.Int(nullable: false, identity: true),
                        Caption = c.String(),
                    })
                .PrimaryKey(t => t.LanguageID);
            
            CreateTable(
                "dbo.PublishingHouses",
                c => new
                    {
                        PublishingHouseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PublishingHouseId);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        RentalsID = c.Int(nullable: false, identity: true),
                        BookID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        RentalDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RentalsID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.BookID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        IndexNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                        InsertDateUtc = c.DateTime(nullable: false),
                        DeleteDateUtc = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Caption = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.GenreBooks",
                c => new
                    {
                        Genre_GenreID = c.Int(nullable: false),
                        Book_BookID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreID, t.Book_BookID })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookID, cascadeDelete: true)
                .Index(t => t.Genre_GenreID)
                .Index(t => t.Book_BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Rentals", "BookID", "dbo.Books");
            DropForeignKey("dbo.Books", "PublishingHouseId", "dbo.PublishingHouses");
            DropForeignKey("dbo.Books", "LanguageID", "dbo.Languages");
            DropForeignKey("dbo.GenreBooks", "Book_BookID", "dbo.Books");
            DropForeignKey("dbo.GenreBooks", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropIndex("dbo.GenreBooks", new[] { "Book_BookID" });
            DropIndex("dbo.GenreBooks", new[] { "Genre_GenreID" });
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.Rentals", new[] { "UserID" });
            DropIndex("dbo.Rentals", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "LanguageID" });
            DropIndex("dbo.Books", new[] { "PublishingHouseId" });
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropTable("dbo.GenreBooks");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Rentals");
            DropTable("dbo.PublishingHouses");
            DropTable("dbo.Languages");
            DropTable("dbo.Genres");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
