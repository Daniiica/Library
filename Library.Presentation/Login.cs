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
        Thread th;
        public Login()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
             errorProvider1 = new ErrorProvider();
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
            DateTime? nullDateTime = null;
            var loginOK = _unitOfWork.UserRepository.Get(user => user.Email == userName && user.Password == password && (user.DeleteDateUtc == nullDateTime)).FirstOrDefault();

            if (loginOK != null && loginOK.RoleID != 3)
            {
                this.Hide();
                AdminHome adminForm = new AdminHome();
                adminForm.Show();
            }
            else if (loginOK != null && loginOK.RoleID == 3)
            {
                this.Hide();
                UserHome studentForm = new UserHome();
                studentForm.Show();
            }
            else
            {
                MaterialMessageBox.Show("Invalid Username or Password!");

            }

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            th = new Thread(openNewRegistrationForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openNewRegistrationForm(object obj)
        {
            Application.Run(new Registration());
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
         //   this.Close();
            th = new Thread(openNewChangePassForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewChangePassForm()
        {
            Application.Run(new ChangePassword());
        }
    }
}
