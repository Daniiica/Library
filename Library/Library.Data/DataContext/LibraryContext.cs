using System.Data.Entity;
using Library.Data.Domain;

namespace Library.Data.DataContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LibraryContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<LibraryContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<Raiting> Raitings { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<WishBook> WishBooks { get; set; }
        public DbSet<Reservations> ReservationBooks { get; set; }
    }
}