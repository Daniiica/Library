
namespace Library
{
    partial class AdministrationsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteEmployerButton = new System.Windows.Forms.Button();
            this.UpdateEmployerButton = new System.Windows.Forms.Button();
            this.AddEmployerButton = new System.Windows.Forms.Button();
            this.SearchEmployerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpoyedDataGrid = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet31 = new Library.LibraryDBDataSet3();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryDBDataSet31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet31BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employersTableAdapter = new Library.LibraryDBDataSet3TableAdapters.EmployersTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmpoyedDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet31BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search employed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Author:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "ISBN:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(180, 120);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(180, 20);
            this.AuthorTextBox.TabIndex = 22;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(180, 170);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(180, 20);
            this.ISBNTextBox.TabIndex = 21;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(180, 70);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 20);
            this.NameTextBox.TabIndex = 20;
            // 
            // DeleteEmployerButton
            // 
            this.DeleteEmployerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployerButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployerButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEmployerButton.Location = new System.Drawing.Point(700, 120);
            this.DeleteEmployerButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DeleteEmployerButton.Name = "DeleteEmployerButton";
            this.DeleteEmployerButton.Size = new System.Drawing.Size(185, 35);
            this.DeleteEmployerButton.TabIndex = 27;
            this.DeleteEmployerButton.Text = "Delete employer";
            this.DeleteEmployerButton.UseVisualStyleBackColor = true;
            this.DeleteEmployerButton.Click += new System.EventHandler(this.DeleteEmployerButton_Click);
            // 
            // UpdateEmployerButton
            // 
            this.UpdateEmployerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmployerButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployerButton.ForeColor = System.Drawing.Color.White;
            this.UpdateEmployerButton.Location = new System.Drawing.Point(700, 170);
            this.UpdateEmployerButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UpdateEmployerButton.Name = "UpdateEmployerButton";
            this.UpdateEmployerButton.Size = new System.Drawing.Size(185, 35);
            this.UpdateEmployerButton.TabIndex = 26;
            this.UpdateEmployerButton.Text = "Update employer";
            this.UpdateEmployerButton.UseVisualStyleBackColor = true;
            this.UpdateEmployerButton.Click += new System.EventHandler(this.UpdateEmployerButton_Click);
            // 
            // AddEmployerButton
            // 
            this.AddEmployerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployerButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployerButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployerButton.Location = new System.Drawing.Point(700, 70);
            this.AddEmployerButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddEmployerButton.Name = "AddEmployerButton";
            this.AddEmployerButton.Size = new System.Drawing.Size(185, 35);
            this.AddEmployerButton.TabIndex = 28;
            this.AddEmployerButton.Text = "Add employer";
            this.AddEmployerButton.UseVisualStyleBackColor = true;
            this.AddEmployerButton.Click += new System.EventHandler(this.AddEmployerButton_Click);
            // 
            // SearchEmployerButton
            // 
            this.SearchEmployerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEmployerButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmployerButton.ForeColor = System.Drawing.Color.White;
            this.SearchEmployerButton.Location = new System.Drawing.Point(220, 280);
            this.SearchEmployerButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchEmployerButton.Name = "SearchEmployerButton";
            this.SearchEmployerButton.Size = new System.Drawing.Size(140, 31);
            this.SearchEmployerButton.TabIndex = 29;
            this.SearchEmployerButton.Text = "Search";
            this.SearchEmployerButton.UseVisualStyleBackColor = true;
            this.SearchEmployerButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Employed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // EmpoyedDataGrid
            // 
            this.EmpoyedDataGrid.AutoGenerateColumns = false;
            this.EmpoyedDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpoyedDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpoyedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpoyedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.EmpoyedDataGrid.DataSource = this.employersBindingSource;
            this.EmpoyedDataGrid.Location = new System.Drawing.Point(20, 360);
            this.EmpoyedDataGrid.Name = "EmpoyedDataGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpoyedDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpoyedDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpoyedDataGrid.Size = new System.Drawing.Size(920, 280);
            this.EmpoyedDataGrid.TabIndex = 31;
            this.EmpoyedDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployerGrid_CellClick);
            // 
            // userIDDataGridViewTextBoxColumn2
            // 
            this.userIDDataGridViewTextBoxColumn2.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn2.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn2.Name = "userIDDataGridViewTextBoxColumn2";
            this.userIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn6.HeaderText = "Password";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Insert Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Insert Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 160;
            // 
            // employersBindingSource
            // 
            this.employersBindingSource.DataMember = "Employers";
            this.employersBindingSource.DataSource = this.libraryDBDataSet31;
            // 
            // libraryDBDataSet31
            // 
            this.libraryDBDataSet31.DataSetName = "LibraryDBDataSet3";
            this.libraryDBDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // libraryDBDataSet31BindingSource
            // 
            this.libraryDBDataSet31BindingSource.DataSource = this.libraryDBDataSet31;
            this.libraryDBDataSet31BindingSource.Position = 0;
            // 
            // libraryDBDataSet31BindingSource1
            // 
            this.libraryDBDataSet31BindingSource1.DataSource = this.libraryDBDataSet31;
            this.libraryDBDataSet31BindingSource1.Position = 0;
            // 
            // employersTableAdapter
            // 
            this.employersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // AdministrationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(952, 705);
            this.Controls.Add(this.EmpoyedDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchEmployerButton);
            this.Controls.Add(this.DeleteEmployerButton);
            this.Controls.Add(this.UpdateEmployerButton);
            this.Controls.Add(this.AddEmployerButton);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrationsForm";
            this.Text = "AdministrationsForm";
            this.Load += new System.EventHandler(this.AdministrationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpoyedDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet31BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button DeleteEmployerButton;
        private System.Windows.Forms.Button UpdateEmployerButton;
        private System.Windows.Forms.Button AddEmployerButton;
        private System.Windows.Forms.Button SearchEmployerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView EmpoyedDataGrid;
        private LibraryDBDataSet3 libraryDBDataSet3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource libraryDBDataSet31BindingSource;
        private LibraryDBDataSet3 libraryDBDataSet31;
        private System.Windows.Forms.BindingSource libraryDBDataSet31BindingSource1;
        private System.Windows.Forms.BindingSource employersBindingSource;
        private LibraryDBDataSet3TableAdapters.EmployersTableAdapter employersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}