using Library.Business;
using Library.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presentation.Bussiness
{
    public class Authors
    {
        
        public static List<Author> AllAuthors()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var authors = _unitOfWork.AuthorRepository.Get(a => a.DeleteDate == null).ToList();
            return authors;
        }
        public static void DeleteAuthor(int authorID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var author = GetAuthorById(authorID);
            _unitOfWork.AuthorRepository.Delete(author);
            _unitOfWork.Save();
        }
        public static Author GetAuthorById(int authorID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var author = _unitOfWork.AuthorRepository.GetByID(authorID);
            return author;
        }
        public static void UpdateAuthor(int authorID, string name, string country, string biography, DateTime dateOfBirth, DateTime dateOfDeath)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var author = GetAuthorById(authorID);
            author.Name = name;
            author.Country = country;
            author.Biography = biography;
            author.DateOfBirth = dateOfBirth;
            author.DateOfDeath = dateOfDeath;
            _unitOfWork.AuthorRepository.Update(author);
            _unitOfWork.Save();
        }
        public static void AddAuthor(string name, string country, string biography, DateTime dateOfBirth, DateTime dateOfDeath)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            Author author = new Author{
                Name = name,
                Country = country,
                Biography = biography,
                DateOfBirth = dateOfBirth,
                DateOfDeath = dateOfDeath,
                DeleteDate = null
            };
            _unitOfWork.AuthorRepository.Insert(author);
            _unitOfWork.Save();
        }
        public static int GetAuthorIDByName(string authorName)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var author = _unitOfWork.AuthorRepository.Get(a => a.Name == authorName).FirstOrDefault();
            return author.AuthorID;
        }
    }
}
