
namespace Library
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.AdministrationButton = new System.Windows.Forms.Button();
            this.RentalsButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(215, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 705);
            this.panel1.TabIndex = 0;
            // 
            // StudentsButton
            // 
            this.StudentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.StudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsButton.ForeColor = System.Drawing.Color.White;
            this.StudentsButton.Location = new System.Drawing.Point(26, 271);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(157, 50);
            this.StudentsButton.TabIndex = 1;
            this.StudentsButton.Text = "Students";
            this.StudentsButton.UseVisualStyleBackColor = false;
            this.StudentsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.BooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksButton.ForeColor = System.Drawing.Color.White;
            this.BooksButton.Location = new System.Drawing.Point(26, 391);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(157, 50);
            this.BooksButton.TabIndex = 2;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = false;
            this.BooksButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(26, 144);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(157, 50);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // AdministrationButton
            // 
            this.AdministrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.AdministrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdministrationButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministrationButton.ForeColor = System.Drawing.Color.White;
            this.AdministrationButton.Location = new System.Drawing.Point(26, 610);
            this.AdministrationButton.Name = "AdministrationButton";
            this.AdministrationButton.Size = new System.Drawing.Size(157, 50);
            this.AdministrationButton.TabIndex = 4;
            this.AdministrationButton.Text = "Administration";
            this.AdministrationButton.UseVisualStyleBackColor = false;
            this.AdministrationButton.Click += new System.EventHandler(this.AdministrationButton_Click);
            // 
            // RentalsButton
            // 
            this.RentalsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.RentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentalsButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalsButton.ForeColor = System.Drawing.Color.White;
            this.RentalsButton.Location = new System.Drawing.Point(26, 505);
            this.RentalsButton.Name = "RentalsButton";
            this.RentalsButton.Size = new System.Drawing.Size(157, 50);
            this.RentalsButton.TabIndex = 5;
            this.RentalsButton.Text = "Rentals";
            this.RentalsButton.UseVisualStyleBackColor = false;
            this.RentalsButton.Click += new System.EventHandler(this.RentalsButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library.Properties.Resources.CLOSE_gradient;
            this.pictureBox2.Location = new System.Drawing.Point(1159, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1186, 742);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RentalsButton);
            this.Controls.Add(this.AdministrationButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.BooksButton);
            this.Controls.Add(this.StudentsButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button AdministrationButton;
        private System.Windows.Forms.Button RentalsButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

