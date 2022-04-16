using Library.Business;
using Library.Data.Domain;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class AddAuthorsForm : Form
    {
        Author _author;
        UnitOfWork _unitOfWork;
        public AddAuthorsForm(string name)
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            PageName.Text = "Add author";
            NameTextBox.Text = name;
        }
        public AddAuthorsForm(Author author)
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _author = author;
            PageName.Text = "Update author";
            NameTextBox.Text = author.Name;
            CountryTextBox.Text = author.Country;
            BiographyTextBox.Text = author.Biography;
            DateOfBirthPicker.Text = author.DateOfBirth.ToString();
            DateOfDeathPicker.Text = author.DateOfDeath.ToString();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            NameValidation.Text = "";
            CountryValidation.Text = "";
            var name = NameTextBox.Text;
            var country = CountryTextBox.Text;
            var biography = BiographyTextBox.Text;
            var dateOfBirth = DateOfBirthPicker.Value;
            var dateOfDeath = DateOfDeathPicker.Value;
            if (_author == null)
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(country))
                {

                    if (string.IsNullOrEmpty(name))
                    {
                        NameValidation.Text = "Name is required";
                    }
                    if (string.IsNullOrEmpty(country))
                    {
                        CountryValidation.Text = "Country is required";
                    }
                }
                Author autorAdd = new Author { Name = name, Country = country, Biography = biography, DateOfBirth = dateOfBirth, DateOfDeath = dateOfDeath };
                Author exist_author = _unitOfWork.AuthorRepository.Get(a =>
                a.Name == name &&
                a.Country == country &&
                a.DateOfBirth.Day == dateOfBirth.Day &&
                a.DateOfBirth.Month == dateOfBirth.Month &&
                a.DateOfBirth.Year == dateOfBirth.Year &&
                a.DateOfDeath.Day == dateOfDeath.Day &&
                a.DateOfDeath.Month == dateOfDeath.Month &&
                a.DateOfDeath.Year == dateOfDeath.Year).FirstOrDefault();
                if (exist_author != null)
                {
                    MessageBox.Show("Author already exists!");
                    return;
                }
                else
                {
                    _unitOfWork.AuthorRepository.Insert(autorAdd);
                    _unitOfWork.Save();
                    MessageBox.Show("Author has added!");

                }
            }
            else
            {
                Author autorUpdate = _unitOfWork.AuthorRepository.Get(a => a.AuthorID == _author.AuthorID).FirstOrDefault();
                autorUpdate.Name = name;
                autorUpdate.Country = country;
                autorUpdate.Biography = biography;
                autorUpdate.DateOfBirth = dateOfBirth;
                autorUpdate.DateOfDeath = dateOfDeath;
                _unitOfWork.Save();
                MessageBox.Show("Author has updated");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void AddAuthorsForm_Load(object sender, EventArgs e)
        {
            Graphics surface = CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 5);
            surface.DrawLine(pen1, 10, 15, 100, 15);

        }
    }
}
