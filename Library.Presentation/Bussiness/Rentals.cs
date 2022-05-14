using Library.Business;
using Library.Data.Domain;
using Library.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presentation.Bussiness
{
    class Rentals
    {
        public static List<Book> FindRentals(UserModel user)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rentals = _unitOfWork.RentalsRepository.Get(r => r.UserID == user.UserID,
                r => r.OrderBy(i => i.RentalDate));
            List<Book> books = new List<Book>();
            for (int i = 0; i < rentals.Count(); i++)
            {
                var ren = rentals.ElementAt(i);
                var book = _unitOfWork.BookRepository.Get(b => b.BookID == ren.BookID).FirstOrDefault();
                books.Add(book);
            }
            return books;
        }
    }
}
