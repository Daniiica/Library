using Library.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.Presentation.Helpers
{
    public class DataGridManager
    {
        public static int SelectRowInDataGrid(Object sender, DataGridViewCellEventArgs e, DataGridView dataGrid)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return 0;
            }
            else
            {
                DataGridViewRow row = dataGrid.Rows[indexRow];
                int selectID = (int)row.Cells[0].Value;
                return selectID;
            }
        }

        public static void InitializeAllStudentsDataGrid(DataGridView userDataGrid)
        {
            userDataGrid.DataSource = Bussiness.Users.AllStudents();
            userDataGrid.Columns["UserID"].Visible = false;
            userDataGrid.Columns["Role"].Visible = false;
            userDataGrid.Columns["FirstName"].HeaderText = "First Name";
            userDataGrid.Columns["LastName"].HeaderText = "Last Name";
            userDataGrid.Columns["IndexNumber"].HeaderText = "Index Number";
        }

        public static void InitializeTopRatingBooksDataGrid(DataGridView topRatingBooksDataGrid)
        {
            topRatingBooksDataGrid.DataSource = Bussiness.Books.TopRaitingBooks();
            topRatingBooksDataGrid.Columns["BookID"].Visible = false;
            topRatingBooksDataGrid.Columns["UserFirstName"].Visible = false;
            topRatingBooksDataGrid.Columns["UserLastName"].Visible = false;
            topRatingBooksDataGrid.Columns["UserIndexNumber"].Visible = false;
            topRatingBooksDataGrid.Columns["RaitingID"].Visible = false;
        }

        public static void InitializeAllEmployedDataGrid(DataGridView employedDataGrid)
        {
            employedDataGrid.DataSource = Bussiness.Users.AllEmployers();
            employedDataGrid.Columns["UserID"].Visible = false;
            employedDataGrid.Columns["Role"].Visible = false;
            employedDataGrid.Columns["IndexNumber"].Visible = false;
            employedDataGrid.Columns["FirstName"].HeaderText = "First Name";
            employedDataGrid.Columns["LastName"].HeaderText = "Last Name";
        }

        public static void InitializeMyReservationDataGrid(DataGridView myReservationDataGrid)
        {
            myReservationDataGrid.DataSource = Bussiness.Reservation.MyReservationList();
            myReservationDataGrid.Columns["ReservationsID"].Visible = false;
            myReservationDataGrid.Columns["BookID"].Visible = false;
            myReservationDataGrid.Columns["UserID"].Visible = false;
            myReservationDataGrid.Columns["DeleteDateReservation"].Visible = false;
            myReservationDataGrid.Columns["FromDate"].HeaderText = "From Date";
            myReservationDataGrid.Columns["ToDate"].HeaderText = "To Date";
            myReservationDataGrid.Columns["BookName"].HeaderText = "Book";
        }
        public static void InitializeMyWishBookDataGrid(DataGridView wishBookDataGrid)
        {
            wishBookDataGrid.DataSource = Bussiness.WishBooks.MyWishList();
            wishBookDataGrid.Columns["UsersFirstName"].Visible = false;//HeaderText = "Users First Name";
            wishBookDataGrid.Columns["UsersLastName"].Visible = false; //HeaderText = "Users Last Name";
            wishBookDataGrid.Columns["UsersIndexNumber"].Visible = false; // HeaderText = "Users Index Number";
            wishBookDataGrid.Columns["DeleteDate"].HeaderText = "Delete Date";
            wishBookDataGrid.Columns["ApproveDate"].HeaderText = "Approve Date";
            wishBookDataGrid.Columns["WishBookID"].Visible = false;
            wishBookDataGrid.Columns["User"].Visible = false;
        }
        public static void InitializeWishBookDataGrid(DataGridView allWishBookDataGrid)
        {
            allWishBookDataGrid.DataSource = Bussiness.WishBooks.AllWishBook();
            allWishBookDataGrid.Columns["UsersFirstName"].HeaderText = "Users First Name";
            allWishBookDataGrid.Columns["UsersLastName"].HeaderText = "Users Last Name";
            allWishBookDataGrid.Columns["UsersIndexNumber"].HeaderText = "Users Index Number";
            allWishBookDataGrid.Columns["DeleteDate"].HeaderText = "Delete Date";
            allWishBookDataGrid.Columns["ApproveDate"].HeaderText = "Approve Date";
            allWishBookDataGrid.Columns["WishBookID"].Visible = false;
            allWishBookDataGrid.Columns["User"].Visible = false;
        }
        public static void InitializeAllBookDataGrid(DataGridView BookDataGrid)
        {
            BookDataGrid.DataSource = Bussiness.Books.GetAllBooks();
            BookDataGrid.Columns["BookID"].Visible = false;
            BookDataGrid.Columns["AuthorID"].Visible = false;
            BookDataGrid.Columns["LanguageID"].Visible = false;
            BookDataGrid.Columns["PublisherID"].Visible = false;
        }
        public static void InitializeMyRentalsDataGrid(DataGridView myRentalsDataGrid)
        {
            myRentalsDataGrid.DataSource = Bussiness.Rentals.MyRentals();
            myRentalsDataGrid.Columns["BookID"].Visible = false;
            myRentalsDataGrid.Columns["User"].Visible = false;
            myRentalsDataGrid.Columns["RentalsID"].Visible = false;
            myRentalsDataGrid.Columns["UserFirstName"].Visible = false;
            myRentalsDataGrid.Columns["UserLastName"].Visible = false;
            myRentalsDataGrid.Columns["UserIndexNumber"].Visible = false;
            myRentalsDataGrid.Columns["RentalDate"].HeaderText = "Rental Date";
            myRentalsDataGrid.Columns["ReturnDate"].HeaderText = "Return Date";
        }

        public static void InitializeOnlyMyActiveRentalsDataGrid(DataGridView myRentalsDataGrid)
        {
            var rentals = Bussiness.Rentals.OnlyActiveRentals();
            foreach(var item in rentals)
            {
                if(item.User.UserID != Program.Current.User.UserID)
                {
                    rentals.Remove(item);
                }
            }
            myRentalsDataGrid.DataSource = rentals;
            myRentalsDataGrid.Columns["BookID"].Visible = false;
            myRentalsDataGrid.Columns["User"].Visible = false;
            myRentalsDataGrid.Columns["RentalsID"].Visible = false;
            myRentalsDataGrid.Columns["UserFirstName"].Visible = false;
            myRentalsDataGrid.Columns["UserLastName"].Visible = false;
            myRentalsDataGrid.Columns["UserIndexNumber"].Visible = false;
            myRentalsDataGrid.Columns["RentalDate"].HeaderText = "Rental Date";
            myRentalsDataGrid.Columns["ReturnDate"].HeaderText = "Return Date";
        }

        public static void InitializeAllRentalsDataGrid(DataGridView rentalsDataGrid)
        {
            rentalsDataGrid.DataSource = Bussiness.Rentals.AllRentals();
            rentalsDataGrid.Columns["BookID"].Visible = false;
            rentalsDataGrid.Columns["User"].Visible = false;
            rentalsDataGrid.Columns["RentalsID"].Visible = false;
            rentalsDataGrid.Columns["UserFirstName"].HeaderText = "Users First Name";
            rentalsDataGrid.Columns["UserLastName"].HeaderText = "Users Last Name";
            rentalsDataGrid.Columns["UserIndexNumber"].HeaderText = "Users Index Number";
            rentalsDataGrid.Columns["RentalDate"].HeaderText = "Rental Date";
            rentalsDataGrid.Columns["ReturnDate"].HeaderText = "Return Date";
        }
        public static void InitializeSearchBookDataGrid(DataGridView searchBookDataGrid, List<BookModel> searchBooks)
        {
            searchBookDataGrid.DataSource = searchBooks;
            searchBookDataGrid.Columns["BookID"].Visible = false;
            searchBookDataGrid.Columns["AuthorID"].Visible = false;
            searchBookDataGrid.Columns["PublisherID"].Visible = false;
            searchBookDataGrid.Columns["LanguageID"].Visible = false;
        }
        public static void InitializeSearchRentalsDataGrid(DataGridView searchRentalsDataGrid, List<RentalsModel> searchRentals)
        {
            searchRentalsDataGrid.DataSource = searchRentals;
            searchRentalsDataGrid.Columns["BookID"].Visible = false;
            searchRentalsDataGrid.Columns["User"].Visible = false;
            searchRentalsDataGrid.Columns["RentalsID"].Visible = false;
            searchRentalsDataGrid.Columns["UserFirstName"].HeaderText = "Users First Name";
            searchRentalsDataGrid.Columns["UserLastName"].HeaderText = "Users Last Name";
            searchRentalsDataGrid.Columns["UserIndexNumber"].HeaderText = "Users Index Number";
            searchRentalsDataGrid.Columns["RentalDate"].HeaderText = "Rental Date";
            searchRentalsDataGrid.Columns["ReturnDate"].HeaderText = "Return Date";
        }
        public static void InitializeOnlyActiveRentalsDataGrid(DataGridView rentalsDataGrid)
        {
            rentalsDataGrid.DataSource = Bussiness.Rentals.OnlyActiveRentals();
            rentalsDataGrid.Columns["BookID"].Visible = false;
            rentalsDataGrid.Columns["User"].Visible = false;
            rentalsDataGrid.Columns["RentalsID"].Visible = false;
            rentalsDataGrid.Columns["UserFirstName"].HeaderText = "Users First Name";
            rentalsDataGrid.Columns["UserLastName"].HeaderText = "Users Last Name";
            rentalsDataGrid.Columns["UserIndexNumber"].HeaderText = "Users Index Number";
            rentalsDataGrid.Columns["RentalDate"].HeaderText = "Rental Date";
            rentalsDataGrid.Columns["ReturnDate"].HeaderText = "Return Date";
        }
        public static void InitializeExpireSoonRentalsDataGrid(DataGridView expireSoonRentalsDataGrid)
        {
            expireSoonRentalsDataGrid.DataSource = Bussiness.Rentals.ExpireSoonRentals();
            expireSoonRentalsDataGrid.Columns["BookID"].Visible = false;
            expireSoonRentalsDataGrid.Columns["User"].Visible = false;
            expireSoonRentalsDataGrid.Columns["RentalsID"].Visible = false;
            expireSoonRentalsDataGrid.Columns["UserFirstName"].HeaderText = "Users First Name";
            expireSoonRentalsDataGrid.Columns["UserLastName"].HeaderText = "Users Last Name";
            expireSoonRentalsDataGrid.Columns["UserIndexNumber"].HeaderText = "Users Index Number";
            expireSoonRentalsDataGrid.Columns["RentalDate"].HeaderText = "Rental Date";
            expireSoonRentalsDataGrid.Columns["ReturnDate"].HeaderText = "Return Date";
        }
        public static void InitializeAuthorsDataGrid(DataGridView authorsDataGrid)
        {
            authorsDataGrid.DataSource = Bussiness.Authors.AllAuthors();
            authorsDataGrid.Columns["AuthorID"].Visible = false;
            authorsDataGrid.Columns["DeleteDate"].Visible = false;
            authorsDataGrid.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            authorsDataGrid.Columns["DateOfDeath"].HeaderText = "Date Of Death";
        }
        public static void InitializeSearchStudentDataGrid(DataGridView studentsDataGrid, List<UserModel> searchStudents)
        {
            studentsDataGrid.DataSource = searchStudents;
            studentsDataGrid.Columns["UserID"].Visible = false;
            studentsDataGrid.Columns["Role"].Visible = false;
            studentsDataGrid.Columns["FirstName"].HeaderText = "First Name";
            studentsDataGrid.Columns["LastName"].HeaderText = "Last Name";
            studentsDataGrid.Columns["IndexNumber"].HeaderText = "Index Number";
        }

        public static void InitializeSearchEmployeesDataGrid(DataGridView employeeDataGrid, List<UserModel> searchEmployee)
        {
            employeeDataGrid.DataSource = searchEmployee;
            employeeDataGrid.Columns["UserID"].Visible = false;
            employeeDataGrid.Columns["Role"].Visible = false;
            employeeDataGrid.Columns["FirstName"].HeaderText = "First Name";
            employeeDataGrid.Columns["LastName"].HeaderText = "Last Name";
        }

    }
}
