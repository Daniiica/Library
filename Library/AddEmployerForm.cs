using Library.Business;
using Library.Data.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class AddEmployerForm : Form
    {
        private UnitOfWork _unitOfWork;
        private User _user;
        public AddEmployerForm()
        {
            InitializeComponent();
            AddUpdateLabel.Text = "Add employer";
            _unitOfWork = new UnitOfWork();
        }
        public AddEmployerForm(User user)
        {
            _user = user;
            InitializeComponent();
            AddUpdateLabel.Text = "Update employer";
            FirstNameTextBox.Text = user.FirstName;
            LastNameTextBox.Text = user.LastName;
            PhoneTextBox.Text = user.Phone;
            EmailTextBox.Text = user.Email;
            PasswordTextBox.Text = user.Password;
            _unitOfWork = new UnitOfWork();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            FirstNameValidation.Text = "";
            LastNameValidation.Text = "";
            PhoneValidation.Text = "";
            EmailValidation.Text = "";
            PasswordValidation.Text = "";

            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var email = EmailTextBox.Text;
            var phone = PhoneTextBox.Text;
            var password = PasswordTextBox.Text; if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    FirstNameValidation.Text = "First Name is required";
                }
                if (string.IsNullOrEmpty(lastName))
                {
                    LastNameValidation.Text = "Last Name is required";
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
                    User newEmployer = new User { FirstName = firstName, LastName = lastName, Email = email, Password = password, Phone = phone, RoleID = (int)RoleTypes.Operation, InsertDateUtc = DateTime.UtcNow };
                    User existEmployer = _unitOfWork.UserRepository.Get(s => s.FirstName == firstName && s.LastName == lastName).FirstOrDefault();
                    if (existEmployer == null)
                    {
                        _unitOfWork.UserRepository.Insert(newEmployer);
                        _unitOfWork.Save();
                        MessageBox.Show("Employer was successfully added!");
                    }
                    else
                    {
                        MessageBox.Show("Employer already exists!");
                    }
                }
                else
                {
                    User employer = _unitOfWork.UserRepository.GetByID(_user.UserID);
                    employer.FirstName = FirstNameTextBox.Text;
                    employer.LastName = LastNameTextBox.Text;
                    employer.Phone = PhoneTextBox.Text;
                    employer.Email = EmailTextBox.Text;
                    employer.Password = PasswordTextBox.Text;

                    _unitOfWork.Save();
                    MessageBox.Show("Employer was successfully changed!");
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
