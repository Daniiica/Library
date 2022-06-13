using MaterialSkin.Controls;
using System;
using Library.Business;

namespace Library.Presentation
{
    public partial class Login : MaterialForm
    {

        public Login()
        {
            InitializeComponent();
            usernameTextBox.Text = "danica@gmail.com";
            passwordTextbox.Text = "2305";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextbox.Text;

            var loginOK = Bussiness.Users.GetUserLogin(userName, password);
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

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Helpers.FormManager.OpenRegistrationForm();
        }

        private void lostPassword_Click(object sender, EventArgs e)
        {
            Helpers.FormManager.OpenChangePassForm();
        }
    }
}
