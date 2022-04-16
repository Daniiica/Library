using Library.Business;
using Library.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class RentalsForm : Form
    {
        UnitOfWork _unitOfWork;
        public RentalsForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            Initialize_Boxs();
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
              //  StudentsIndexNumberComboBox.Items.Add(users.ElementAt(i).IndexNumber);
            }
        }
        int rentalID;
        private void RentalsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in RentalsDataGrid.SelectedRows)
            {
                rentalID = (int)row.Cells[0].Value;

            }
        }
        private void Rentals_Load(object sender, EventArgs e)
        {
            this.rentalsTableAdapter.Fill(this.libraryDBDataSet2.Rentals);
        }
        /*  private void RentalsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              int indexRow = e.RowIndex;
              if (indexRow < 0)
              {
                  return;
              }
              DataGridViewRow row = RentalsDataGrid.Rows[indexRow];

              rentalID = (int)row.Cells[0].Value;

          }
        */
        private void AddRentalButton_Click(object sender, EventArgs e)
        {
            AddRentalsForm addRental = new AddRentalsForm();
            addRental.Show();
        }

        private void DeleteRentalButton_Click(object sender, EventArgs e)
        {
            Rentals deleteRental = new Rentals { };
            deleteRental = _unitOfWork.RentalsRepository.GetByID(rentalID);
            if (deleteRental == null)
            {
                MessageBox.Show("Please select rental.");
            }
            else
            {
                _unitOfWork.RentalsRepository.Delete(rentalID);
                _unitOfWork.Save();
                MessageBox.Show("Rental was successfully deleted!");
            }
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            /*
            var search_book_text = string.IsNullOrEmpty(BookComboBox.Text) ? null : BookComboBox.Text;
            var search_user_first_name_text = string.IsNullOrEmpty(StudentsFirstNameComboBox.Text) ? null : StudentsFirstNameComboBox.Text;
            var search_user_last_name_text = string.IsNullOrEmpty(StudentsLastNameComboBox.Text) ? null : StudentsLastNameComboBox.Text;
            var search_user_index_number_text = string.IsNullOrEmpty(StudentsIndexNumberComboBox.Text) ? null : StudentsIndexNumberComboBox.Text;
            //  var search_rental_date = RentalDatePicker.Value == DateTime.MinValue ? null : (DateTime?)RentalDatePicker.Value.Date;

            var rentals = _unitOfWork.RentalsRepository.Get(r =>
            (search_book_text == null || r.Book.Name == search_book_text) &&
            (search_user_first_name_text == null || (r.User.FirstName.Contains(search_user_first_name_text))) &&
            (search_user_last_name_text == null || (r.User.LastName.Contains(search_user_last_name_text))) &&
            (search_user_index_number_text == null || (r.User.IndexNumber.Contains(search_user_index_number_text))),
            r => r.OrderBy(i => i.User.IndexNumber));
        //  var itemStates = new List<ItemState>();
            //  var bindingSource1 = new System.Windows.Forms.BindingSource { DataSource = itemStates };
            //  dataGridView1.DataSource = bindingSource1;

            //RentalsDataGrid.DataSource = typeof(List);
            //    RentalsDataGrid.DataSource = rentals.ToList();
            */
        }

        private void UpdateRentalButton_Click(object sender, EventArgs e)
        {
            Rentals updateRental = new Rentals();
            updateRental = _unitOfWork.RentalsRepository.GetByID(rentalID);
            if (updateRental == null)
            {
                MessageBox.Show("Please select rental.");
                return;
            }
            else
            {
                AddRentalsForm addRental = new AddRentalsForm(updateRental);
                //addBook.MdiParent = this;
                addRental.Show();
            }
            RentalsDataGrid.Update();
            RentalsDataGrid.Refresh();

        }

    }
}
