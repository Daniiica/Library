using Library.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Domain;

namespace Library.Business
{
    public class UnitOfWork : IDisposable
    {
        private LibraryContext context = new LibraryContext();
        private GenericRepository<User> usersRepository;
        private GenericRepository<Book> booksRepository;
        private GenericRepository<Author> authorRepository;
        private GenericRepository<PublishingHouse> publishingHouseRepository;
        private GenericRepository<Genre> genreRepository;
        private GenericRepository<Language> languageRepository;
        private GenericRepository<Raiting> raitingsRepository;
        private GenericRepository<Rentals> rentalsRepository;
        private GenericRepository<Role> roleRepository;
        private GenericRepository<WishBook> wishBookRepository;
        private GenericRepository<Reservations> reservationBookRepository;
        public GenericRepository<User> UserRepository
        {
            get
            {

                if (this.usersRepository == null)
                {
                    this.usersRepository = new GenericRepository<User>(context);
                }
                return usersRepository;
            }
        }
        public GenericRepository<Book> BookRepository
        {
            get
            {

                if (this.booksRepository == null)
                {
                    this.booksRepository = new GenericRepository<Book>(context);
                }
                return booksRepository;
            }
        }
        public GenericRepository<Author> AuthorRepository
        {
            get
            {

                if (this.authorRepository == null)
                {
                    this.authorRepository = new GenericRepository<Author>(context);
                }
                return authorRepository;
            }
        }
        public GenericRepository<PublishingHouse> PublishingHouseRepository
        {
            get
            {

                if (this.publishingHouseRepository == null)
                {
                    this.publishingHouseRepository = new GenericRepository<PublishingHouse>(context);
                }
                return publishingHouseRepository;
            }
        }
        public GenericRepository<Genre> GenreRepository
        {
            get
            {

                if (this.genreRepository == null)
                {
                    this.genreRepository = new GenericRepository<Genre>(context);
                }
                return genreRepository;
            }
        }
        public GenericRepository<Language> LanguageRepository
        {
            get
            {

                if (this.languageRepository == null)
                {
                    this.languageRepository = new GenericRepository<Language>(context);
                }
                return languageRepository;
            }
        }
        public GenericRepository<Raiting> RaitingsRepository
        {
            get
            {

                if (this.raitingsRepository == null)
                {
                    this.raitingsRepository = new GenericRepository<Raiting>(context);
                }
                return raitingsRepository;
            }
        }
        public GenericRepository<Rentals> RentalsRepository
        {
            get
            {

                if (this.rentalsRepository == null)
                {
                    this.rentalsRepository = new GenericRepository<Rentals>(context);
                }
                return rentalsRepository;
            }
        }
        public GenericRepository<Role> RoleRepository
        {
            get
            {

                if (this.roleRepository == null)
                {
                    this.roleRepository = new GenericRepository<Role>(context);
                }
                return roleRepository;
            }
        }
        public GenericRepository<WishBook> WishBookRepository
        {
            get
            {

                if (this.wishBookRepository == null)
                {
                    this.wishBookRepository = new GenericRepository<WishBook>(context);
                }
                return wishBookRepository;
            }
        }
        public GenericRepository<Reservations> ReservationsBookRepository
        {
            get
            {

                if (this.reservationBookRepository == null)
                {
                    this.reservationBookRepository = new GenericRepository<Reservations>(context);
                }
                return reservationBookRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

