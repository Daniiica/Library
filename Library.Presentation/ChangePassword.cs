using Library.Business;
using MaterialSkin.Controls;
using System;
using System.Linq;

namespace Library.Presentation
{
    public partial class ChangePassword : MaterialForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Helpers.FormManager.OpenLoginForm();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var email = EmailTextBox.Text;
            var newPassword = NewPasswordTextBox.Text;
            var confirmNewPassword = ConfirmNewPasswordTextBox.Text;
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MaterialMessageBox.Show("Please enter all information.");
                return;
            }
            if(newPassword == confirmNewPassword)
            {
                Bussiness.Users.ChangePass(email, newPassword);
                MaterialMessageBox.Show("Password changed successfully.");
            }
            else
            {
                MaterialMessageBox.Show("Please confirm new password.");
            }
        }
    }
}
