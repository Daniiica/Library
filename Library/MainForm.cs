using Library.Business;
using Library.Data.Domain;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm(User user)
        {
            InitializeComponent();
            if (user.RoleID == (int)RoleTypes.Admin)
            {
                AdministrationButton.Enabled = true;
            }
            else
            {
                AdministrationButton.Enabled = false;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        public enum PageName
        {
            Students = 1,
            Books = 2,
            Rentals = 3,
            Administration = 4
        }

        private void OpenForm(PageName pageName)
        {
            Form form = null;
            switch (pageName)
            {
                case PageName.Students:
                    form = new StudentsForm()
                        {
                            Dock = DockStyle.Fill,
                            TopLevel = false,
                            TopMost = true
                        };
                    break;
                case PageName.Books:
                    form = new BooksForm()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    break;
                case PageName.Rentals:
                    form = new RentalsForm()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    break;
                case PageName.Administration:
                    form = new AdministrationsForm()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    break;
            }

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form);
            form.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(PageName.Students);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(PageName.Books);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void RentalsButton_Click(object sender, EventArgs e)
        {
            OpenForm(PageName.Rentals);
        }

        private void AdministrationButton_Click(object sender, EventArgs e)
        {
            OpenForm(PageName.Administration);
        }
    }
}
