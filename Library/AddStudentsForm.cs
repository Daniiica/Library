using Library.Business;
using Library.Data.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class AddStudentsForm : Form
    {
        private UnitOfWork _unitOfWork;
        private User _user;
        public AddStudentsForm()
        {
            InitializeComponent();
            AddUpdateLabel.Text = "Add student";
            _unitOfWork = new UnitOfWork();
        }
        public AddStudentsForm(User user)
        {
            _user = user;
            InitializeComponent();
            AddUpdateLabel.Text = "Update student";
            FirstNameTextBox.Text = user.FirstName;
            LastNameTextBox.Text = user.LastName;
            IndexNumberTextBox.Text = user.IndexNumber;
            PhoneTextBox.Text = user.Phone;
            EmailTextBox.Text = user.Email;
            PasswordTextBox.Text = user.Password;
            _unitOfWork = new UnitOfWork();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OKButton_Click_1(object sender, EventArgs e)
        {
            FirstNameValidation.Text = "";
            LastNameValidation.Text = "";
            IndexNumberValidation.Text = "";
            PhoneValidation.Text = "";
            EmailValidation.Text = "";
            PasswordValidation.Text = "";

            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var indexNumber = IndexNumberTextBox.Text;
            var email = EmailTextBox.Text;
            var phone = PhoneTextBox.Text;
            var password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(indexNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    FirstNameValidation.Text = "First Name is required";
                }
                if (string.IsNullOrEmpty(lastName))
                {
                    LastNameValidation.Text = "Last Name is required";
                }
                if (string.IsNullOrEmpty(indexNumber))
                {
                    IndexNumberValidation.Text = "Index Number is required";
                }
                if (string.IsNullOrEmpty(email))
                {
                    EmailValidation.Text = "Email is required";
                }
                if (string.IsNullOrEmpty(password))
                {
                    PasswordValidation.Text = "Password is required";
                }
                if (string.IsNullOrEmpty(phone))
                {
                    PhoneValidation.Text = "Phone is required";
                }

            }
            else
            {
                if (_user == null)
                {
                    User newStudent = new User { FirstName = firstName, LastName = lastName, IndexNumber = indexNumber, Email = email, Password = password, Phone = phone, RoleID = (int)RoleTypes.Student, InsertDateUtc = DateTime.UtcNow };
                    User existStudent = _unitOfWork.UserRepository.Get(s => s.IndexNumber == indexNumber || s.Email == email).FirstOrDefault();
                    if (existStudent == null)
                    {
                        _unitOfWork.UserRepository.Insert(newStudent);
                        _unitOfWork.Save();
                        MessageBox.Show("Student was successfully added!");
                    }
                    else
                    {
                        MessageBox.Show("Student already exists!");
                    }
                }
                else
                {
                    User student = _unitOfWork.UserRepository.GetByID(_user.UserID);
                    student.FirstName = FirstNameTextBox.Text;
                    student.LastName = LastNameTextBox.Text;
                    student.IndexNumber = IndexNumberTextBox.Text;
                    student.Phone = PhoneTextBox.Text;
                    student.Email = EmailTextBox.Text;
                    student.Password = PasswordTextBox.Text;

                    //  _unitOfWork.UserRepository.Update(_user);
                    _unitOfWork.Save();
                    MessageBox.Show("Student was successfully changed!");
                }
            }
        }
    }
}
