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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.rentalsTab = new System.Windows.Forms.TabPage();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.onlyActiveMyRentalsCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.myRentalsDataGrid = new System.Windows.Forms.DataGridView();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.topRatingBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.ISBNAddRatingComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.bookAddRatingComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AddRaiting = new MaterialSkin.Controls.MaterialButton();
            this.assessmentTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.userMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.IndexNumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PhoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.LastNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.FirstNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.addWishBookTab = new System.Windows.Forms.TabPage();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.wishBookDataGrid = new System.Windows.Forms.DataGridView();
            this.addWishBookButton = new MaterialSkin.Controls.MaterialButton();
            this.wishAuthorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.wishISBNTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.wishBookTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.myReservationTab = new System.Windows.Forms.TabPage();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BookDataGrid = new System.Windows.Forms.DataGridView();
            this.AddReservationButton = new MaterialSkin.Controls.MaterialButton();
            this.saveToCsvReservation = new MaterialSkin.Controls.MaterialButton();
            this.myReservationDataGrid = new System.Windows.Forms.DataGridView();
            this.userIconTabControl = new System.Windows.Forms.ImageList(this.components);
            this.rentalsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myRentalsDataGrid)).BeginInit();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRatingBooksDataGrid)).BeginInit();
            this.userMenu.SuspendLayout();
            this.profileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addWishBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishBookDataGrid)).BeginInit();
            this.myReservationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myReservationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalsTab
            // 
            this.rentalsTab.BackColor = System.Drawing.Color.White;
            this.rentalsTab.Controls.Add(this.materialDivider2);
            this.rentalsTab.Controls.Add(this.materialLabel5);
            this.rentalsTab.Controls.Add(this.onlyActiveMyRentalsCheckBox);
            this.rentalsTab.Controls.Add(this.myRentalsDataGrid);
            this.rentalsTab.ImageKey = "userRental.png";
            this.rentalsTab.Location = new System.Drawing.Point(4, 31);
            this.rentalsTab.Name = "rentalsTab";
            this.rentalsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentalsTab.Size = new System.Drawing.Size(1224, 476);
            this.rentalsTab.TabIndex = 3;
            this.rentalsTab.Text = "RENTALS";
            this.rentalsTab.Click += new System.EventHandler(this.rentalsTab_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(36, 416);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(720, 1);
            this.materialDivider2.TabIndex = 32;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.DarkRed;
            this.materialLabel5.Location = new System.Drawing.Point(10, 434);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(428, 19);
            this.materialLabel5.TabIndex = 28;
            this.materialLabel5.Text = "Rentals dashboard gives you information about your rentals.";
            // 
            // onlyActiveMyRentalsCheckBox
            // 
            this.onlyActiveMyRentalsCheckBox.AutoSize = true;
            this.onlyActiveMyRentalsCheckBox.Depth = 0;
            this.onlyActiveMyRentalsCheckBox.Location = new System.Drawing.Point(158, 264);
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
            // myRentalsDataGrid
            // 
            this.myRentalsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myRentalsDataGrid.Location = new System.Drawing.Point(158, 33);
            this.myRentalsDataGrid.Name = "myRentalsDataGrid";
            this.myRentalsDataGrid.Size = new System.Drawing.Size(531, 203);
            this.myRentalsDataGrid.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.AutoScroll = true;
            this.homeTab.BackColor = System.Drawing.Color.White;
            this.homeTab.Controls.Add(this.materialDivider1);
            this.homeTab.Controls.Add(this.topRatingBooksDataGrid);
            this.homeTab.Controls.Add(this.materialLabel9);
            this.homeTab.Controls.Add(this.ISBNAddRatingComboBox);
            this.homeTab.Controls.Add(this.bookAddRatingComboBox);
            this.homeTab.Controls.Add(this.materialLabel1);
            this.homeTab.Controls.Add(this.AddRaiting);
            this.homeTab.Controls.Add(this.assessmentTextBox);
            this.homeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTab.ImageKey = "userHome.png";
            this.homeTab.Location = new System.Drawing.Point(4, 31);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1224, 515);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "HOME";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(36, 416);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(720, 1);
            this.materialDivider1.TabIndex = 31;
            // 
            // topRatingBooksDataGrid
            // 
            this.topRatingBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topRatingBooksDataGrid.Location = new System.Drawing.Point(159, 217);
            this.topRatingBooksDataGrid.Name = "topRatingBooksDataGrid";
            this.topRatingBooksDataGrid.Size = new System.Drawing.Size(635, 193);
            this.topRatingBooksDataGrid.TabIndex = 30;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.DarkRed;
            this.materialLabel9.Location = new System.Drawing.Point(10, 434);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(539, 19);
            this.materialLabel9.TabIndex = 29;
            this.materialLabel9.Text = "On the home dashboard you can rate some book and see 5 top rating books.";
            // 
            // ISBNAddRatingComboBox
            // 
            this.ISBNAddRatingComboBox.AutoResize = false;
            this.ISBNAddRatingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ISBNAddRatingComboBox.Depth = 0;
            this.ISBNAddRatingComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ISBNAddRatingComboBox.DropDownHeight = 174;
            this.ISBNAddRatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISBNAddRatingComboBox.DropDownWidth = 121;
            this.ISBNAddRatingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ISBNAddRatingComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ISBNAddRatingComboBox.FormattingEnabled = true;
            this.ISBNAddRatingComboBox.Hint = "ISBN";
            this.ISBNAddRatingComboBox.IntegralHeight = false;
            this.ISBNAddRatingComboBox.ItemHeight = 43;
            this.ISBNAddRatingComboBox.Location = new System.Drawing.Point(299, 45);
            this.ISBNAddRatingComboBox.MaxDropDownItems = 4;
            this.ISBNAddRatingComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ISBNAddRatingComboBox.Name = "ISBNAddRatingComboBox";
            this.ISBNAddRatingComboBox.Size = new System.Drawing.Size(206, 49);
            this.ISBNAddRatingComboBox.StartIndex = 0;
            this.ISBNAddRatingComboBox.TabIndex = 18;
            // 
            // bookAddRatingComboBox
            // 
            this.bookAddRatingComboBox.AutoResize = false;
            this.bookAddRatingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookAddRatingComboBox.Depth = 0;
            this.bookAddRatingComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bookAddRatingComboBox.DropDownHeight = 174;
            this.bookAddRatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookAddRatingComboBox.DropDownWidth = 121;
            this.bookAddRatingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bookAddRatingComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookAddRatingComboBox.FormattingEnabled = true;
            this.bookAddRatingComboBox.Hint = "Book";
            this.bookAddRatingComboBox.IntegralHeight = false;
            this.bookAddRatingComboBox.ItemHeight = 43;
            this.bookAddRatingComboBox.Location = new System.Drawing.Point(13, 45);
            this.bookAddRatingComboBox.MaxDropDownItems = 4;
            this.bookAddRatingComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.bookAddRatingComboBox.Name = "bookAddRatingComboBox";
            this.bookAddRatingComboBox.Size = new System.Drawing.Size(209, 49);
            this.bookAddRatingComboBox.StartIndex = 0;
            this.bookAddRatingComboBox.TabIndex = 17;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(10, 217);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Top 5 raiting Books:";
            // 
            // AddRaiting
            // 
            this.AddRaiting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddRaiting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddRaiting.Depth = 0;
            this.AddRaiting.HighEmphasis = true;
            this.AddRaiting.Icon = null;
            this.AddRaiting.Location = new System.Drawing.Point(683, 141);
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
            this.assessmentTextBox.Location = new System.Drawing.Point(585, 44);
            this.assessmentTextBox.MaxLength = 50;
            this.assessmentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.assessmentTextBox.Multiline = false;
            this.assessmentTextBox.Name = "assessmentTextBox";
            this.assessmentTextBox.Size = new System.Drawing.Size(209, 50);
            this.assessmentTextBox.TabIndex = 2;
            this.assessmentTextBox.Text = "";
            this.assessmentTextBox.TrailingIcon = null;
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
            this.userMenu.ImageList = this.userIconTabControl;
            this.userMenu.Location = new System.Drawing.Point(0, 64);
            this.userMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.userMenu.Multiline = true;
            this.userMenu.Name = "userMenu";
            this.userMenu.SelectedIndex = 0;
            this.userMenu.Size = new System.Drawing.Size(1232, 550);
            this.userMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.userMenu.TabIndex = 0;
            // 
            // profileTab
            // 
            this.profileTab.BackColor = System.Drawing.Color.White;
            this.profileTab.Controls.Add(this.materialDivider5);
            this.profileTab.Controls.Add(this.materialLabel6);
            this.profileTab.Controls.Add(this.pictureBox1);
            this.profileTab.Controls.Add(this.changeProfileButton);
            this.profileTab.Controls.Add(this.IndexNumberTextBox);
            this.profileTab.Controls.Add(this.EmailTextBox);
            this.profileTab.Controls.Add(this.PhoneTextBox);
            this.profileTab.Controls.Add(this.LastNameTextBox);
            this.profileTab.Controls.Add(this.FirstNameTextBox);
            this.profileTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profileTab.ImageKey = "userProfile.png";
            this.profileTab.Location = new System.Drawing.Point(4, 31);
            this.profileTab.Name = "profileTab";
            this.profileTab.Size = new System.Drawing.Size(1224, 476);
            this.profileTab.TabIndex = 4;
            this.profileTab.Text = "PROFILE";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(32, 413);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(410, 1);
            this.materialDivider5.TabIndex = 30;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.DarkRed;
            this.materialLabel6.Location = new System.Drawing.Point(3, 433);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(488, 19);
            this.materialLabel6.TabIndex = 29;
            this.materialLabel6.Text = "Profile dashboard gives you the opportunity to change personal data.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Presentation.Properties.Resources.books_933293_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(497, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // changeProfileButton
            // 
            this.changeProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.changeProfileButton.Depth = 0;
            this.changeProfileButton.HighEmphasis = true;
            this.changeProfileButton.Icon = null;
            this.changeProfileButton.Location = new System.Drawing.Point(161, 368);
            this.changeProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeProfileButton.Name = "changeProfileButton";
            this.changeProfileButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.changeProfileButton.Size = new System.Drawing.Size(129, 36);
            this.changeProfileButton.TabIndex = 5;
            this.changeProfileButton.Tag = "5";
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
            this.IndexNumberTextBox.Location = new System.Drawing.Point(127, 296);
            this.IndexNumberTextBox.MaxLength = 50;
            this.IndexNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.IndexNumberTextBox.Multiline = false;
            this.IndexNumberTextBox.Name = "IndexNumberTextBox";
            this.IndexNumberTextBox.Size = new System.Drawing.Size(204, 50);
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
            this.EmailTextBox.Location = new System.Drawing.Point(127, 226);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(204, 50);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Tag = "4";
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
            this.PhoneTextBox.Location = new System.Drawing.Point(127, 155);
            this.PhoneTextBox.MaxLength = 50;
            this.PhoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PhoneTextBox.Multiline = false;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(204, 50);
            this.PhoneTextBox.TabIndex = 2;
            this.PhoneTextBox.Tag = "3";
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
            this.LastNameTextBox.Location = new System.Drawing.Point(127, 85);
            this.LastNameTextBox.MaxLength = 50;
            this.LastNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LastNameTextBox.Multiline = false;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(204, 50);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Tag = "2";
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
            this.FirstNameTextBox.Location = new System.Drawing.Point(127, 13);
            this.FirstNameTextBox.MaxLength = 50;
            this.FirstNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FirstNameTextBox.Multiline = false;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(204, 50);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Tag = "1";
            this.FirstNameTextBox.Text = "";
            this.FirstNameTextBox.TrailingIcon = null;
            // 
            // addWishBookTab
            // 
            this.addWishBookTab.BackColor = System.Drawing.Color.White;
            this.addWishBookTab.Controls.Add(this.materialDivider3);
            this.addWishBookTab.Controls.Add(this.materialLabel7);
            this.addWishBookTab.Controls.Add(this.materialLabel2);
            this.addWishBookTab.Controls.Add(this.wishBookDataGrid);
            this.addWishBookTab.Controls.Add(this.addWishBookButton);
            this.addWishBookTab.Controls.Add(this.wishAuthorTextBox);
            this.addWishBookTab.Controls.Add(this.wishISBNTextBox);
            this.addWishBookTab.Controls.Add(this.wishBookTextBox);
            this.addWishBookTab.ImageKey = "userWishbook.png";
            this.addWishBookTab.Location = new System.Drawing.Point(4, 31);
            this.addWishBookTab.Name = "addWishBookTab";
            this.addWishBookTab.Size = new System.Drawing.Size(1224, 476);
            this.addWishBookTab.TabIndex = 5;
            this.addWishBookTab.Text = "WISH BOOK";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(36, 416);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(720, 1);
            this.materialDivider3.TabIndex = 33;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.DarkRed;
            this.materialLabel7.Location = new System.Drawing.Point(10, 434);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(588, 19);
            this.materialLabel7.TabIndex = 30;
            this.materialLabel7.Text = "Wish book dashboard gives you the option to submit a request to order a new book." +
    "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(10, 215);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "My wish books:";
            // 
            // wishBookDataGrid
            // 
            this.wishBookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wishBookDataGrid.Location = new System.Drawing.Point(162, 215);
            this.wishBookDataGrid.Name = "wishBookDataGrid";
            this.wishBookDataGrid.Size = new System.Drawing.Size(562, 195);
            this.wishBookDataGrid.TabIndex = 4;
            // 
            // addWishBookButton
            // 
            this.addWishBookButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addWishBookButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addWishBookButton.Depth = 0;
            this.addWishBookButton.HighEmphasis = true;
            this.addWishBookButton.Icon = null;
            this.addWishBookButton.Location = new System.Drawing.Point(591, 139);
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
            this.wishAuthorTextBox.Location = new System.Drawing.Point(280, 38);
            this.wishAuthorTextBox.MaxLength = 50;
            this.wishAuthorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.wishAuthorTextBox.Multiline = false;
            this.wishAuthorTextBox.Name = "wishAuthorTextBox";
            this.wishAuthorTextBox.Size = new System.Drawing.Size(190, 50);
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
            this.wishISBNTextBox.Location = new System.Drawing.Point(534, 38);
            this.wishISBNTextBox.MaxLength = 50;
            this.wishISBNTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.wishISBNTextBox.Multiline = false;
            this.wishISBNTextBox.Name = "wishISBNTextBox";
            this.wishISBNTextBox.Size = new System.Drawing.Size(190, 50);
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
            this.wishBookTextBox.Location = new System.Drawing.Point(13, 38);
            this.wishBookTextBox.MaxLength = 50;
            this.wishBookTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.wishBookTextBox.Multiline = false;
            this.wishBookTextBox.Name = "wishBookTextBox";
            this.wishBookTextBox.Size = new System.Drawing.Size(190, 50);
            this.wishBookTextBox.TabIndex = 0;
            this.wishBookTextBox.Text = "";
            this.wishBookTextBox.TrailingIcon = null;
            // 
            // myReservationTab
            // 
            this.myReservationTab.BackColor = System.Drawing.Color.White;
            this.myReservationTab.Controls.Add(this.materialDivider4);
            this.myReservationTab.Controls.Add(this.materialLabel8);
            this.myReservationTab.Controls.Add(this.materialLabel4);
            this.myReservationTab.Controls.Add(this.materialLabel3);
            this.myReservationTab.Controls.Add(this.BookDataGrid);
            this.myReservationTab.Controls.Add(this.AddReservationButton);
            this.myReservationTab.Controls.Add(this.saveToCsvReservation);
            this.myReservationTab.Controls.Add(this.myReservationDataGrid);
            this.myReservationTab.ImageKey = "userReservation.png";
            this.myReservationTab.Location = new System.Drawing.Point(4, 31);
            this.myReservationTab.Name = "myReservationTab";
            this.myReservationTab.Size = new System.Drawing.Size(1224, 476);
            this.myReservationTab.TabIndex = 6;
            this.myReservationTab.Text = "RESERVATION";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(36, 416);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(720, 1);
            this.materialDivider4.TabIndex = 34;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.DarkRed;
            this.materialLabel8.Location = new System.Drawing.Point(10, 434);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(607, 19);
            this.materialLabel8.TabIndex = 31;
            this.materialLabel8.Text = "Reservation dashboard gives you option to reserve book and view all you reservati" +
    "ons.";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(3, 205);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(117, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "My reservations:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(50, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "All books:";
            // 
            // BookDataGrid
            // 
            this.BookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGrid.Location = new System.Drawing.Point(126, 14);
            this.BookDataGrid.Name = "BookDataGrid";
            this.BookDataGrid.Size = new System.Drawing.Size(543, 170);
            this.BookDataGrid.TabIndex = 17;
            this.BookDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDataGrid_CellClick);
            // 
            // AddReservationButton
            // 
            this.AddReservationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddReservationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddReservationButton.Depth = 0;
            this.AddReservationButton.HighEmphasis = true;
            this.AddReservationButton.Icon = null;
            this.AddReservationButton.Location = new System.Drawing.Point(688, 69);
            this.AddReservationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddReservationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddReservationButton.Name = "AddReservationButton";
            this.AddReservationButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddReservationButton.Size = new System.Drawing.Size(151, 36);
            this.AddReservationButton.TabIndex = 16;
            this.AddReservationButton.Text = "Add reservation";
            this.AddReservationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddReservationButton.UseAccentColor = false;
            this.AddReservationButton.UseVisualStyleBackColor = true;
            this.AddReservationButton.Click += new System.EventHandler(this.AddReservationButton_Click);
            // 
            // saveToCsvReservation
            // 
            this.saveToCsvReservation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveToCsvReservation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveToCsvReservation.Depth = 0;
            this.saveToCsvReservation.HighEmphasis = true;
            this.saveToCsvReservation.Icon = null;
            this.saveToCsvReservation.Location = new System.Drawing.Point(688, 117);
            this.saveToCsvReservation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveToCsvReservation.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveToCsvReservation.Name = "saveToCsvReservation";
            this.saveToCsvReservation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveToCsvReservation.Size = new System.Drawing.Size(112, 36);
            this.saveToCsvReservation.TabIndex = 15;
            this.saveToCsvReservation.Text = "Save To CSV";
            this.saveToCsvReservation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveToCsvReservation.UseAccentColor = false;
            this.saveToCsvReservation.UseVisualStyleBackColor = true;
            this.saveToCsvReservation.Click += new System.EventHandler(this.saveToCsvReservation_Click);
            // 
            // myReservationDataGrid
            // 
            this.myReservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myReservationDataGrid.Location = new System.Drawing.Point(126, 205);
            this.myReservationDataGrid.Name = "myReservationDataGrid";
            this.myReservationDataGrid.Size = new System.Drawing.Size(543, 191);
            this.myReservationDataGrid.TabIndex = 0;
            // 
            // userIconTabControl
            // 
            this.userIconTabControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("userIconTabControl.ImageStream")));
            this.userIconTabControl.TransparentColor = System.Drawing.Color.Transparent;
            this.userIconTabControl.Images.SetKeyName(0, "userHome.png");
            this.userIconTabControl.Images.SetKeyName(1, "userRental.png");
            this.userIconTabControl.Images.SetKeyName(2, "userProfile.png");
            this.userIconTabControl.Images.SetKeyName(3, "userWishbook.png");
            this.userIconTabControl.Images.SetKeyName(4, "userReservation.png");
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 618);
            this.Controls.Add(this.userMenu);
            this.DrawerAutoHide = false;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.userMenu;
            this.DrawerWidth = 250;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.topRatingBooksDataGrid)).EndInit();
            this.userMenu.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addWishBookTab.ResumeLayout(false);
            this.addWishBookTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishBookDataGrid)).EndInit();
            this.myReservationTab.ResumeLayout(false);
            this.myReservationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myReservationDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage rentalsTab;
        private System.Windows.Forms.TabPage profileTab;
        private MaterialSkin.Controls.MaterialTextBox assessmentTextBox;
        private MaterialSkin.Controls.MaterialButton AddRaiting;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednjaOcenaDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridView wishBookDataGrid;
        private System.Windows.Forms.TabPage myReservationTab;
        private System.Windows.Forms.DataGridView myReservationDataGrid;
        private System.Windows.Forms.DataGridView myRentalsDataGrid;
        private MaterialSkin.Controls.MaterialCheckbox onlyActiveMyRentalsCheckBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView BookDataGrid;
        private MaterialSkin.Controls.MaterialButton AddReservationButton;
        private MaterialSkin.Controls.MaterialButton saveToCsvReservation;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox ISBNAddRatingComboBox;
        private MaterialSkin.Controls.MaterialComboBox bookAddRatingComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ImageList userIconTabControl;
        public System.Windows.Forms.TabPage homeTab;
        public MaterialSkin.Controls.MaterialTabControl userMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DataGridView topRatingBooksDataGrid;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
    }
}