using MaterialSkin.Controls;
using System;

namespace Library.Presentation
{
    public partial class ChangePassword : MaterialForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //Helpers.FormManager.OpenLoginForm();
        }

        private void OKButton1_Click(object sender, EventArgs e)
        {
            var email = EmailTextBox.Text;
            var newPassword = NewPasswordTextBox.Text;
            var confirmNewPassword = ConfirmNewPasswordTextBox.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MaterialMessageBox.Show("Please enter all information.");
                return;
            }
            if (newPassword == confirmNewPassword)
            {
                Bussiness.Users.ChangePass(email, newPassword);
            }
            else
            {
                MaterialMessageBox.Show("Please confirm new password.");
            }
            
        }
    }
}
