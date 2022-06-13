using Library.Business;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Library.Presentation
{
    public partial class AdminHome : MaterialForm
    {
        int bookID;
        int rentalID;
        int studentID;
        int employeeID;
        bool select_validation_book = false;
        bool select_validation_rental = false;
        bool select_validation_student = false;
        bool select_validation_employee = false;

        public AdminHome()
        {
            InitializeComponent();

            Helpers.DataGridManager.InitializeAllBookDataGrid(booksDataGrid);
            Helpers.CheckListManager.InitializeCheckListGenres(genreSearchCheckedListBox);
            Helpers.DataGridManager.InitializeAllStudentsDataGrid(userDataGrid);
            Helpers.DataGridManager.InitializeWishBookDataGrid(wishBookDataGrid);
            Helpers.DataGridManager.InitializeExpireSoonRentalsDataGrid(expireSoonRentalsDataGrid);
            Helpers.DataGridManager.InitializeAllRentalsDataGrid(rentalDataGrid);
            Helpers.DataGridManager.InitializeAllEmployedDataGrid(employeeDataGrid);
            Helpers.ComboBoxManager.SetValuesToBooksComboBox(rentalBookComboBox);
            Helpers.ComboBoxManager.SetValuesToBooksComboBox(searchBooksBookComboBox);
            Helpers.ComboBoxManager.SetValuesToAuthorComboBox(searchBooksAuthorComboBox);
            Helpers.ComboBoxManager.SetValuesToISBNComboBox(searchBooksISBNComboBox);
            Helpers.ComboBoxManager.SetValuesToUsersComboBox(rentalUserFirstNameComboBox, rentalUserLastNameComboBox, rentalUserIndexNumberComboBox);
            Helpers.ComboBoxManager.SetValuesToUsersComboBox(userSearchFirstNameComboBox, userSearchLastNameComboBox, userSearchIndexNumberComboBox);
            Helpers.ComboBoxManager.SetValuesToEmployeeComboBox(searchEmployeeFirstNameComboBox, searchEmployeeLastNameComboBox, searchEmployeeEmailComboBox, searchEmployeePhoneComboBox);
            activeRentalCheckBox.Checked = false;
            Helpers.ComboBoxManager.AddEmptyValueToSearchComboBox(searchBooksBookComboBox, searchBooksAuthorComboBox,
                searchBooksISBNComboBox, rentalBookComboBox, rentalUserFirstNameComboBox,
                rentalUserLastNameComboBox, rentalUserIndexNumberComboBox, userSearchFirstNameComboBox,
                userSearchLastNameComboBox, userSearchIndexNumberComboBox, searchEmployeeFirstNameComboBox,
                searchEmployeeLastNameComboBox, searchEmployeeEmailComboBox, searchEmployeePhoneComboBox);
        }

        //Admin ---> Home

        private void wishBookDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, wishBookDataGrid);
            if (bookID == 0)
            {
                return;
            }
            else
            {
                select_validation_book = true;
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            if (select_validation_book == false)
            {
                MaterialMessageBox.Show("Please select wish book");
            }
            else
            {
                Bussiness.WishBooks.ApproveWishBook(bookID);
                MaterialMessageBox.Show("Wish book was approved");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (select_validation_book == false)
            {
                MaterialMessageBox.Show("Please select wish book");
            }
            else
            {
                Bussiness.WishBooks.DeleteWishBook(bookID);
                MaterialMessageBox.Show("Wish book was deleted");
            }
        }

        // Admin ---> Book
        private void searchBookButton_Click(object sender, System.EventArgs e)
        {
            var search_book_name = string.IsNullOrEmpty(searchBooksBookComboBox.Text) ? null : searchBooksBookComboBox.Text;
            var search_book_isbn = Convert.ToInt32(string.IsNullOrEmpty(searchBooksISBNComboBox.Text) ? null : searchBooksISBNComboBox.Text);
            var search_book_author = string.IsNullOrEmpty(searchBooksAuthorComboBox.Text) ? null : searchBooksAuthorComboBox.Text;
            var search_book_genres = Helpers.CheckListManager.GetSelectedGenresFromCheckList(genreSearchCheckedListBox);
            var search_books = Bussiness.Books.GetSearchedBooks(search_book_name, search_book_isbn, search_book_author, search_book_genres);
            Helpers.DataGridManager.InitializeSearchBookDataGrid(booksDataGrid, search_books);
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            bookID = 0;
            Helpers.FormManager.OpenBookForm(bookID);
            this.Hide();
            //Helpers.DataGridManager.InitializeAllBookDataGrid(booksDataGrid);
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            if (select_validation_book == false)
            {
                MaterialMessageBox.Show("Please select book for update");
            }
            else
            {
                Helpers.FormManager.OpenBookForm(bookID);
            }
            this.Hide();
            //Helpers.DataGridManager.InitializeAllBookDataGrid(booksDataGrid);
        }

        private void booksDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, booksDataGrid);
            if (bookID == 0)
            {
                return;
            }
            else
            {
                select_validation_book = true;
            }

        }
        private void saveBookToCSVButton_Click(object sender, EventArgs e)
        {
            Bussiness.Books.SaveBooksToCsv(booksDataGrid);
        }
        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if (select_validation_book == false)
            {
                MaterialMessageBox.Show("Please select book for delete.");
                return;
            }
            else
            {
                Bussiness.Books.DeleteBook(bookID);
                Helpers.DataGridManager.InitializeAllBookDataGrid(booksDataGrid);
                MaterialMessageBox.Show("Book was deleted");
                select_validation_book = false;
            }
        }

        //Admin ---> Students
        private void removeStudenstCheckBoxes()
        {
            //kako da mi se isprazni checkbox
            userSearchFirstNameComboBox.ResetText();
            userSearchLastNameComboBox.ResetText();
            userSearchIndexNumberComboBox.SelectedText = "";
        }
        private void userSearchButton_Click(object sender, EventArgs e)
        {
            var searchUserFirstName = string.IsNullOrEmpty(userSearchFirstNameComboBox.Text) ? null : userSearchFirstNameComboBox.Text;
            var searchUserLastName = string.IsNullOrEmpty(userSearchLastNameComboBox.Text) ? null : userSearchLastNameComboBox.Text;
            var searchUserIndexNumber = string.IsNullOrEmpty(userSearchIndexNumberComboBox.Text) ? null : userSearchIndexNumberComboBox.Text;
            var searchStudents = Bussiness.Users.GetSearchedStudents(searchUserFirstName, searchUserLastName, searchUserIndexNumber);
            Helpers.DataGridManager.InitializeSearchStudentDataGrid(userDataGrid, searchStudents);

            removeStudenstCheckBoxes();
        }
        private void userDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studentID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, userDataGrid);
            if (studentID == 0)
            {
                return;
            }
            else
            {
                select_validation_student = true;
            }
        }
        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            if (select_validation_student == false)
            {
                MaterialMessageBox.Show("Please select student for update");
                return;
            }
            else
            {
                InitializeComponentForUpdateStudent(studentID);
            }
        }
        private void InitializeComponentForUpdateStudent(int studentID)
        {
            var student = Bussiness.Users.GetStudentById(studentID);
            addStudentFirstNameTextBox.Text = student.FirstName;
            addStudentLastNameTextBox.Text = student.LastName;
            addStudentIndexNumberTextBox.Text = student.IndexNumber;
            addStudentPasswordTextBox.Text = student.Password;
            addStudentPhoneTextBox.Text = student.Phone;
            addStudentEmailTextBox.Text = student.Email;
        }
        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (select_validation_student == false)
            {
                MaterialMessageBox.Show("Please select student for delete");
                return;
            }
            else
            {
                Bussiness.Users.DeleteStudent(studentID);
                Helpers.DataGridManager.InitializeAllStudentsDataGrid(userDataGrid);
                MaterialMessageBox.Show("Student was deleted");
                select_validation_student = false;
            }
        }
        private void addOrUpdateStudentButton_Click(object sender, EventArgs e)
        {
            var studentFirstName = addStudentFirstNameTextBox.Text;
            var studentLastName = addStudentLastNameTextBox.Text;
            var studentIndexNumber = addStudentIndexNumberTextBox.Text;
            var studentPassword = addStudentPasswordTextBox.Text;
            var studentPhoneNumber = addStudentPhoneTextBox.Text;
            var studentEmail = addStudentEmailTextBox.Text;

            if (string.IsNullOrEmpty(studentFirstName) ||
                string.IsNullOrEmpty(studentLastName) ||
                string.IsNullOrEmpty(studentPassword) ||
                string.IsNullOrEmpty(studentPhoneNumber) ||
                string.IsNullOrEmpty(studentEmail) ||
                string.IsNullOrEmpty(studentIndexNumber))
            {
                MaterialMessageBox.Show("Enter all data");
                return;
            }
            if (studentID == 0)
            {
                Bussiness.Users.AddNewStudent(studentFirstName, studentLastName, studentPassword, studentPhoneNumber, studentEmail, studentIndexNumber);
                RemoveDataFromStudentsComponents();
            }
            else
            {
                Bussiness.Users.UpdateStudent(studentID, studentFirstName, studentLastName, studentPassword, studentPhoneNumber, studentEmail, studentIndexNumber);
                RemoveDataFromStudentsComponents();
            }
            Helpers.DataGridManager.InitializeAllStudentsDataGrid(userDataGrid);
            select_validation_student = false;
        }

        private void RemoveDataFromStudentsComponents()
        {
            addStudentFirstNameTextBox.Text = "";
            addStudentLastNameTextBox.Text = "";
            addStudentIndexNumberTextBox.Text = "";
            addStudentPasswordTextBox.Text = "";
            addStudentPhoneTextBox.Text = "";
            addStudentEmailTextBox.Text = "";
        }
        private void resetStudentButton_Click(object sender, EventArgs e)
        {
            studentID = 0;
            select_validation_student = false;
            RemoveDataFromStudentsComponents();
        }
        private void studentsSaveToCSV_Click(object sender, EventArgs e)
        {
            Bussiness.Users.SaveUsersToCsv(userDataGrid);
        }
        //Admin ---> Rentals
        private void rentalSearchButton_Click(object sender, EventArgs e)
        {
            var searchRentalBook = string.IsNullOrEmpty(rentalBookComboBox.Text) ? null : rentalBookComboBox.Text;
            var searchRentalUserFirstName = string.IsNullOrEmpty(rentalUserFirstNameComboBox.Text) ? null : rentalUserFirstNameComboBox.Text;
            var searchRentalUserLastName = string.IsNullOrEmpty(rentalUserLastNameComboBox.Text) ? null : rentalUserLastNameComboBox.Text;
            var searchRentalUserIndexNumber = string.IsNullOrEmpty(rentalUserIndexNumberComboBox.Text) ? null : rentalUserIndexNumberComboBox.Text;

            var searchRental = Bussiness.Rentals.GetSearchRentals(searchRentalBook, searchRentalUserFirstName, searchRentalUserLastName, searchRentalUserIndexNumber);
            Helpers.DataGridManager.InitializeSearchRentalsDataGrid(rentalDataGrid, searchRental);
        }

        private void rentalDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rentalID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, rentalDataGrid);
            if (rentalID == 0)
            {
                return;
            }
            else
            {
                select_validation_rental = true;
            }
        }

        private void updateRentalButton_Click(object sender, EventArgs e)
        {
            if (select_validation_rental == false)
            {
                MaterialMessageBox.Show("Please select rental for update");
                return;
            }
            else
            {
                InitializeComponentForUpdateRental(rentalID);
            }
        }
        private void InitializeComponentForUpdateRental(int rentalID)
        {
            var rental = Bussiness.Rentals.GetRentalById(rentalID);
            rentalUserIndexNumberTextBox.Text = rental.User.IndexNumber;
            rentalBookIsbnTextBox.Text = Convert.ToString(rental.ISBN);
            rentalBookNameTextBox.Text = rental.Book;
            rentalDatePicker.Value = Convert.ToDateTime(rental.RentalDate);
        }

        private void RemoveDataFromRentalComponents()
        {
            rentalUserIndexNumberTextBox.Text = "";
            rentalBookIsbnTextBox.Text = "";
            rentalBookNameTextBox.Text = "";
            rentalDatePicker.Value = DateTime.Now;
        }
        private void returnRentalButton_Click(object sender, EventArgs e)
        {
            if (select_validation_rental == false)
            {
                MaterialMessageBox.Show("Please select rental");
                return;
            }
            else
            {
                Bussiness.Rentals.ReturnBook(rentalID);

            }
            Helpers.DataGridManager.InitializeAllRentalsDataGrid(rentalDataGrid);
            select_validation_rental = false;
        }

        private void OKRentalButton_Click(object sender, EventArgs e)
        {
            var rentalUserIndexNumber = rentalUserIndexNumberTextBox.Text;
            var rentalBookISBN = Convert.ToInt32(rentalBookIsbnTextBox.Text);
            var rentalBookName = rentalBookNameTextBox.Text;
            var rentalDate = rentalDatePicker.Value;

            if (string.IsNullOrEmpty(rentalUserIndexNumber) ||
                (rentalBookISBN == 0) ||
                string.IsNullOrEmpty(rentalBookName))
            {
                MaterialMessageBox.Show("Enter all data");
                return;
            }
            var reservation = Bussiness.Reservation.FindReservation(rentalUserIndexNumber.ToString(), rentalBookISBN, rentalBookName);
            if (reservation != null)
            {
                Bussiness.Reservation.SetToRealized(reservation.ReservationsID);
                Bussiness.Reservation.DeleteReservation(reservation.ReservationsID);
            }
            if (!Bussiness.Reservation.CheckReservationForRental(rentalBookISBN, rentalBookName, rentalDate))
            {
                MaterialMessageBox.Show("All books already reserved!");
                return;
            }
            if (rentalID == 0)
            {
                Bussiness.Rentals.AddNewRental(rentalUserIndexNumber, rentalBookName, rentalBookISBN, rentalDate);
                RemoveDataFromRentalComponents();
            }
            else
            {
                Bussiness.Rentals.UpdateRental(rentalID, rentalUserIndexNumber, rentalBookName, rentalBookISBN, rentalDate);
                RemoveDataFromRentalComponents();
            }
            Helpers.DataGridManager.InitializeAllRentalsDataGrid(rentalDataGrid);
            select_validation_rental = false;
        }

        private void resetRentalButton_Click(object sender, EventArgs e)
        {
            rentalID = 0;
            select_validation_rental = false;
            RemoveDataFromRentalComponents();
        }

        private void deleteRentalButton_Click(object sender, EventArgs e)
        {
            if (select_validation_rental == false)
            {
                MaterialMessageBox.Show("Please select rental for delete");
                return;
            }
            else
            {
                Bussiness.Rentals.DeleteRental(rentalID);
                Helpers.DataGridManager.InitializeAllRentalsDataGrid(rentalDataGrid);
                select_validation_rental = false;
            }
        }

        private void activeRentalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (activeRentalCheckBox.Checked)
            {
                Helpers.DataGridManager.InitializeOnlyActiveRentalsDataGrid(rentalDataGrid);
            }
            else
            {
                Helpers.DataGridManager.InitializeAllRentalsDataGrid(rentalDataGrid);
            }
        }

        private void saveRentalToCsvButton_Click(object sender, EventArgs e)
        {
            Bussiness.Rentals.SaveRentalsToCsv(rentalDataGrid);
        }

        //Admin ---> Administration
        private void employeeSearchButton_Click(object sender, EventArgs e)
        {
            var searchEmployeeFirstName = string.IsNullOrEmpty(searchEmployeeFirstNameComboBox.Text) ? null : searchEmployeeFirstNameComboBox.Text;
            var searchEmployeeLastName = string.IsNullOrEmpty(searchEmployeeLastNameComboBox.Text) ? null : searchEmployeeLastNameComboBox.Text;
            var searchEmployeeEmail = string.IsNullOrEmpty(searchEmployeeEmailComboBox.Text) ? null : searchEmployeeEmailComboBox.Text;
            var searchEmployeePhone = string.IsNullOrEmpty(searchEmployeePhoneComboBox.Text) ? null : searchEmployeePhoneComboBox.Text;

            var searchEmployee = Bussiness.Users.GetSearchEmployees(searchEmployeeFirstName, searchEmployeeLastName, searchEmployeeEmail, searchEmployeePhone);
            Helpers.DataGridManager.InitializeSearchEmployeesDataGrid(employeeDataGrid, searchEmployee);

            removeEmployeeCheckBoxes();
        }

        private void removeEmployeeCheckBoxes()
        {
            //kako da ispraznim checkBox da sadrzi vrednost a ne prikaze nista
        }
        private void employedDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, employeeDataGrid);
            if (employeeID == 0)
            {
                return;
            }
            else
            {
                select_validation_employee = true;
            }
        }

        private void employeeSaveToCSVBUtton_Click(object sender, EventArgs e)
        {
            Bussiness.Users.SaveEmployeeToCsv(employeeDataGrid);
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (select_validation_employee == false)
            {
                MaterialMessageBox.Show("Please select employee for update");
                return;
            }
            else
            {
                InitializeComponentForUpdateEmployee(employeeID);
            }
        }

        private void InitializeComponentForUpdateEmployee(int employeeID)
        {
            var employee = Bussiness.Users.GetEmployeeById(employeeID);
            addEmployeeFirstNameTextBox.Text = employee.FirstName;
            addEmployeeLastNameTextBox.Text = employee.LastName;
            addEmployedPasswordTextBox.Text = employee.Password;
            addEmployedPhoneTextBox.Text = employee.Phone;
            addEmployedEmailTextBox.Text = employee.Email;
        }

        private void addUpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            var employeeFirstName = addEmployeeFirstNameTextBox.Text;
            var employeeLastName = addEmployeeLastNameTextBox.Text;
            var employeePassword = addEmployedPasswordTextBox.Text;
            var employeePhoneNumber = addEmployedPhoneTextBox.Text;
            var employeeEmail = addEmployedEmailTextBox.Text;

            if (string.IsNullOrEmpty(employeeFirstName) ||
                string.IsNullOrEmpty(employeeLastName) ||
                string.IsNullOrEmpty(employeePassword) ||
                string.IsNullOrEmpty(employeePhoneNumber) ||
                string.IsNullOrEmpty(employeeEmail))
            {
                MaterialMessageBox.Show("Enter all data");
                return;
            }
            if (employeeID == 0)
            {
                Bussiness.Users.AddNewEmployee(employeeFirstName, employeeLastName, employeePassword, employeePhoneNumber, employeeEmail);
                RemoveDataFromEmployeeComponents();
            }
            else
            {
                Bussiness.Users.UpdateEmployee(employeeID, employeeFirstName, employeeLastName, employeePassword, employeePhoneNumber, employeeEmail);
                RemoveDataFromEmployeeComponents();
            }
            Helpers.DataGridManager.InitializeAllEmployedDataGrid(employeeDataGrid);
            select_validation_employee = false;
        }

        private void RemoveDataFromEmployeeComponents()
        {
            addEmployeeFirstNameTextBox.Text = "";
            addEmployeeLastNameTextBox.Text = "";
            addEmployedPasswordTextBox.Text = "";
            addEmployedPhoneTextBox.Text = "";
            addEmployedEmailTextBox.Text = "";
        }

        private void resetEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeID = 0;
            select_validation_employee = false;
            RemoveDataFromEmployeeComponents();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (select_validation_employee == false)
            {
                MaterialMessageBox.Show("Please select employee for delete");
                return;
            }
            else
            {
                Bussiness.Users.DeleteEmployee(employeeID);
                Helpers.DataGridManager.InitializeAllEmployedDataGrid(employeeDataGrid);
                MaterialMessageBox.Show("Employee was deleted");
                select_validation_employee = false;
            }
        }
    }
}
