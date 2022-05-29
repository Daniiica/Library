using MaterialSkin.Controls;
using System;
using Library.Business;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace Library.Presentation
{
    public partial class Login : MaterialForm
    {
        private UnitOfWork _unitOfWork;
        private ErrorProvider errorProvider1;

        public Login()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            errorProvider1 = new ErrorProvider();

            usernameTextBox.Text = "admin@gmail.com";
            passwordTextbox.Text = "123";

        }

        /*     private void usernameTextBox_Validating(object sender, CancelEventArgs e)
             {
                 if (usernameTextBox.Text.Trim() == String.Empty)
                 {
                     errorProvider1.SetError(usernameTextBox, "Username is Required");
                     e.Cancel = true;
                 }
                 else
                     errorProvider1.SetError(usernameTextBox, "");
             }

             private void passwordTextbox_Validating(object sender, CancelEventArgs e)
             {
                 if (passwordTextbox.Text.Trim() == String.Empty)
                 {
                     errorProvider1.SetError(passwordTextbox, "Password is Required");
                     e.Cancel = true;
                 }
                 else
                     errorProvider1.SetError(passwordTextbox, "");
             }
        */
        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextbox.Text;

            /*       if (Validation.hasValidationErrors(Login.ActiveForm.Controls))
                   {
                       // if we get here the validation passed
                       MaterialMessageBox.Show("Username or password is empty!");
                       return;
                   }
            */
            var loginOK = _unitOfWork.UserRepository.Get(user => user.Email == userName && user.Password == password && user.DeleteDateUtc == null).FirstOrDefault();
            if (loginOK != null)
            {
                Program.Current.Initialize(new Models.UserModel(loginOK));
                if (Program.Current.User.Role == RoleTypes.Admin)
                {
                    this.Hide();
                    Helpers.FormManager.OpenAdminHomeForm();
                }
                else if (Program.Current.User.Role == RoleTypes.Student)
                {
                    this.Hide();
                    Helpers.FormManager.OpenUserHomeForm();
                }
            }
            else
            {
                MaterialMessageBox.Show("Invalid Username or Password!");

            }

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            Helpers.FormManager.OpenRegistrationForm();
        }


        private void materialLabel1_Click(object sender, EventArgs e)
        {
            Helpers.FormManager.OpenChangePassForm();
        }
    }
}
