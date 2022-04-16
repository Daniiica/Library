using Library.Business;
using Library.Data.Domain;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AdministrationsForm : Form
    {
        private UnitOfWork _unitOfWork;
        public AdministrationsForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }
        int userId;
        private void EmployerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            DataGridViewRow row = EmpoyedDataGrid.Rows[indexRow];

            userId = (int)row.Cells[0].Value;
        }
        private void AdministrationsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet31.Employers' table. You can move, or remove it, as needed.
            this.employersTableAdapter.Fill(this.libraryDBDataSet31.Employers);
        }

        private void AddEmployerButton_Click(object sender, EventArgs e)
        {

            AddEmployerForm addEmployersForm = new AddEmployerForm();
            // addStudentsForm.MdiParent = this;
            addEmployersForm.Show();
        }

        private void UpdateEmployerButton_Click(object sender, EventArgs e)
        {
            User updateUser = new User { };
            updateUser = _unitOfWork.UserRepository.GetByID(userId);
            if (updateUser == null)
            {
                MessageBox.Show("Please select employer.");
                return;
            }
            else
            {
                AddEmployerForm addEmployer = new AddEmployerForm(updateUser);
                //addStudent.MdiParent = this;
                addEmployer.Show();
            }
        }

        private void DeleteEmployerButton_Click(object sender, EventArgs e)
        {
            var deleteUser = _unitOfWork.UserRepository.GetByID(userId);
            if (deleteUser == null)
            {
                MessageBox.Show("Please select employer.");
                return;
            }
            else
            {
                deleteUser.DeleteDateUtc = DateTime.UtcNow;
                _unitOfWork.Save();
                MessageBox.Show("Employer was successfully deleted!");
                foreach (DataGridViewRow row in EmpoyedDataGrid.SelectedRows)
                {
                    EmpoyedDataGrid.Rows.Remove(row);
                }
            }
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
