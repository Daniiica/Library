
namespace Library.Presentation
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.BookTab = new System.Windows.Forms.TabPage();
            this.DescriptionMultiLineBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.bookNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.LanguageComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.OKBookButton = new MaterialSkin.Controls.MaterialButton();
            this.PublisherComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.GenreCheckBox = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.ISBNTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AuthorComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.AmountTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AuthorTab = new System.Windows.Forms.TabPage();
            this.disableDateOfDeathAuthorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.resetAuthorButton = new MaterialSkin.Controls.MaterialButton();
            this.UpdateAuthorButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteAuthorButton = new MaterialSkin.Controls.MaterialButton();
            this.AuthorsDataGrid = new System.Windows.Forms.DataGridView();
            this.OKAuthorButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DateOfDeathPicker = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.BiographyMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.CountryTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AuthorNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.bookIconTabControl = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.BookTab.SuspendLayout();
            this.AuthorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.BookTab);
            this.materialTabControl1.Controls.Add(this.AuthorTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialTabControl1.ImageList = this.bookIconTabControl;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(799, 383);
            this.materialTabControl1.TabIndex = 15;
            // 
            // BookTab
            // 
            this.BookTab.BackColor = System.Drawing.Color.White;
            this.BookTab.Controls.Add(this.DescriptionMultiLineBox);
            this.BookTab.Controls.Add(this.bookNameTextBox);
            this.BookTab.Controls.Add(this.LanguageComboBox);
            this.BookTab.Controls.Add(this.cancelButton);
            this.BookTab.Controls.Add(this.OKBookButton);
            this.BookTab.Controls.Add(this.PublisherComboBox);
            this.BookTab.Controls.Add(this.GenreCheckBox);
            this.BookTab.Controls.Add(this.ISBNTextBox);
            this.BookTab.Controls.Add(this.AuthorComboBox);
            this.BookTab.Controls.Add(this.AmountTextBox);
            this.BookTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTab.ForeColor = System.Drawing.Color.Transparent;
            this.BookTab.ImageKey = "bookBook.png";
            this.BookTab.Location = new System.Drawing.Point(4, 23);
            this.BookTab.Name = "BookTab";
            this.BookTab.Padding = new System.Windows.Forms.Padding(3);
            this.BookTab.Size = new System.Drawing.Size(791, 356);
            this.BookTab.TabIndex = 0;
            this.BookTab.Text = "BOOK";
            // 
            // DescriptionMultiLineBox
            // 
            this.DescriptionMultiLineBox.AnimateReadOnly = false;
            this.DescriptionMultiLineBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DescriptionMultiLineBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DescriptionMultiLineBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionMultiLineBox.Depth = 0;
            this.DescriptionMultiLineBox.HideSelection = true;
            this.DescriptionMultiLineBox.Hint = "Description";
            this.DescriptionMultiLineBox.Location = new System.Drawing.Point(68, 174);
            this.DescriptionMultiLineBox.MaxLength = 32767;
            this.DescriptionMultiLineBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionMultiLineBox.Name = "DescriptionMultiLineBox";
            this.DescriptionMultiLineBox.PasswordChar = '\0';
            this.DescriptionMultiLineBox.ReadOnly = false;
            this.DescriptionMultiLineBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionMultiLineBox.SelectedText = "";
            this.DescriptionMultiLineBox.SelectionLength = 0;
            this.DescriptionMultiLineBox.SelectionStart = 0;
            this.DescriptionMultiLineBox.ShortcutsEnabled = true;
            this.DescriptionMultiLineBox.Size = new System.Drawing.Size(250, 100);
            this.DescriptionMultiLineBox.TabIndex = 25;
            this.DescriptionMultiLineBox.TabStop = false;
            this.DescriptionMultiLineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescriptionMultiLineBox.UseSystemPasswordChar = false;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.AnimateReadOnly = false;
            this.bookNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookNameTextBox.Depth = 0;
            this.bookNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookNameTextBox.Hint = "Book";
            this.bookNameTextBox.LeadingIcon = null;
            this.bookNameTextBox.Location = new System.Drawing.Point(68, 19);
            this.bookNameTextBox.MaxLength = 50;
            this.bookNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.bookNameTextBox.Multiline = false;
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(190, 50);
            this.bookNameTextBox.TabIndex = 15;
            this.bookNameTextBox.Text = "";
            this.bookNameTextBox.TrailingIcon = null;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.AutoResize = false;
            this.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LanguageComboBox.Depth = 0;
            this.LanguageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LanguageComboBox.DropDownHeight = 174;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.DropDownWidth = 121;
            this.LanguageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Hint = "Language";
            this.LanguageComboBox.IntegralHeight = false;
            this.LanguageComboBox.ItemHeight = 43;
            this.LanguageComboBox.Location = new System.Drawing.Point(506, 17);
            this.LanguageComboBox.MaxDropDownItems = 4;
            this.LanguageComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(190, 49);
            this.LanguageComboBox.StartIndex = 0;
            this.LanguageComboBox.TabIndex = 23;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton.Depth = 0;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(599, 252);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelButton.Size = new System.Drawing.Size(77, 36);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // OKBookButton
            // 
            this.OKBookButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKBookButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OKBookButton.Depth = 0;
            this.OKBookButton.HighEmphasis = true;
            this.OKBookButton.Icon = null;
            this.OKBookButton.Location = new System.Drawing.Point(599, 188);
            this.OKBookButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKBookButton.Name = "OKBookButton";
            this.OKBookButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OKBookButton.Size = new System.Drawing.Size(64, 36);
            this.OKBookButton.TabIndex = 19;
            this.OKBookButton.Text = "OK";
            this.OKBookButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKBookButton.UseAccentColor = false;
            this.OKBookButton.UseVisualStyleBackColor = true;
            this.OKBookButton.Click += new System.EventHandler(this.OKBookButton_Click);
            // 
            // PublisherComboBox
            // 
            this.PublisherComboBox.AutoResize = false;
            this.PublisherComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PublisherComboBox.Depth = 0;
            this.PublisherComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PublisherComboBox.DropDownHeight = 174;
            this.PublisherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublisherComboBox.DropDownWidth = 121;
            this.PublisherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PublisherComboBox.ForeColor = System.Drawing.Color.Transparent;
            this.PublisherComboBox.FormattingEnabled = true;
            this.PublisherComboBox.Hint = "Publisher";
            this.PublisherComboBox.IntegralHeight = false;
            this.PublisherComboBox.ItemHeight = 43;
            this.PublisherComboBox.Location = new System.Drawing.Point(283, 86);
            this.PublisherComboBox.MaxDropDownItems = 4;
            this.PublisherComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PublisherComboBox.Name = "PublisherComboBox";
            this.PublisherComboBox.Size = new System.Drawing.Size(190, 49);
            this.PublisherComboBox.StartIndex = 0;
            this.PublisherComboBox.TabIndex = 24;
            // 
            // GenreCheckBox
            // 
            this.GenreCheckBox.AutoScroll = true;
            this.GenreCheckBox.BackColor = System.Drawing.Color.White;
            this.GenreCheckBox.Depth = 0;
            this.GenreCheckBox.Location = new System.Drawing.Point(355, 188);
            this.GenreCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenreCheckBox.Name = "GenreCheckBox";
            this.GenreCheckBox.Size = new System.Drawing.Size(200, 100);
            this.GenreCheckBox.Striped = false;
            this.GenreCheckBox.StripeDarkColor = System.Drawing.Color.Empty;
            this.GenreCheckBox.TabIndex = 18;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.AnimateReadOnly = false;
            this.ISBNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ISBNTextBox.Depth = 0;
            this.ISBNTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ISBNTextBox.Hint = "ISBN";
            this.ISBNTextBox.LeadingIcon = null;
            this.ISBNTextBox.Location = new System.Drawing.Point(283, 18);
            this.ISBNTextBox.MaxLength = 50;
            this.ISBNTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ISBNTextBox.Multiline = false;
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(190, 50);
            this.ISBNTextBox.TabIndex = 16;
            this.ISBNTextBox.Text = "";
            this.ISBNTextBox.TrailingIcon = null;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.AutoResize = false;
            this.AuthorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthorComboBox.Depth = 0;
            this.AuthorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AuthorComboBox.DropDownHeight = 174;
            this.AuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorComboBox.DropDownWidth = 121;
            this.AuthorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AuthorComboBox.ForeColor = System.Drawing.Color.White;
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Hint = "Author";
            this.AuthorComboBox.IntegralHeight = false;
            this.AuthorComboBox.ItemHeight = 43;
            this.AuthorComboBox.Location = new System.Drawing.Point(68, 86);
            this.AuthorComboBox.MaxDropDownItems = 4;
            this.AuthorComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(190, 49);
            this.AuthorComboBox.StartIndex = 0;
            this.AuthorComboBox.TabIndex = 22;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.AnimateReadOnly = false;
            this.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTextBox.Depth = 0;
            this.AmountTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AmountTextBox.Hint = "Amount";
            this.AmountTextBox.LeadingIcon = null;
            this.AmountTextBox.Location = new System.Drawing.Point(506, 87);
            this.AmountTextBox.MaxLength = 50;
            this.AmountTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AmountTextBox.Multiline = false;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(190, 50);
            this.AmountTextBox.TabIndex = 17;
            this.AmountTextBox.Text = "";
            this.AmountTextBox.TrailingIcon = null;
            // 
            // AuthorTab
            // 
            this.AuthorTab.BackColor = System.Drawing.Color.White;
            this.AuthorTab.Controls.Add(this.disableDateOfDeathAuthorRadioButton);
            this.AuthorTab.Controls.Add(this.resetAuthorButton);
            this.AuthorTab.Controls.Add(this.UpdateAuthorButton);
            this.AuthorTab.Controls.Add(this.DeleteAuthorButton);
            this.AuthorTab.Controls.Add(this.AuthorsDataGrid);
            this.AuthorTab.Controls.Add(this.OKAuthorButton);
            this.AuthorTab.Controls.Add(this.materialLabel2);
            this.AuthorTab.Controls.Add(this.materialLabel1);
            this.AuthorTab.Controls.Add(this.DateOfDeathPicker);
            this.AuthorTab.Controls.Add(this.DateOfBirthPicker);
            this.AuthorTab.Controls.Add(this.BiographyMultiLineTextBox);
            this.AuthorTab.Controls.Add(this.CountryTextBox);
            this.AuthorTab.Controls.Add(this.AuthorNameTextBox);
            this.AuthorTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AuthorTab.ImageKey = "bookAuthor.png";
            this.AuthorTab.Location = new System.Drawing.Point(4, 23);
            this.AuthorTab.Name = "AuthorTab";
            this.AuthorTab.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorTab.Size = new System.Drawing.Size(791, 356);
            this.AuthorTab.TabIndex = 1;
            this.AuthorTab.Text = "AUTHOR";
            // 
            // disableDateOfDeathAuthorRadioButton
            // 
            this.disableDateOfDeathAuthorRadioButton.AutoSize = true;
            this.disableDateOfDeathAuthorRadioButton.Depth = 0;
            this.disableDateOfDeathAuthorRadioButton.Location = new System.Drawing.Point(16, 312);
            this.disableDateOfDeathAuthorRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.disableDateOfDeathAuthorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.disableDateOfDeathAuthorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.disableDateOfDeathAuthorRadioButton.Name = "disableDateOfDeathAuthorRadioButton";
            this.disableDateOfDeathAuthorRadioButton.Ripple = true;
            this.disableDateOfDeathAuthorRadioButton.Size = new System.Drawing.Size(190, 37);
            this.disableDateOfDeathAuthorRadioButton.TabIndex = 29;
            this.disableDateOfDeathAuthorRadioButton.TabStop = true;
            this.disableDateOfDeathAuthorRadioButton.Text = "Disable date of death.";
            this.disableDateOfDeathAuthorRadioButton.UseVisualStyleBackColor = true;
            this.disableDateOfDeathAuthorRadioButton.CheckedChanged += new System.EventHandler(this.disableDateOfDeathAuthorRadioButton_CheckedChanged);
            // 
            // resetAuthorButton
            // 
            this.resetAuthorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetAuthorButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetAuthorButton.Depth = 0;
            this.resetAuthorButton.HighEmphasis = true;
            this.resetAuthorButton.Icon = null;
            this.resetAuthorButton.Location = new System.Drawing.Point(601, 274);
            this.resetAuthorButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetAuthorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetAuthorButton.Name = "resetAuthorButton";
            this.resetAuthorButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetAuthorButton.Size = new System.Drawing.Size(65, 36);
            this.resetAuthorButton.TabIndex = 28;
            this.resetAuthorButton.Text = "RESET";
            this.resetAuthorButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetAuthorButton.UseAccentColor = false;
            this.resetAuthorButton.UseVisualStyleBackColor = true;
            this.resetAuthorButton.Click += new System.EventHandler(this.resetAuthorButton_Click);
            // 
            // UpdateAuthorButton
            // 
            this.UpdateAuthorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateAuthorButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateAuthorButton.Depth = 0;
            this.UpdateAuthorButton.HighEmphasis = true;
            this.UpdateAuthorButton.Icon = null;
            this.UpdateAuthorButton.Location = new System.Drawing.Point(593, 91);
            this.UpdateAuthorButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateAuthorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateAuthorButton.Name = "UpdateAuthorButton";
            this.UpdateAuthorButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateAuthorButton.Size = new System.Drawing.Size(77, 36);
            this.UpdateAuthorButton.TabIndex = 27;
            this.UpdateAuthorButton.Text = "UPDATE";
            this.UpdateAuthorButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateAuthorButton.UseAccentColor = false;
            this.UpdateAuthorButton.UseVisualStyleBackColor = true;
            this.UpdateAuthorButton.Click += new System.EventHandler(this.UpdateAuthorButton_Click);
            // 
            // DeleteAuthorButton
            // 
            this.DeleteAuthorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAuthorButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteAuthorButton.Depth = 0;
            this.DeleteAuthorButton.HighEmphasis = true;
            this.DeleteAuthorButton.Icon = null;
            this.DeleteAuthorButton.Location = new System.Drawing.Point(593, 19);
            this.DeleteAuthorButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteAuthorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteAuthorButton.Name = "DeleteAuthorButton";
            this.DeleteAuthorButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteAuthorButton.Size = new System.Drawing.Size(73, 36);
            this.DeleteAuthorButton.TabIndex = 26;
            this.DeleteAuthorButton.Text = "DELETE";
            this.DeleteAuthorButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteAuthorButton.UseAccentColor = false;
            this.DeleteAuthorButton.UseVisualStyleBackColor = true;
            this.DeleteAuthorButton.Click += new System.EventHandler(this.DeleteAuthorButton_Click);
            // 
            // AuthorsDataGrid
            // 
            this.AuthorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDataGrid.Location = new System.Drawing.Point(16, 3);
            this.AuthorsDataGrid.Name = "AuthorsDataGrid";
            this.AuthorsDataGrid.Size = new System.Drawing.Size(544, 135);
            this.AuthorsDataGrid.TabIndex = 25;
            this.AuthorsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsDataGrid_CellClick);
            // 
            // OKAuthorButton
            // 
            this.OKAuthorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKAuthorButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OKAuthorButton.Depth = 0;
            this.OKAuthorButton.HighEmphasis = true;
            this.OKAuthorButton.Icon = null;
            this.OKAuthorButton.Location = new System.Drawing.Point(458, 273);
            this.OKAuthorButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKAuthorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKAuthorButton.Name = "OKAuthorButton";
            this.OKAuthorButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OKAuthorButton.Size = new System.Drawing.Size(64, 36);
            this.OKAuthorButton.TabIndex = 24;
            this.OKAuthorButton.Text = "OK";
            this.OKAuthorButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKAuthorButton.UseAccentColor = false;
            this.OKAuthorButton.UseVisualStyleBackColor = true;
            this.OKAuthorButton.Click += new System.EventHandler(this.OKAuthorButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 290);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Date Of Death:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(24, 232);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Date Of Birth:";
            // 
            // DateOfDeathPicker
            // 
            this.DateOfDeathPicker.Location = new System.Drawing.Point(156, 289);
            this.DateOfDeathPicker.Name = "DateOfDeathPicker";
            this.DateOfDeathPicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfDeathPicker.TabIndex = 21;
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Location = new System.Drawing.Point(156, 232);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthPicker.TabIndex = 20;
            // 
            // BiographyMultiLineTextBox
            // 
            this.BiographyMultiLineTextBox.AnimateReadOnly = false;
            this.BiographyMultiLineTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BiographyMultiLineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BiographyMultiLineTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BiographyMultiLineTextBox.Depth = 0;
            this.BiographyMultiLineTextBox.HideSelection = true;
            this.BiographyMultiLineTextBox.Hint = "Biography";
            this.BiographyMultiLineTextBox.Location = new System.Drawing.Point(458, 156);
            this.BiographyMultiLineTextBox.MaxLength = 32767;
            this.BiographyMultiLineTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BiographyMultiLineTextBox.Name = "BiographyMultiLineTextBox";
            this.BiographyMultiLineTextBox.PasswordChar = '\0';
            this.BiographyMultiLineTextBox.ReadOnly = false;
            this.BiographyMultiLineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BiographyMultiLineTextBox.SelectedText = "";
            this.BiographyMultiLineTextBox.SelectionLength = 0;
            this.BiographyMultiLineTextBox.SelectionStart = 0;
            this.BiographyMultiLineTextBox.ShortcutsEnabled = true;
            this.BiographyMultiLineTextBox.Size = new System.Drawing.Size(212, 92);
            this.BiographyMultiLineTextBox.TabIndex = 19;
            this.BiographyMultiLineTextBox.TabStop = false;
            this.BiographyMultiLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BiographyMultiLineTextBox.UseSystemPasswordChar = false;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.AnimateReadOnly = false;
            this.CountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryTextBox.Depth = 0;
            this.CountryTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountryTextBox.Hint = "Country";
            this.CountryTextBox.LeadingIcon = null;
            this.CountryTextBox.Location = new System.Drawing.Point(238, 156);
            this.CountryTextBox.MaxLength = 50;
            this.CountryTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CountryTextBox.Multiline = false;
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(190, 50);
            this.CountryTextBox.TabIndex = 18;
            this.CountryTextBox.Text = "";
            this.CountryTextBox.TrailingIcon = null;
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.AnimateReadOnly = false;
            this.AuthorNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorNameTextBox.Depth = 0;
            this.AuthorNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AuthorNameTextBox.Hint = "Name";
            this.AuthorNameTextBox.LeadingIcon = null;
            this.AuthorNameTextBox.Location = new System.Drawing.Point(16, 156);
            this.AuthorNameTextBox.MaxLength = 50;
            this.AuthorNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AuthorNameTextBox.Multiline = false;
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(190, 50);
            this.AuthorNameTextBox.TabIndex = 16;
            this.AuthorNameTextBox.Text = "";
            this.AuthorNameTextBox.TrailingIcon = null;
            // 
            // bookIconTabControl
            // 
            this.bookIconTabControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bookIconTabControl.ImageStream")));
            this.bookIconTabControl.TransparentColor = System.Drawing.Color.Transparent;
            this.bookIconTabControl.Images.SetKeyName(0, "bookBook.png");
            this.bookIconTabControl.Images.SetKeyName(1, "bookAuthor.png");
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.materialTabControl1.ResumeLayout(false);
            this.BookTab.ResumeLayout(false);
            this.BookTab.PerformLayout();
            this.AuthorTab.ResumeLayout(false);
            this.AuthorTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage BookTab;
        private System.Windows.Forms.TabPage AuthorTab;
        private MaterialSkin.Controls.MaterialTextBox bookNameTextBox;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialButton OKBookButton;
        private MaterialSkin.Controls.MaterialComboBox PublisherComboBox;
        private MaterialSkin.Controls.MaterialCheckedListBox GenreCheckBox;
        private MaterialSkin.Controls.MaterialTextBox ISBNTextBox;
        private MaterialSkin.Controls.MaterialComboBox AuthorComboBox;
        private MaterialSkin.Controls.MaterialComboBox LanguageComboBox;
        private MaterialSkin.Controls.MaterialTextBox AmountTextBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescriptionMultiLineBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 BiographyMultiLineTextBox;
        private MaterialSkin.Controls.MaterialTextBox CountryTextBox;
        private MaterialSkin.Controls.MaterialTextBox AuthorNameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker DateOfDeathPicker;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private MaterialSkin.Controls.MaterialButton OKAuthorButton;
        private MaterialSkin.Controls.MaterialButton UpdateAuthorButton;
        private MaterialSkin.Controls.MaterialButton DeleteAuthorButton;
        private System.Windows.Forms.DataGridView AuthorsDataGrid;
        private MaterialSkin.Controls.MaterialButton resetAuthorButton;
        private MaterialSkin.Controls.MaterialRadioButton disableDateOfDeathAuthorRadioButton;
        private System.Windows.Forms.ImageList bookIconTabControl;
    }
}