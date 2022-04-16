
namespace Library
{
    partial class AddBooksForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ISBNValidation = new System.Windows.Forms.Label();
            this.PublisherValidation = new System.Windows.Forms.Label();
            this.AuthorValidation = new System.Windows.Forms.Label();
            this.NameValidation = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddUpdateBookLabel = new System.Windows.Forms.Label();
            this.AddUpdateLabel = new System.Windows.Forms.Label();
            this.DescriptionValidation = new System.Windows.Forms.Label();
            this.LanguageValidation = new System.Windows.Forms.Label();
            this.AmountValidation = new System.Windows.Forms.Label();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.PublisherComboBox = new System.Windows.Forms.ComboBox();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.GenreCheckList = new System.Windows.Forms.CheckedListBox();
            this.DeleteGenrePictureBox = new System.Windows.Forms.PictureBox();
            this.AddPublisherPictureBox = new System.Windows.Forms.PictureBox();
            this.DeletePublisherPictureBox = new System.Windows.Forms.PictureBox();
            this.AddGenrePictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteAuthorPictureBox = new System.Windows.Forms.PictureBox();
            this.AddAuthorPictureBox = new System.Windows.Forms.PictureBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreValidation = new System.Windows.Forms.Label();
            this.libraryDBDataSet1 = new Library.LibraryDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGenrePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPublisherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePublisherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGenrePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAuthorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAuthorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(420, 400);
            this.OKButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(170, 31);
            this.OKButton.TabIndex = 46;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(450, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Language:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ISBNValidation
            // 
            this.ISBNValidation.ForeColor = System.Drawing.Color.Red;
            this.ISBNValidation.Location = new System.Drawing.Point(570, 125);
            this.ISBNValidation.Name = "ISBNValidation";
            this.ISBNValidation.Size = new System.Drawing.Size(150, 20);
            this.ISBNValidation.TabIndex = 42;
            // 
            // PublisherValidation
            // 
            this.PublisherValidation.ForeColor = System.Drawing.Color.Red;
            this.PublisherValidation.Location = new System.Drawing.Point(130, 225);
            this.PublisherValidation.Name = "PublisherValidation";
            this.PublisherValidation.Size = new System.Drawing.Size(150, 20);
            this.PublisherValidation.TabIndex = 40;
            // 
            // AuthorValidation
            // 
            this.AuthorValidation.ForeColor = System.Drawing.Color.Red;
            this.AuthorValidation.Location = new System.Drawing.Point(130, 175);
            this.AuthorValidation.Name = "AuthorValidation";
            this.AuthorValidation.Size = new System.Drawing.Size(150, 20);
            this.AuthorValidation.TabIndex = 39;
            // 
            // NameValidation
            // 
            this.NameValidation.ForeColor = System.Drawing.Color.Red;
            this.NameValidation.Location = new System.Drawing.Point(130, 125);
            this.NameValidation.Name = "NameValidation";
            this.NameValidation.Size = new System.Drawing.Size(150, 20);
            this.NameValidation.TabIndex = 38;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(620, 400);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(170, 31);
            this.CloseButton.TabIndex = 37;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(570, 100);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(150, 20);
            this.ISBNTextBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(450, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "ISBN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(570, 150);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(150, 20);
            this.DescriptionTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(450, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Description:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(20, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Publisher:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(20, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Author:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(130, 100);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(570, 250);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(150, 20);
            this.AmountTextBox.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(450, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Amount:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddUpdateBookLabel
            // 
            this.AddUpdateBookLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdateBookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.AddUpdateBookLabel.Location = new System.Drawing.Point(20, 10);
            this.AddUpdateBookLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddUpdateBookLabel.Name = "AddUpdateBookLabel";
            this.AddUpdateBookLabel.Size = new System.Drawing.Size(150, 20);
            this.AddUpdateBookLabel.TabIndex = 50;
            this.AddUpdateBookLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddUpdateLabel
            // 
            this.AddUpdateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.AddUpdateLabel.Location = new System.Drawing.Point(20, 10);
            this.AddUpdateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddUpdateLabel.Name = "AddUpdateLabel";
            this.AddUpdateLabel.Size = new System.Drawing.Size(150, 20);
            this.AddUpdateLabel.TabIndex = 51;
            this.AddUpdateLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DescriptionValidation
            // 
            this.DescriptionValidation.ForeColor = System.Drawing.Color.Red;
            this.DescriptionValidation.Location = new System.Drawing.Point(570, 175);
            this.DescriptionValidation.Name = "DescriptionValidation";
            this.DescriptionValidation.Size = new System.Drawing.Size(150, 20);
            this.DescriptionValidation.TabIndex = 56;
            // 
            // LanguageValidation
            // 
            this.LanguageValidation.ForeColor = System.Drawing.Color.Red;
            this.LanguageValidation.Location = new System.Drawing.Point(570, 225);
            this.LanguageValidation.Name = "LanguageValidation";
            this.LanguageValidation.Size = new System.Drawing.Size(150, 20);
            this.LanguageValidation.TabIndex = 57;
            // 
            // AmountValidation
            // 
            this.AmountValidation.ForeColor = System.Drawing.Color.Red;
            this.AmountValidation.Location = new System.Drawing.Point(570, 275);
            this.AmountValidation.Name = "AmountValidation";
            this.AmountValidation.Size = new System.Drawing.Size(150, 20);
            this.AmountValidation.TabIndex = 58;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(130, 150);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(150, 21);
            this.AuthorComboBox.TabIndex = 59;
            // 
            // PublisherComboBox
            // 
            this.PublisherComboBox.FormattingEnabled = true;
            this.PublisherComboBox.Location = new System.Drawing.Point(130, 200);
            this.PublisherComboBox.Name = "PublisherComboBox";
            this.PublisherComboBox.Size = new System.Drawing.Size(150, 21);
            this.PublisherComboBox.TabIndex = 60;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(570, 200);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(150, 21);
            this.LanguageComboBox.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.label12.Location = new System.Drawing.Point(20, 250);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 23);
            this.label12.TabIndex = 62;
            this.label12.Text = "Genre:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // GenreCheckList
            // 
            this.GenreCheckList.FormattingEnabled = true;
            this.GenreCheckList.Location = new System.Drawing.Point(130, 250);
            this.GenreCheckList.Name = "GenreCheckList";
            this.GenreCheckList.Size = new System.Drawing.Size(184, 79);
            this.GenreCheckList.TabIndex = 63;
            // 
            // DeleteGenrePictureBox
            // 
            this.DeleteGenrePictureBox.Image = global::Library.Properties.Resources.minus;
            this.DeleteGenrePictureBox.Location = new System.Drawing.Point(324, 334);
            this.DeleteGenrePictureBox.Name = "DeleteGenrePictureBox";
            this.DeleteGenrePictureBox.Size = new System.Drawing.Size(22, 21);
            this.DeleteGenrePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteGenrePictureBox.TabIndex = 65;
            this.DeleteGenrePictureBox.TabStop = false;
            this.DeleteGenrePictureBox.Visible = false;
            this.DeleteGenrePictureBox.Click += new System.EventHandler(this.DeleteGenrePictureBox_Click);
            // 
            // AddPublisherPictureBox
            // 
            this.AddPublisherPictureBox.Image = global::Library.Properties.Resources.plus;
            this.AddPublisherPictureBox.Location = new System.Drawing.Point(296, 200);
            this.AddPublisherPictureBox.Name = "AddPublisherPictureBox";
            this.AddPublisherPictureBox.Size = new System.Drawing.Size(22, 21);
            this.AddPublisherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPublisherPictureBox.TabIndex = 64;
            this.AddPublisherPictureBox.TabStop = false;
            this.AddPublisherPictureBox.Click += new System.EventHandler(this.AddPublisherPictureBox_Click);
            // 
            // DeletePublisherPictureBox
            // 
            this.DeletePublisherPictureBox.Image = global::Library.Properties.Resources.minus;
            this.DeletePublisherPictureBox.Location = new System.Drawing.Point(324, 200);
            this.DeletePublisherPictureBox.Name = "DeletePublisherPictureBox";
            this.DeletePublisherPictureBox.Size = new System.Drawing.Size(22, 21);
            this.DeletePublisherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletePublisherPictureBox.TabIndex = 66;
            this.DeletePublisherPictureBox.TabStop = false;
            this.DeletePublisherPictureBox.Visible = false;
            this.DeletePublisherPictureBox.Click += new System.EventHandler(this.DeletePublisherPictureBox_Click);
            // 
            // AddGenrePictureBox
            // 
            this.AddGenrePictureBox.Image = global::Library.Properties.Resources.plus;
            this.AddGenrePictureBox.Location = new System.Drawing.Point(296, 334);
            this.AddGenrePictureBox.Name = "AddGenrePictureBox";
            this.AddGenrePictureBox.Size = new System.Drawing.Size(22, 21);
            this.AddGenrePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddGenrePictureBox.TabIndex = 67;
            this.AddGenrePictureBox.TabStop = false;
            this.AddGenrePictureBox.Click += new System.EventHandler(this.AddGenrePictureBox_Click);
            // 
            // DeleteAuthorPictureBox
            // 
            this.DeleteAuthorPictureBox.Image = global::Library.Properties.Resources.minus;
            this.DeleteAuthorPictureBox.Location = new System.Drawing.Point(324, 100);
            this.DeleteAuthorPictureBox.Name = "DeleteAuthorPictureBox";
            this.DeleteAuthorPictureBox.Size = new System.Drawing.Size(22, 21);
            this.DeleteAuthorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteAuthorPictureBox.TabIndex = 69;
            this.DeleteAuthorPictureBox.TabStop = false;
            this.DeleteAuthorPictureBox.Visible = false;
            this.DeleteAuthorPictureBox.Click += new System.EventHandler(this.DeleteAuthorPictureBox_Click);
            // 
            // AddAuthorPictureBox
            // 
            this.AddAuthorPictureBox.Image = global::Library.Properties.Resources.plus;
            this.AddAuthorPictureBox.Location = new System.Drawing.Point(296, 100);
            this.AddAuthorPictureBox.Name = "AddAuthorPictureBox";
            this.AddAuthorPictureBox.Size = new System.Drawing.Size(22, 21);
            this.AddAuthorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddAuthorPictureBox.TabIndex = 68;
            this.AddAuthorPictureBox.TabStop = false;
            this.AddAuthorPictureBox.Click += new System.EventHandler(this.AddAuthorPictureBox_Click);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(130, 335);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(150, 20);
            this.GenreTextBox.TabIndex = 70;
            // 
            // GenreValidation
            // 
            this.GenreValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreValidation.ForeColor = System.Drawing.Color.Red;
            this.GenreValidation.Location = new System.Drawing.Point(130, 360);
            this.GenreValidation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GenreValidation.Name = "GenreValidation";
            this.GenreValidation.Size = new System.Drawing.Size(150, 20);
            this.GenreValidation.TabIndex = 71;
            // 
            // libraryDBDataSet1
            // 
            this.libraryDBDataSet1.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenreValidation);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.DeleteAuthorPictureBox);
            this.Controls.Add(this.AddAuthorPictureBox);
            this.Controls.Add(this.AddGenrePictureBox);
            this.Controls.Add(this.DeletePublisherPictureBox);
            this.Controls.Add(this.DeleteGenrePictureBox);
            this.Controls.Add(this.AddPublisherPictureBox);
            this.Controls.Add(this.GenreCheckList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.PublisherComboBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.AmountValidation);
            this.Controls.Add(this.LanguageValidation);
            this.Controls.Add(this.DescriptionValidation);
            this.Controls.Add(this.AddUpdateLabel);
            this.Controls.Add(this.AddUpdateBookLabel);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ISBNValidation);
            this.Controls.Add(this.PublisherValidation);
            this.Controls.Add(this.AuthorValidation);
            this.Controls.Add(this.NameValidation);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBooksForm";
            this.Text = "AddBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGenrePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPublisherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePublisherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGenrePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAuthorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAuthorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ISBNValidation;
        private System.Windows.Forms.Label PublisherValidation;
        private System.Windows.Forms.Label AuthorValidation;
        private System.Windows.Forms.Label NameValidation;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AddUpdateBookLabel;
        private System.Windows.Forms.Label AddUpdateLabel;
        private System.Windows.Forms.Label DescriptionValidation;
        private System.Windows.Forms.Label LanguageValidation;
        private System.Windows.Forms.Label AmountValidation;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.ComboBox PublisherComboBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label label12;
        private LibraryDBDataSet libraryDBDataSet1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckedListBox GenreCheckList;
        private System.Windows.Forms.PictureBox AddPublisherPictureBox;
        private System.Windows.Forms.PictureBox DeleteGenrePictureBox;
        private System.Windows.Forms.PictureBox DeletePublisherPictureBox;
        private System.Windows.Forms.PictureBox AddGenrePictureBox;
        private System.Windows.Forms.PictureBox DeleteAuthorPictureBox;
        private System.Windows.Forms.PictureBox AddAuthorPictureBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreValidation;
    }
}