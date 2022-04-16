using Library.Business;
using Library.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class AddRentalsForm : Form
    {
        private UnitOfWork _unitOfWork;
        Rentals _rental;
        public AddRentalsForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            AddUpdateLabel.Text = "Add rental";
            Initialize_Boxs();
        }
        public AddRentalsForm(Rentals rental)
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            AddUpdateLabel.Text = "Update rental";
            _rental = rental;
            Initialize_Boxs();
            BookComboBox.Text = rental.Book.Name;
            StudentsFirstNameComboBox.Text = rental.User.FirstName;
            StudentsLastNameComboBox.Text = rental.User.LastName;
            StudentsIndexNumberComboBox.Text = rental.User.IndexNumber;
            RentalDatePicker.Text = rental.RentalDate.ToString();
            ReturnDatePicker.Text = rental.ReturnDate.ToString();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            BookValidation.Text = "";
            StudentsFirstNameValidation.Text = "";
            StudentsLastNameValidation.Text = "";
            IndexNumberValidation.Text = "";
            //  ReturnDateValidation.Text = "";
            //  RentalDateValidation.Text = "";

            var book = BookComboBox.Text;
            var studentsFirstName = StudentsFirstNameComboBox.Text;
            var studentsLastName = StudentsLastNameComboBox.Text;
            var studentsIndexNumber = StudentsIndexNumberComboBox.Text;
            var rentalDate = RentalDatePicker.Value;
            var returnDate = ReturnDatePicker.Value;


            if (string.IsNullOrEmpty(book) || string.IsNullOrEmpty(studentsFirstName) || string.IsNullOrEmpty(studentsLastName) || string.IsNullOrEmpty(studentsIndexNumber))
            {
                if (string.IsNullOrEmpty(book))
                {
                    BookValidation.Text = "Book is required";
                }
                if (string.IsNullOrEmpty(studentsFirstName))
                {
                    StudentsFirstNameValidation.Text = "Students First name is required";
                }
                if (string.IsNullOrEmpty(studentsLastName))
                {
                    StudentsLastNameValidation.Text = "Students Last name is required";
                }
                if (string.IsNullOrEmpty(studentsIndexNumber))
                {
                    IndexNumberValidation.Text = "Students Index number is required";
                }
            }
            else
            {
                if (_rental == null) //dodaje se nova knjiga
                {
                    Book bookAdd;
                    bookAdd = _unitOfWork.BookRepository.Get(b => b.Name == book).FirstOrDefault();
                    if (bookAdd == null)
                    {
                        MessageBox.Show("Book doesn't exist!");
                        return;
                    }
                    var rentals_for_book = _unitOfWork.RentalsRepository.Get(r => r.BookID == bookAdd.BookID);
                    if (rentals_for_book.Count() == bookAdd.Amount)
                    {
                        MessageBox.Show("All this books are rented!");
                        return;
                    }
                    User studentAdd;
                    studentAdd = _unitOfWork.UserRepository.Get(u => u.FirstName == studentsFirstName && u.LastName == studentsLastName && u.IndexNumber == studentsIndexNumber).FirstOrDefault();
                    if (studentAdd == null)
                    {
                        MessageBox.Show("Student doesn't exist!");
                        return;
                    }
                    Rentals student_rental = _unitOfWork.RentalsRepository.Get(r => r.UserID == studentAdd.UserID && r.ReturnDate < DateTime.UtcNow).FirstOrDefault();
                    if (student_rental != null)
                    {
                        MessageBox.Show("Student didn't return the book" + " " + student_rental.Book.Name);
                        return;
                    }
                    Rentals rentalAdd = new Rentals();
                    rentalAdd.BookID = bookAdd.BookID;
                    rentalAdd.UserID = studentAdd.UserID;
                    rentalAdd.RentalDate = rentalDate;
                    rentalAdd.ReturnDate = returnDate;
                    _unitOfWork.RentalsRepository.Insert(rentalAdd);
                    _unitOfWork.Save();
                    MessageBox.Show("Rental has added!");
                }

                else
                {
                    Rentals rentalUpdate = _unitOfWork.RentalsRepository.GetByID(_rental.RentalsID);
                    Book bookUpdate = _unitOfWork.BookRepository.Get(b => b.Name == book).FirstOrDefault();
                    if (bookUpdate == null)
                    {
                        MessageBox.Show("Book doesn't exist!");
                        return;
                    }
                    var rentals_for_book = _unitOfWork.RentalsRepository.Get(r => r.BookID == bookUpdate.BookID);
                    if (rentals_for_book.Count() == bookUpdate.Amount)
                    {
                        MessageBox.Show("All this books are rented!");
                        return;
                    }
                    rentalUpdate.BookID = bookUpdate.BookID;
                    User userUpdate = _unitOfWork.UserRepository.Get(u => u.FirstName == studentsFirstName && u.LastName == studentsLastName && u.IndexNumber == studentsIndexNumber).FirstOrDefault();
                    if (userUpdate == null)
                    {
                        MessageBox.Show("Student doesn't exist!");
                        return;
                    }
                    rentalUpdate.UserID = userUpdate.UserID;
                    rentalUpdate.RentalDate = rentalDate;
                    rentalUpdate.ReturnDate = returnDate;
                    _unitOfWork.Save();
                    MessageBox.Show("Rental has updated!");
                }
            }
        }
        private void Initialize_Boxs()
        {
            List<Book> books = new List<Book>();
            books = _unitOfWork.BookRepository.GetAll();
            for (int i = 0; i < books.Count; i++)
            {
                BookComboBox.Items.Add(books.ElementAt(i).Name);
            }
            List<User> users = new List<User>();
            users = _unitOfWork.UserRepository.GetAll();
            for (int i = 0; i < users.Count; i++)
            {
                StudentsFirstNameComboBox.Items.Add(users.ElementAt(i).FirstName);
                StudentsLastNameComboBox.Items.Add(users.ElementAt(i).LastName);
                StudentsIndexNumberComboBox.Items.Add(users.ElementAt(i).IndexNumber);
            }
        }

    }
}
