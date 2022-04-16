using Library.Business;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        private UnitOfWork _unitOfWork;
        public LoginForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginValidation.Text = null;
            var userName = UserNameTextBox.Text;
            var password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(userName))
                {
                    UsernameValidation.Text = "Username is required";
                }
                else
                {
                    UsernameValidation.Text = null;
                }
                if (string.IsNullOrEmpty(password))
                {
                    PasswordValidation.Text = "Password is required";
                }
                else
                {
                    PasswordValidation.Text = null;
                }
                return;
            }
            DateTime? nullDateTime = null;
            var loginOK = _unitOfWork.UserRepository.Get(user => user.Email == userName && user.Password == password && (user.DeleteDateUtc == nullDateTime)).FirstOrDefault();

            if (loginOK != null && loginOK.RoleID != 3)
            {
                this.Hide();
                MainForm main = new MainForm(loginOK);
                main.Show();
            }
            else if(loginOK != null && loginOK.RoleID == 3)
            {
                this.Hide();
                OpenStudentsForm students_dashboard = new OpenStudentsForm();
                students_dashboard.Show();
            }
            else
            {
                //TODO: Prikazi poruku da nije ok
               // MessageBox.Show("Invalid Username or Password!");
                LoginValidation.Text = "Invalid Username or Password!";
            }
        }

    }
}
