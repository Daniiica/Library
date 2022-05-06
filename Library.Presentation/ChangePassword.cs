using Library.Business;
using MaterialSkin.Controls;
using System;
using System.Linq;

namespace Library.Presentation
{
    public partial class ChangePassword : MaterialForm
    {
        UnitOfWork _unitOfWork;
        public ChangePassword()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var email = EmailTextBox.Text;
            var newPassword = NewPasswordTextBox.Text;
            var confirmNewPassword = ConfirmNewPasswordTextBox.Text;
            DateTime? deleteDate = null;
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MaterialMessageBox.Show("Please enter all information.");
                return;
            }
            if(newPassword == confirmNewPassword)
            {
                var user = _unitOfWork.UserRepository.Get(u => u.Email == email && u.DeleteDateUtc == deleteDate).FirstOrDefault();
                if(user == null)
                {
                    MaterialMessageBox.Show("Email isn't valid.");
                    return;
                }
                user.Password = newPassword;
                _unitOfWork.Save();
                MaterialMessageBox.Show("Password changed successfully.");
            }
            else
            {
                MaterialMessageBox.Show("Please confirm new password.");
            }
        }
    }
}
