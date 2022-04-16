
namespace Library
{
    partial class RentalsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RentalsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet2 = new Library.LibraryDBDataSet2();
            this.DeleteRentalButton = new System.Windows.Forms.Button();
            this.UpdateRentalButton = new System.Windows.Forms.Button();
            this.AddRentalButton = new System.Windows.Forms.Button();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.StudentsFirstNameComboBox = new System.Windows.Forms.ComboBox();
            this.RentalsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalsTableAdapter = new Library.LibraryDBDataSet2TableAdapters.RentalsTableAdapter();
            this.StudentsLastNameComboBox = new System.Windows.Forms.ComboBox();
            this.StudentsIndexNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalsDataGrid
            // 
            this.RentalsDataGrid.AutoGenerateColumns = false;
            this.RentalsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RentalsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.bookDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.indexNumberDataGridViewTextBoxColumn,
            this.studentsEmailDataGridViewTextBoxColumn,
            this.studentsPhoneDataGridViewTextBoxColumn,
            this.rentalDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
            this.RentalsDataGrid.DataSource = this.rentalsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RentalsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RentalsDataGrid.Location = new System.Drawing.Point(20, 360);
            this.RentalsDataGrid.Name = "RentalsDataGrid";
            this.RentalsDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RentalsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentalsDataGrid.Size = new System.Drawing.Size(920, 280);
            this.RentalsDataGrid.TabIndex = 0;
            this.RentalsDataGrid.SelectionChanged += new System.EventHandler(this.RentalsDataGrid_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RentalsID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RentalsID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            this.bookDataGridViewTextBoxColumn.HeaderText = "Book";
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            this.bookDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookDataGridViewTextBoxColumn.Width = 120;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 120;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentDataGridViewTextBoxColumn.Width = 120;
            // 
            // indexNumberDataGridViewTextBoxColumn
            // 
            this.indexNumberDataGridViewTextBoxColumn.DataPropertyName = "Index number";
            this.indexNumberDataGridViewTextBoxColumn.HeaderText = "Index number";
            this.indexNumberDataGridViewTextBoxColumn.Name = "indexNumberDataGridViewTextBoxColumn";
            this.indexNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // studentsEmailDataGridViewTextBoxColumn
            // 
            this.studentsEmailDataGridViewTextBoxColumn.DataPropertyName = "Students email";
            this.studentsEmailDataGridViewTextBoxColumn.HeaderText = "Students email";
            this.studentsEmailDataGridViewTextBoxColumn.Name = "studentsEmailDataGridViewTextBoxColumn";
            this.studentsEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsPhoneDataGridViewTextBoxColumn
            // 
            this.studentsPhoneDataGridViewTextBoxColumn.DataPropertyName = "Students phone";
            this.studentsPhoneDataGridViewTextBoxColumn.HeaderText = "Students phone";
            this.studentsPhoneDataGridViewTextBoxColumn.Name = "studentsPhoneDataGridViewTextBoxColumn";
            this.studentsPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalDateDataGridViewTextBoxColumn
            // 
            this.rentalDateDataGridViewTextBoxColumn.DataPropertyName = "Rental date";
            this.rentalDateDataGridViewTextBoxColumn.HeaderText = "Rental date";
            this.rentalDateDataGridViewTextBoxColumn.Name = "rentalDateDataGridViewTextBoxColumn";
            this.rentalDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return date";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return date";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalsBindingSource
            // 
            this.rentalsBindingSource.DataMember = "Rentals";
            this.rentalsBindingSource.DataSource = this.libraryDBDataSet2;
            // 
            // libraryDBDataSet2
            // 
            this.libraryDBDataSet2.DataSetName = "LibraryDBDataSet2";
            this.libraryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteRentalButton
            // 
            this.DeleteRentalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRentalButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRentalButton.ForeColor = System.Drawing.Color.White;
            this.DeleteRentalButton.Location = new System.Drawing.Point(700, 120);
            this.DeleteRentalButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DeleteRentalButton.Name = "DeleteRentalButton";
            this.DeleteRentalButton.Size = new System.Drawing.Size(170, 31);
            this.DeleteRentalButton.TabIndex = 28;
            this.DeleteRentalButton.Text = "Delete rental";
            this.DeleteRentalButton.UseVisualStyleBackColor = true;
            this.DeleteRentalButton.Click += new System.EventHandler(this.DeleteRentalButton_Click);
            // 
            // UpdateRentalButton
            // 
            this.UpdateRentalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateRentalButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRentalButton.ForeColor = System.Drawing.Color.White;
            this.UpdateRentalButton.Location = new System.Drawing.Point(700, 170);
            this.UpdateRentalButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UpdateRentalButton.Name = "UpdateRentalButton";
            this.UpdateRentalButton.Size = new System.Drawing.Size(170, 31);
            this.UpdateRentalButton.TabIndex = 27;
            this.UpdateRentalButton.Text = "Update rental";
            this.UpdateRentalButton.UseVisualStyleBackColor = true;
            this.UpdateRentalButton.Click += new System.EventHandler(this.UpdateRentalButton_Click);
            // 
            // AddRentalButton
            // 
            this.AddRentalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRentalButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRentalButton.ForeColor = System.Drawing.Color.White;
            this.AddRentalButton.Location = new System.Drawing.Point(700, 70);
            this.AddRentalButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddRentalButton.Name = "AddRentalButton";
            this.AddRentalButton.Size = new System.Drawing.Size(170, 31);
            this.AddRentalButton.TabIndex = 29;
            this.AddRentalButton.Text = "Add rental";
            this.AddRentalButton.UseVisualStyleBackColor = true;
            this.AddRentalButton.Click += new System.EventHandler(this.AddRentalButton_Click);
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBookButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBookButton.ForeColor = System.Drawing.Color.White;
            this.SearchBookButton.Location = new System.Drawing.Point(270, 280);
            this.SearchBookButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(140, 31);
            this.SearchBookButton.TabIndex = 26;
            this.SearchBookButton.Text = "Search";
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Students Index number:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Book:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Students First name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Students Last name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search rental:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(260, 70);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(151, 21);
            this.BookComboBox.TabIndex = 40;
            // 
            // StudentsFirstNameComboBox
            // 
            this.StudentsFirstNameComboBox.FormattingEnabled = true;
            this.StudentsFirstNameComboBox.Location = new System.Drawing.Point(260, 120);
            this.StudentsFirstNameComboBox.Name = "StudentsFirstNameComboBox";
            this.StudentsFirstNameComboBox.Size = new System.Drawing.Size(151, 21);
            this.StudentsFirstNameComboBox.TabIndex = 41;
            // 
            // RentalsID
            // 
            this.RentalsID.DataPropertyName = "RentalsID";
            this.RentalsID.HeaderText = "RentalsID";
            this.RentalsID.Name = "RentalsID";
            this.RentalsID.ReadOnly = true;
            this.RentalsID.Visible = false;
            // 
            // rentalsTableAdapter
            // 
            this.rentalsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsLastNameComboBox
            // 
            this.StudentsLastNameComboBox.FormattingEnabled = true;
            this.StudentsLastNameComboBox.Location = new System.Drawing.Point(260, 170);
            this.StudentsLastNameComboBox.Name = "StudentsLastNameComboBox";
            this.StudentsLastNameComboBox.Size = new System.Drawing.Size(151, 21);
            this.StudentsLastNameComboBox.TabIndex = 42;
            // 
            // StudentsIndexNumberComboBox
            // 
            this.StudentsIndexNumberComboBox.FormattingEnabled = true;
            this.StudentsIndexNumberComboBox.Location = new System.Drawing.Point(260, 220);
            this.StudentsIndexNumberComboBox.Name = "StudentsIndexNumberComboBox";
            this.StudentsIndexNumberComboBox.Size = new System.Drawing.Size(151, 21);
            this.StudentsIndexNumberComboBox.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Rentals:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // RentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(952, 705);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentsIndexNumberComboBox);
            this.Controls.Add(this.StudentsLastNameComboBox);
            this.Controls.Add(this.StudentsFirstNameComboBox);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteRentalButton);
            this.Controls.Add(this.UpdateRentalButton);
            this.Controls.Add(this.AddRentalButton);
            this.Controls.Add(this.SearchBookButton);
            this.Controls.Add(this.RentalsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalsForm";
            this.Load += new System.EventHandler(this.Rentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RentalsDataGrid;
        private System.Windows.Forms.Button DeleteRentalButton;
        private System.Windows.Forms.Button UpdateRentalButton;
        private System.Windows.Forms.Button AddRentalButton;
        private System.Windows.Forms.Button SearchBookButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LibraryDBDataSet2 libraryDBDataSet2;
        private System.Windows.Forms.BindingSource rentalsBindingSource;
        private LibraryDBDataSet2TableAdapters.RentalsTableAdapter rentalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.ComboBox StudentsFirstNameComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalsID;
        private System.Windows.Forms.ComboBox StudentsLastNameComboBox;
        private System.Windows.Forms.ComboBox StudentsIndexNumberComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
    }
}