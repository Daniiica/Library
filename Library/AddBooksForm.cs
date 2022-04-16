using Library.Business;
using Library.Data.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{

    public partial class AddBooksForm : Form
    {
        private UnitOfWork _unitOfWork;
        private Book _book;
        public AddBooksForm()
        {
            InitializeComponent();
            AddUpdateLabel.Text = "Add book";
            _unitOfWork = new UnitOfWork();
            Initialize_Boxs();
        }

        public AddBooksForm(Book book)
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            AddUpdateLabel.Text = "Update book";
            _book = book;
            NameTextBox.Text = book.Name;
            AuthorComboBox.Text = book.Author.Name;
            PublisherComboBox.Text = book.Publisher.Name;
            ISBNTextBox.Text = book.ISBN.ToString();
            DescriptionTextBox.Text = book.Description;
            LanguageComboBox.Text = book.Language.Caption;
            AmountTextBox.Text = book.Amount.ToString();
            Initialize_Boxs();

            // kako da cekiram one zanrove koje ima knjiga book koju hocu da update
            var book_genres = book.Genres.ToList();

            for (int i = 0; i < GenreCheckList.Items.Count; i++)
            {
                var x = book_genres.FirstOrDefault(genre => genre.Name == GenreCheckList.Items[i].ToString());
                if (x != null)
                {
                    GenreCheckList.SetItemChecked(i, true);
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            NameValidation.Text = "";
            AuthorValidation.Text = "";
            PublisherValidation.Text = "";
            ISBNValidation.Text = "";
            DescriptionValidation.Text = "";
            LanguageValidation.Text = "";
            AmountValidation.Text = "";


            var name = NameTextBox.Text;
            var author = AuthorComboBox.Text;
            var publisher = PublisherComboBox.Text;
            var isbn = Convert.ToInt32(ISBNTextBox.Text);
            var description = DescriptionTextBox.Text;
            var language = LanguageComboBox.Text;
            int amount = Convert.ToInt32(AmountTextBox.Text);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(ISBNTextBox.Text) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(language) || string.IsNullOrEmpty(AmountTextBox.Text))
            {
                if (string.IsNullOrEmpty(name))
                {
                    NameValidation.Text = "Name is required";
                }
                if (string.IsNullOrEmpty(author))
                {
                    AuthorValidation.Text = "Author is required";
                }
                if (string.IsNullOrEmpty(publisher))
                {
                    PublisherValidation.Text = "Publisher is required";
                }
                if (string.IsNullOrEmpty(ISBNTextBox.Text))
                {
                    ISBNValidation.Text = "ISBN is required";
                }
                if (string.IsNullOrEmpty(description))
                {
                    DescriptionValidation.Text = "Description is required";
                }
                if (string.IsNullOrEmpty(language))
                {
                    LanguageValidation.Text = "Language is required";
                }
                if (string.IsNullOrEmpty(AmountTextBox.Text))
                {
                    AmountValidation.Text = "Amount is required";
                }
            }
            else
            {
                if (_book == null) //dodaje se nova knjiga
                {
                    Author autorAdd;
                    autorAdd = _unitOfWork.AuthorRepository.Get(a => a.Name == author).FirstOrDefault();
                    if (autorAdd == null)
                    {
                        DialogResult res = MessageBox.Show("Author doesn't exists. Do you want to add author?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            AddAuthorsForm addauthor = new AddAuthorsForm(AuthorComboBox.Text);
                            addauthor.Show();

                        }
                        if (res == DialogResult.Cancel)
                        {
                        }
                        return;
                    }
                    Language languageAdd;
                    languageAdd = _unitOfWork.LanguageRepository.Get(l => l.Caption == language).FirstOrDefault();
                    if (languageAdd == null)
                    {
                        MessageBox.Show("Language doesn't exists!");
                        return;
                    }
                    PublishingHouse publisherAdd;
                    publisherAdd = _unitOfWork.PublishingHouseRepository.Get(ph => ph.Name == publisher).FirstOrDefault();
                    if (publisherAdd == null)
                    {
                        MessageBox.Show("Publisher doesn't exists. If you want to add click + !");
                        return;
                    }
                    List<Genre> genres = CheckGenres();
                    Book bookAdd = new Book { Name = name, AuthorID = autorAdd.AuthorID, Description = description, Amount = amount, ISBN = isbn, LanguageID = languageAdd.LanguageID, PublishingHouseId = publisherAdd.PublishingHouseId, Genres = genres, InsertDate = DateTime.UtcNow };
                    Book existBook = _unitOfWork.BookRepository.Get(b => b.Name == name).FirstOrDefault();
                    if (existBook == null)
                    {
                        _unitOfWork.BookRepository.Insert(bookAdd);
                        _unitOfWork.Save();
                        MessageBox.Show("Book has added!");
                    }
                    else
                    {
                        MessageBox.Show("Book already exists. Update book amount!");
                    }
                }
                else
                {
                    Book bookUpdate = _unitOfWork.BookRepository.GetByID(_book.BookID);
                    bookUpdate.Name = NameTextBox.Text;
                    //da se nadje id autora u tabeli Autor i da se prosledi u Book za AutorID
                    Author update_author = new Author();
                    update_author = _unitOfWork.AuthorRepository.Get(a => a.Name == AuthorComboBox.Text).FirstOrDefault();
                    bookUpdate.AuthorID = update_author.AuthorID;
                    Language update_language = new Language();
                    update_language = _unitOfWork.LanguageRepository.Get(l => l.Caption == LanguageComboBox.Text).FirstOrDefault();
                    bookUpdate.LanguageID = update_language.LanguageID;
                    PublishingHouse publishingHouse = new PublishingHouse();
                    publishingHouse = _unitOfWork.PublishingHouseRepository.Get(ph => ph.Name == PublisherComboBox.Text).FirstOrDefault();
                    bookUpdate.PublishingHouseId = publishingHouse.PublishingHouseId;
                    bookUpdate.Description = DescriptionTextBox.Text;
                    bookUpdate.ISBN = Convert.ToInt32(ISBNTextBox.Text);
                    bookUpdate.Amount = Convert.ToInt32(AmountTextBox.Text);
                    List<Genre> genres = CheckGenres();
                    _unitOfWork.Save();
                    MessageBox.Show("Book has updated!");
                }
            }
        }
    // da li moze ovde da se vraca referenca?
    private List<Genre> CheckGenres()
    {
        List<string> genres_names = new List<string>();
        for (int i = 0; i < GenreCheckList.CheckedItems.Count; i++)
        {
            genres_names.Add((string)GenreCheckList.CheckedItems[i]);
        }
        List<Genre> genres = new List<Genre>();
        genres = _unitOfWork.GenreRepository.Get(g => genres_names.Contains(g.Name)).ToList();
        return genres;
    }
    private void CloseButton_Click(object sender, EventArgs e)
    {
        this.Hide();
    }
    private void Initialize_Boxs()
    {
        List<Author> authors = new List<Author>();
        authors = _unitOfWork.AuthorRepository.GetAll();
        for (int i = 0; i < authors.Count; i++)
        {
            AuthorComboBox.Items.Add(authors.ElementAt(i).Name);
            //AuthorComboBox.Items.Add(new { name = (authors.ElementAt(i).Name), value = (authors.ElementAt(i).AuthorID) });
        }

        List<Language> languages = new List<Language>();
        languages = _unitOfWork.LanguageRepository.GetAll();
        for (int i = 0; i < languages.Count; i++)
        {
            LanguageComboBox.Items.Add(languages.ElementAt(i).Caption);
        }
        List<PublishingHouse> publishers = new List<PublishingHouse>();
        publishers = _unitOfWork.PublishingHouseRepository.GetAll();
        for (int i = 0; i < publishers.Count; i++)
        {
            PublisherComboBox.Items.Add(publishers.ElementAt(i).Name);
        }
        List<Genre> genres = new List<Genre>();
        genres = _unitOfWork.GenreRepository.GetAll();
        for (int i = 0; i < genres.Count; i++)
        {
            GenreCheckList.Items.Add(genres[i].Name);

        }
        //GenreCheckList.SetItemChecked(0,true);
    }

    private void AddPublisherPictureBox_Click(object sender, EventArgs e)
    {
        PublisherValidation.Text = "";
        if (string.IsNullOrEmpty(PublisherComboBox.Text))
        {
            PublisherValidation.Text = "Publisher is required!";
            return;
        }
        PublishingHouse publisher = _unitOfWork.PublishingHouseRepository.Get(p => p.Name == PublisherComboBox.Text).FirstOrDefault();

        if (publisher == null)
        {
            PublishingHouse new_publisher = new PublishingHouse();
            new_publisher.Name = PublisherComboBox.Text;
            _unitOfWork.PublishingHouseRepository.Insert(new_publisher);
            _unitOfWork.Save();
            MessageBox.Show("Publisher was successfully added!");
            PublisherComboBox.Items.Add(PublisherComboBox.Text);
        }
        else
        {
            MessageBox.Show("Publisher already exitst!");
        }
    }

    private void AddAuthorPictureBox_Click(object sender, EventArgs e)
    {
        AuthorValidation.Text = "";
        if (string.IsNullOrEmpty(AuthorComboBox.Text))
        {
            AuthorValidation.Text = "Author is required!";
            return;
        }
        Author autor = _unitOfWork.AuthorRepository.Get(a => a.Name == AuthorComboBox.Text).FirstOrDefault();
        if (autor == null)
        {
            AddAuthorsForm addauthor = new AddAuthorsForm(AuthorComboBox.Text);
            addauthor.Show();
        }
        else
        {
            MessageBox.Show("Author already exists!");
        }
    }

    private void DeletePublisherPictureBox_Click(object sender, EventArgs e)
    {
        PublisherValidation.Text = "";
        if (string.IsNullOrEmpty(PublisherComboBox.Text))
        {
            PublisherValidation.Text = "Publisher is required!";
            return;
        }
        PublishingHouse publisher = _unitOfWork.PublishingHouseRepository.Get(p => p.Name == PublisherComboBox.Text).FirstOrDefault();
        if (publisher != null)
        {
            _unitOfWork.PublishingHouseRepository.Delete(publisher);
            _unitOfWork.Save();
            MessageBox.Show("Publisher was successfully deleted!");
            PublisherComboBox.Items.Remove(publisher.Name);
        }
        else
        {
            MessageBox.Show("Publisher doesn't exists!");
        }
    }

    private void DeleteAuthorPictureBox_Click(object sender, EventArgs e)
    {
        AuthorValidation.Text = "";
        if (string.IsNullOrEmpty(AuthorComboBox.Text))
        {
            AuthorValidation.Text = "Author is required!";
            return;
        }
        Author del_author = _unitOfWork.AuthorRepository.Get(a => a.Name == AuthorComboBox.Text).FirstOrDefault();
        if (del_author != null)
        {
            _unitOfWork.AuthorRepository.Delete(del_author);
            _unitOfWork.Save();
            MessageBox.Show("Author was successfully deleted!");
            AuthorComboBox.Items.Remove(AuthorComboBox.Text);
        }
        else
        {
            MessageBox.Show("Author doesn't exists!");
        }
    }

    private void AddGenrePictureBox_Click(object sender, EventArgs e)
    {
        GenreValidation.Text = "";
        if (string.IsNullOrEmpty(GenreTextBox.Text))
        {
            GenreValidation.Text = "Genre is required!";
        }
        else
        {

            Genre genre = _unitOfWork.GenreRepository.Get(g => g.Name == GenreTextBox.Text).FirstOrDefault();
            if (genre == null)
            {
                Genre add_genre = new Genre();
                add_genre.Name = GenreTextBox.Text;
                _unitOfWork.GenreRepository.Insert(add_genre);
                _unitOfWork.Save();
                MessageBox.Show("Genre was successfuly added!");
                GenreCheckList.Items.Add(add_genre.Name);

            }
            else
            {
                MessageBox.Show("Genre aready exists!");
            }
        }
    }

    private void DeleteGenrePictureBox_Click(object sender, EventArgs e)
    {
        GenreValidation.Text = "";
        if (string.IsNullOrEmpty(GenreTextBox.Text))
        {
            GenreValidation.Text = "Genre is required!";
        }
        else
        {
            Genre genre = _unitOfWork.GenreRepository.Get(g => g.Name == GenreTextBox.Text).FirstOrDefault();
            if (genre != null)
            {
                _unitOfWork.GenreRepository.Delete(genre);
                _unitOfWork.Save();
                MessageBox.Show("Genre was successfully deleted!");
                GenreCheckList.Items.Remove(GenreTextBox.Text);
            }
            else
            {
                MessageBox.Show("Genre doesn't exists!");
            }
        }
    }
    }
}
