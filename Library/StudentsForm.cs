using Library.Business;
using Library.Data.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Library
{
    public partial class StudentsForm : Form
    {
        private UnitOfWork _unitOfWork;
        private int userID;
        private bool select_validation;

        public StudentsForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.libraryDBDataSet.Users);

        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentsForm addStudentsForm = new AddStudentsForm();
           // addStudentsForm.MdiParent = this;
            addStudentsForm.Show();
        }

        private void StudentsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if(indexRow < 0)
            {
                return;
            }
            DataGridViewRow row = StudentsGrid.Rows[indexRow];

            userID = (int)row.Cells[0].Value;
            select_validation = true;
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            var deleteUser = _unitOfWork.UserRepository.GetByID(userID);
            if (deleteUser == null)
            {
                MessageBox.Show("Please select student.");
                return;
            }
            else
            {
                deleteUser.DeleteDateUtc = DateTime.UtcNow;
                _unitOfWork.Save();
                MessageBox.Show("Student was successfully deleted!");
                foreach (DataGridViewRow row in StudentsGrid.SelectedRows)
                {
                    StudentsGrid.Rows.Remove(row);
                }
                select_validation = false;
            }
        }
        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            if (!select_validation)
            {
                MessageBox.Show("Please select student.");
                return;
            }
            User updateUser = new User { };
            updateUser = _unitOfWork.UserRepository.GetByID(userID);
            if (updateUser == null)
            {
                MessageBox.Show("Please select student.");
                return;
            }
            else
            {
                AddStudentsForm addStudent = new AddStudentsForm(updateUser);
                //addStudent.MdiParent = this;
                addStudent.Show();
            }
            StudentsGrid.Update();
            StudentsGrid.Refresh();
        }

        private void SearchStudentButton_Click(object sender, EventArgs e)
        {
        /*    var search_student_first_name_text = string.IsNullOrEmpty(FirstNameTextBox.Text) ? null : FirstNameTextBox.Text;
            var search_student_last_name_text = string.IsNullOrEmpty(LastNameTextBox.Text) ? null : LastNameTextBox.Text;
            var search_student_index_number_text = string.IsNullOrEmpty(IndexNumberTextBox.Text) ? null : IndexNumberTextBox.Text;

            var students = _unitOfWork.UserRepository.Get(u =>
            (search_student_first_name_text == null || u.FirstName == search_student_first_name_text) &&
            (search_student_last_name_text == null || (u.LastName.Contains(search_student_last_name_text))) &&
            (search_student_index_number_text == null || (u.IndexNumber.Contains(search_student_index_number_text))),
            u => u.OrderBy(i => i.IndexNumber));

            var itemStates = new List<ItemState>(); 
            var bindingSource1 = new System.Windows.Forms.BindingSource { DataSource = itemStates };
            StudentsGrid.DataSource = bindingSource1;
        */
        }
    }
}
