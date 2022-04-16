using System;
using System.Windows.Forms;

namespace Library
{
    public partial class OpenStudentsForm : Form
    {
        public OpenStudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsDashboard_Load(object sender, EventArgs e)
        {

        }
        public enum PageName
        {
            Dashboard = 1,
            Profile = 2
        }

        private void OpenForm(PageName pageName)
        {
            Form form = null;
            switch (pageName)
            {
                case PageName.Dashboard:
                    form = new StudentsDashboardForm()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    break;
                case PageName.Profile:
                    form = new StudentsProfileForm()
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

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            OpenForm(PageName.Dashboard);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenForm(PageName.Profile);
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
