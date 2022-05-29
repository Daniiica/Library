namespace Library.Presentation
{
    partial class UserHome
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
            this.rentalsTab = new System.Windows.Forms.TabPage();
            this.myRentalsDataGrid = new System.Windows.Forms.DataGridView();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.BookDataGrid = new System.Windows.Forms.DataGridView();
            this.AddReservationButton = new MaterialSkin.Controls.MaterialButton();
            this.isbnTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.saveToCsvButton = new MaterialSkin.Controls.MaterialButton();
            this.AddRaiting = new MaterialSkin.Controls.MaterialButton();
            this.assessmentTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.bookTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.userMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.changeProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.IndexNumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PhoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.LastNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.FirstNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.addWishBookTab = new System.Windows.Forms.TabPage();
            this.wishBookDataGrid = new System.Windows.Forms.DataGridView();
            this.addWishBookButton = new MaterialSkin.Controls.MaterialButton();
            this.wishAuthorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.wishISBNTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.wishBookTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.myReservationTab = new System.Windows.Forms.TabPage();
            this.myReservationDataGrid = new System.Windows.Forms.DataGridView();
            this.onlyActiveMyRentalsCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.rentalsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myRentalsDataGrid)).BeginInit();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).BeginInit();
            this.userMenu.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.addWishBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishBookDataGrid)).BeginInit();
            this.myReservationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myReservationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalsTab
            // 
            this.rentalsTab.BackColor = System.Drawing.Color.White;
            this.rentalsTab.Controls.Add(this.onlyActiveMyRentalsCheckBox);
            this.rentalsTab.Controls.Add(this.myRentalsDataGrid);
            this.rentalsTab.Location = new System.Drawing.Point(4, 25);
            this.rentalsTab.Name = "rentalsTab";
            this.rentalsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentalsTab.Size = new System.Drawing.Size(1133, 541);
            this.rentalsTab.TabIndex = 3;
            this.rentalsTab.Text = "RENTALS";
            this.rentalsTab.Click += new System.EventHandler(this.rentalsTab_Click);
            // 
            // myRentalsDataGrid
            // 
            this.myRentalsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myRentalsDataGrid.Location = new System.Drawing.Point(61, 22);
            this.myRentalsDataGrid.Name = "myRentalsDataGrid";
            this.myRentalsDataGrid.Size = new System.Drawing.Size(622, 203);
            this.myRentalsDataGrid.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.White;
            this.homeTab.Controls.Add(this.BookDataGrid);
            this.homeTab.Controls.Add(this.AddReservationButton);
            this.homeTab.Controls.Add(this.isbnTextBox);
            this.homeTab.Controls.Add(this.saveToCsvButton);
            this.homeTab.Controls.Add(this.AddRaiting);
            this.homeTab.Controls.Add(this.assessmentTextBox);
            this.homeTab.Controls.Add(this.bookTextBox);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1133, 541);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "HOME";
            // 
            // BookDataGrid
            // 
            this.BookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGrid.Location = new System.Drawing.Point(449, 20);
            this.BookDataGrid.Name = "BookDataGrid";
            this.BookDataGrid.Size = new System.Drawing.Size(502, 170);
            this.BookDataGrid.TabIndex = 14;
            this.BookDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDataGrid_CellClick);
            // 
            // AddReservationButton
            // 
            this.AddReservationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddReservationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddReservationButton.Depth = 0;
            this.AddReservationButton.HighEmphasis = true;
            this.AddReservationButton.Icon = null;
            this.AddReservationButton.Location = new System.Drawing.Point(800, 211);
            this.AddReservationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddReservationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddReservationButton.Name = "AddReservationButton";
            this.AddReservationButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddReservationButton.Size = new System.Drawing.Size(151, 36);
            this.AddReservationButton.TabIndex = 10;
            this.AddReservationButton.Text = "Add reservation";
            this.AddReservationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddReservationButton.UseAccentColor = false;
            this.AddReservationButton.UseVisualStyleBackColor = true;
            this.AddReservationButton.Click += new System.EventHandler(this.AddReservationButton_Click);
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.AnimateReadOnly = false;
            this.isbnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isbnTextBox.Depth = 0;
            this.isbnTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.isbnTextBox.Hint = "ISBN";
            this.isbnTextBox.LeadingIcon = null;
            this.isbnTextBox.Location = new System.Drawing.Point(319, 84);
            this.isbnTextBox.MaxLength = 50;
            this.isbnTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.isbnTextBox.Multiline = false;
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(100, 50);
            this.isbnTextBox.TabIndex = 9;
            this.isbnTextBox.Text = "";
            this.isbnTextBox.TrailingIcon = null;
            // 
            // saveToCsvButton
            // 
            this.saveToCsvButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveToCsvButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveToCsvButton.Depth = 0;
            this.saveToCsvButton.HighEmphasis = true;
            this.saveToCsvButton.Icon = null;
            this.saveToCsvButton.Location = new System.Drawing.Point(512, 256);
            this.saveToCsvButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveToCsvButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveToCsvButton.Name = "saveToCsvButton";
            this.saveToCsvButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveToCsvButton.Size = new System.Drawing.Size(112, 36);
            this.saveToCsvButton.TabIndex = 8;
            this.saveToCsvButton.Text = "Save To CSV";
            this.saveToCsvButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveToCsvButton.UseAccentColor = false;
            this.saveToCsvButton.UseVisualStyleBackColor = true;
            this.saveToCsvButton.Click += new System.EventHandler(this.saveToCsvButton_Click);
            // 
            // AddRaiting
            // 
            this.AddRaiting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddRaiting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddRaiting.Depth = 0;
            this.AddRaiting.HighEmphasis = true;
            this.AddRaiting.Icon = null;
            this.AddRaiting.Location = new System.Drawing.Point(319, 211);
            this.AddRaiting.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddRaiting.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddRaiting.Name = "AddRaiting";
            this.AddRaiting.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddRaiting.Size = new System.Drawing.Size(111, 36);
            this.AddRaiting.TabIndex = 3;
            this.AddRaiting.Text = "Add raiting";
            this.AddRaiting.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddRaiting.UseAccentColor = false;
            this.AddRaiting.UseVisualStyleBackColor = true;
            this.AddRaiting.Click += new System.EventHandler(this.AddRaiting_Click);
            // 
            // assessmentTextBox
            // 
            this.assessmentTextBox.AnimateReadOnly = false;
            this.assessmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assessmentTextBox.Depth = 0;
            this.assessmentTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.assessmentTextBox.Hint = "Raiting";
            this.assessmentTextBox.LeadingIcon = null;
            this.assessmentTextBox.Location = new System.Drawing.Point(319, 140);
            this.assessmentTextBox.MaxLength = 50;
            this.assessmentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.assessmentTextBox.Multiline = false;
            this.assessmentTextBox.Name = "assessmentTextBox";
            this.assessmentTextBox.Size = new System.Drawing.Size(100, 50);
            this.assessmentTextBox.TabIndex = 2;
            this.assessmentTextBox.Text = "";
            this.assessmentTextBox.TrailingIcon = null;
            // 
            // bookTextBox
            // 
            this.bookTextBox.AnimateReadOnly = false;
            this.bookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookTextBox.Depth = 0;
            this.bookTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookTextBox.Hint = "Book";
            this.bookTextBox.LeadingIcon = null;
            this.bookTextBox.Location = new System.Drawing.Point(319, 20);
            this.bookTextBox.MaxLength = 50;
            this.bookTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.bookTextBox.Multiline = false;
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.Size = new System.Drawing.Size(100, 50);
            this.bookTextBox.TabIndex = 0;
            this.bookTextBox.Text = "";
            this.bookTextBox.TrailingIcon = null;
            // 
            // userMenu
            // 
            this.userMenu.Controls.Add(this.homeTab);
            this.userMenu.Controls.Add(this.rentalsTab);
            this.userMenu.Controls.Add(this.profileTab);
            this.userMenu.Controls.Add(this.addWishBookTab);
            this.userMenu.Controls.Add(this.myReservationTab);
            this.userMenu.Depth = 0;
            this.userMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.userMenu.Location = new System.Drawing.Point(0, 64);
            this.userMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.userMenu.Multiline = true;
            this.userMenu.Name = "userMenu";
            this.userMenu.SelectedIndex = 0;
            this.userMenu.Size = new System.Drawing.Size(1141, 570);
            this.userMenu.TabIndex = 0;
            // 
            // profileTab
            // 
            this.profileTab.BackColor = System.Drawing.Color.White;
            this.profileTab.Controls.Add(this.changeProfileButton);
            this.profileTab.Controls.Add(this.IndexNumberTextBox);
            this.profileTab.Controls.Add(this.EmailTextBox);
            this.profileTab.Controls.Add(this.PhoneTextBox);
            this.profileTab.Controls.Add(this.LastNameTextBox);
            this.profileTab.Controls.Add(this.FirstNameTextBox);
            this.profileTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profileTab.Location = new System.Drawing.Point(4, 25);
            this.profileTab.Name = "profileTab";
            this.profileTab.Size = new System.Drawing.Size(1133, 541);
            this.profileTab.TabIndex = 4;
            this.profileTab.Text = "PROFILE";
            // 
            // changeProfileButton
            // 
            this.changeProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.changeProfileButton.Depth = 0;
            this.changeProfileButton.HighEmphasis = true;
            this.changeProfileButton.Icon = null;
            this.changeProfileButton.Location = new System.Drawing.Point(604, 265);
            this.changeProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeProfileButton.Name = "changeProfileButton";
            this.changeProfileButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.changeProfileButton.Size = new System.Drawing.Size(129, 36);
            this.changeProfileButton.TabIndex = 5;
            this.changeProfileButton.Text = "Save Changes";
            this.changeProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.changeProfileButton.UseAccentColor = false;
            this.changeProfileButton.UseVisualStyleBackColor = true;
            this.changeProfileButton.Click += new System.EventHandler(this.changeProfileButton_Click);
            // 
            // IndexNumberTextBox
            // 
            this.IndexNumberTextBox.AnimateReadOnly = false;
            this.IndexNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndexNumberTextBox.Depth = 0;
            this.IndexNumberTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IndexNumberTextBox.Hint = "Index Number";
            this.IndexNumberTextBox.LeadingIcon = null;
            this.IndexNumberTextBox.Location = new System.Drawing.Point(599, 106);
            this.IndexNumberTextBox.MaxLength = 50;
            this.IndexNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.IndexNumberTextBox.Multiline = false;
            this.IndexNumberTextBox.Name = "IndexNumberTextBox";
            this.IndexNumberTextBox.Size = new System.Drawing.Size(134, 50);
            this.IndexNumberTextBox.TabIndex = 4;
            this.IndexNumberTextBox.Text = "";
            this.IndexNumberTextBox.TrailingIcon = null;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AnimateReadOnly = false;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Depth = 0;
            this.EmailTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailTextBox.Hint = "Email";
            this.EmailTextBox.LeadingIcon = null;
            this.EmailTextBox.Location = new System.Drawing.Point(599, 25);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(134, 50);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.TrailingIcon = null;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.AnimateReadOnly = false;
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Depth = 0;
            this.PhoneTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PhoneTextBox.Hint = "Phone";
            this.PhoneTextBox.LeadingIcon = null;
            this.PhoneTextBox.Location = new System.Drawing.Point(368, 184);
            this.PhoneTextBox.MaxLength = 50;
            this.PhoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PhoneTextBox.Multiline = false;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(134, 50);
            this.PhoneTextBox.TabIndex = 2;
            this.PhoneTextBox.Text = "";
            this.PhoneTextBox.TrailingIcon = null;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.AnimateReadOnly = false;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTextBox.Depth = 0;
            this.LastNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LastNameTextBox.Hint = "Last Name";
            this.LastNameTextBox.LeadingIcon = null;
            this.LastNameTextBox.Location = new System.Drawing.Point(368, 106);
            this.LastNameTextBox.MaxLength = 50;
            this.LastNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LastNameTextBox.Multiline = false;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(134, 50);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Text = "";
            this.LastNameTextBox.TrailingIcon = null;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.AnimateReadOnly = false;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTextBox.Depth = 0;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FirstNameTextBox.Hint = "First Name";
            this.FirstNameTextBox.LeadingIcon = null;
            this.FirstNameTextBox.Location = new System.Drawing.Point(368, 25);
            this.FirstNameTextBox.MaxLength = 50;
            this.FirstNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FirstNameTextBox.Multiline = false;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(134, 50);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Text = "";
            this.FirstNameTextBox.TrailingIcon = null;
            // 
            // addWishBookTab
            // 
            this.addWishBookTab.BackColor = System.Drawing.Color.White;
            this.addWishBookTab.Controls.Add(this.wishBookDataGrid);
            this.addWishBookTab.Controls.Add(this.addWishBookButton);
            this.addWishBookTab.Controls.Add(this.wishAuthorTextBox);
            this.addWishBookTab.Controls.Add(this.wishISBNTextBox);
            this.addWishBookTab.Controls.Add(this.wishBookTextBox);
            this.addWishBookTab.Location = new System.Drawing.Point(4, 25);
            this.addWishBookTab.Name = "addWishBookTab";
            this.addWishBookTab.Size = new System.Drawing.Size(1133, 541);
            this.addWishBookTab.TabIndex = 5;
            this.addWishBookTab.Text = "WISH BOOK";
            // 
            // wishBookDataGrid
            // 
            this.wishBookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wishBookDataGrid.Location = new System.Drawing.Point(269, 122);
            this.wishBookDataGrid.Name = "wishBookDataGrid";
            this.wishBookDataGrid.Size = new System.Drawing.Size(630, 195);
            this.wishBookDataGrid.TabIndex = 4;
            // 
            // addWishBookButton
            // 
            this.addWishBookButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addWishBookButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addWishBookButton.Depth = 0;
            this.addWishBookButton.HighEmphasis = true;
            this.addWishBookButton.Icon = null;
            this.addWishBookButton.Location = new System.Drawing.Point(777, 31);
            this.addWishBookButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addWishBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addWishBookButton.Name = "addWishBookButton";
            this.addWishBookButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addWishBookButton.Size = new System.Drawing.Size(133, 36);
            this.addWishBookButton.TabIndex = 3;
            this.addWishBookButton.Text = "Add Wish Book";
            this.addWishBookButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addWishBookButton.UseAccentColor = false;
            this.addWishBookButton.UseVisualStyleBackColor = true;
            this.addWishBookButton.Click += new System.EventHandler(this.addWishBookButton_Click);
            // 
            // wishAuthorTextBox
            // 
            this.wishAuthorTextBox.AnimateReadOnly = false;
            this.wishAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wishAuthorTextBox.Depth = 0;
            this.wishAuthorTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wishAuthorTextBox.Hint = "Author";
            this.wishAuthorTextBox.LeadingIcon = null;
            this.wishAuthorTextBox.Location = new System.Drawing.Point(566, 17);
            this.wishAuthorTextBox.MaxLength = 50;
            this.wishAuthorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.wishAuthorTextBox.Multiline = false;
            this.wishAuthorTextBox.Name = "wishAuthorTextBox";
            this.wishAuthorTextBox.Size = new System.Drawing.Size(100, 50);
            this.wishAuthorTextBox.TabIndex = 2;
            this.wishAuthorTextBox.Text = "";
            this.wishAuthorTextBox.TrailingIcon = null;
            // 
            // wishISBNTextBox
            // 
            this.wishISBNTextBox.AnimateReadOnly = false;
            this.wishISBNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wishISBNTextBox.Depth = 0;
            this.wishISBNTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wishISBNTextBox.Hint = "ISBN";
            this.wishISBNTextBox.LeadingIcon = null;
            this.wishISBNTextBox.Location = new System.Drawing.Point(415, 17);
            this.wishISBNTextBox.MaxLength = 50;
            this.wishISBNTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.wishISBNTextBox.Multiline = false;
            this.wishISBNTextBox.Name = "wishISBNTextBox";
            this.wishISBNTextBox.Size = new System.Drawing.Size(100, 50);
            this.wishISBNTextBox.TabIndex = 1;
            this.wishISBNTextBox.Text = "";
            this.wishISBNTextBox.TrailingIcon = null;
            // 
            // wishBookTextBox
            // 
            this.wishBookTextBox.AnimateReadOnly = false;
            this.wishBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wishBookTextBox.Depth = 0;
            this.wishBookTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wishBookTextBox.Hint = "Book";
            this.wishBookTextBox.LeadingIcon = null;
            this.wishBookTextBox.Location = new System.Drawing.Point(269, 17);
            this.wishBookTextBox.MaxLength = 50;
            this.wishBookTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.wishBookTextBox.Multiline = false;
            this.wishBookTextBox.Name = "wishBookTextBox";
            this.wishBookTextBox.Size = new System.Drawing.Size(100, 50);
            this.wishBookTextBox.TabIndex = 0;
            this.wishBookTextBox.Text = "";
            this.wishBookTextBox.TrailingIcon = null;
            // 
            // myReservationTab
            // 
            this.myReservationTab.Controls.Add(this.myReservationDataGrid);
            this.myReservationTab.Location = new System.Drawing.Point(4, 25);
            this.myReservationTab.Name = "myReservationTab";
            this.myReservationTab.Size = new System.Drawing.Size(1133, 541);
            this.myReservationTab.TabIndex = 6;
            this.myReservationTab.Text = "MY RESERVATION";
            this.myReservationTab.UseVisualStyleBackColor = true;
            // 
            // myReservationDataGrid
            // 
            this.myReservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myReservationDataGrid.Location = new System.Drawing.Point(269, 60);
            this.myReservationDataGrid.Name = "myReservationDataGrid";
            this.myReservationDataGrid.Size = new System.Drawing.Size(653, 214);
            this.myReservationDataGrid.TabIndex = 0;
            // 
            // onlyActiveMyRentalsCheckBox
            // 
            this.onlyActiveMyRentalsCheckBox.AutoSize = true;
            this.onlyActiveMyRentalsCheckBox.Depth = 0;
            this.onlyActiveMyRentalsCheckBox.Location = new System.Drawing.Point(61, 253);
            this.onlyActiveMyRentalsCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.onlyActiveMyRentalsCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.onlyActiveMyRentalsCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.onlyActiveMyRentalsCheckBox.Name = "onlyActiveMyRentalsCheckBox";
            this.onlyActiveMyRentalsCheckBox.ReadOnly = false;
            this.onlyActiveMyRentalsCheckBox.Ripple = true;
            this.onlyActiveMyRentalsCheckBox.Size = new System.Drawing.Size(165, 37);
            this.onlyActiveMyRentalsCheckBox.TabIndex = 26;
            this.onlyActiveMyRentalsCheckBox.Text = "Only active rentals";
            this.onlyActiveMyRentalsCheckBox.UseVisualStyleBackColor = true;
            this.onlyActiveMyRentalsCheckBox.CheckedChanged += new System.EventHandler(this.onlyActiveMyRentalsCheckBox_CheckedChanged);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 638);
            this.Controls.Add(this.userMenu);
            this.DrawerAutoHide = false;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.userMenu;
            this.DrawerWidth = 250;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserHome";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRARY";
            this.rentalsTab.ResumeLayout(false);
            this.rentalsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myRentalsDataGrid)).EndInit();
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).EndInit();
            this.userMenu.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            this.addWishBookTab.ResumeLayout(false);
            this.addWishBookTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishBookDataGrid)).EndInit();
            this.myReservationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myReservationDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage rentalsTab;
        private System.Windows.Forms.TabPage homeTab;
        private MaterialSkin.Controls.MaterialTabControl userMenu;
        private System.Windows.Forms.TabPage profileTab;
        private MaterialSkin.Controls.MaterialTextBox bookTextBox;
        private MaterialSkin.Controls.MaterialTextBox assessmentTextBox;
        private MaterialSkin.Controls.MaterialButton AddRaiting;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednjaOcenaDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton saveToCsvButton;
        private MaterialSkin.Controls.MaterialTextBox isbnTextBox;
        private System.Windows.Forms.TabPage addWishBookTab;
        private MaterialSkin.Controls.MaterialTextBox wishAuthorTextBox;
        private MaterialSkin.Controls.MaterialTextBox wishISBNTextBox;
        private MaterialSkin.Controls.MaterialTextBox wishBookTextBox;
        private MaterialSkin.Controls.MaterialButton addWishBookButton;
        private MaterialSkin.Controls.MaterialTextBox LastNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox FirstNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox EmailTextBox;
        private MaterialSkin.Controls.MaterialTextBox PhoneTextBox;
        private MaterialSkin.Controls.MaterialTextBox IndexNumberTextBox;
        private MaterialSkin.Controls.MaterialButton changeProfileButton;
        private MaterialSkin.Controls.MaterialButton AddReservationButton;
        private System.Windows.Forms.DataGridView BookDataGrid;
        private System.Windows.Forms.DataGridView wishBookDataGrid;
        private System.Windows.Forms.TabPage myReservationTab;
        private System.Windows.Forms.DataGridView myReservationDataGrid;
        private System.Windows.Forms.DataGridView myRentalsDataGrid;
        private MaterialSkin.Controls.MaterialCheckbox onlyActiveMyRentalsCheckBox;
    }
}