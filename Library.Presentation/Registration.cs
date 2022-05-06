﻿using MaterialSkin.Controls;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Library.Presentation
{
    public partial class Registration : MaterialForm
    {
        Thread th;
        public Registration()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;
            var indexNumber = indexNumberTextBox.Text;
            var phone = phoneTextBox.Text;


        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            /*     this.Visible = false;
                 Login loginForm = new Login();
                 loginForm.Show();
            */
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Login());
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangePassword changePassForm = new ChangePassword();
            changePassForm.Show();
        }
    }
}