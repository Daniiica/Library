using Library.Business;
using Library.Data.Domain;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Library.Presentation
{
    public partial class Registration : MaterialForm
    {
        UnitOfWork _unitOfWork;
        public Registration()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;
            var indexNumber = indexNumberTextBox.Text;
            var phone = phoneTextBox.Text;

            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(indexNumber) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter all information!");
                return;
            }
            else
            {
                Bussiness.Users.SetUser(firstName, lastName, email, password, indexNumber, phone);
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            Helpers.FormManager.OpenLoginForm();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            Helpers.FormManager.OpenChangePassForm();
        }
    }
       
}
