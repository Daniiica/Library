namespace Library.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library.Data.DataContext.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library.Data.DataContext.LibraryContext context) // unutar nje dodajem u bazu odmah to su uglavnom enum
        {
            //  This method will be called after migrating to the latest version.
        /*    Domain.Genre genre = new Domain.Genre { Name = "Test1" };
            context.Genres.AddOrUpdate<Domain.Genre>(genre);
            context.Genres.Remove(genre);
            context.Genres.AddOrUpdate<Domain.Genre>(new Domain.Genre { Name = "Test2" });
        */
            var adminRole = new Domain.Role { Caption = "Admin" };
            var operationRole = new Domain.Role { Caption = "Operation" };
            var studentRole = new Domain.Role { Caption = "Student" };
            context.Roles.AddOrUpdate<Domain.Role>(adminRole);
            context.Roles.AddOrUpdate<Domain.Role>(operationRole);
            context.Roles.AddOrUpdate<Domain.Role>(studentRole);
/*
            context.Users.AddOrUpdate<Domain.User>(new Domain.User
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "Test@test.com",
                IndexNumber = "1234",
                Password = "123",
                InsertDateUtc = DateTime.UtcNow,
                Phone = "12345543",
                Role = adminRole
            }) ;
            Domain.Author author = new Domain.Author { Biography = "Test", Country = "Engleska", Name = "Test", DateOfBirth = DateTime.UtcNow, DateOfDeath = DateTime.UtcNow };
            context.Authors.AddOrUpdate<Domain.Author>(author);
*/
            var language = new Domain.Language { Caption = "English" };
            context.Languages.AddOrUpdate<Domain.Language>(language);
            language = new Domain.Language { Caption = "Serbian" };
            context.Languages.AddOrUpdate<Domain.Language>(language);
            /*
            Domain.PublishingHouse ph = new Domain.PublishingHouse { Name = "Test" };
            context.PublishingHouses.AddOrUpdate<Domain.PublishingHouse>(ph);
            List<Domain.Genre> genres = new List<Domain.Genre>();
            genres.Add(genre);

            Domain.Book book = new Domain.Book { Name = "Test", PublishingHouseId = ph.PublishingHouseId, LanguageID = language.LanguageID, ISBN = 123, Amount = 2, Description = "Test", AuthorID = author.AuthorID, Genres = genres ,InsertDate = DateTime.UtcNow};
            context.Books.AddOrUpdate<Domain.Book>(book);
            context.SaveChanges();
       */  
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
