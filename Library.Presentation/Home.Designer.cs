namespace Library.Presentation
{
    partial class Home
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
            this.menu = new MaterialSkin.Controls.MaterialTabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.studentsTab = new System.Windows.Forms.TabPage();
            this.rentalsTab = new System.Windows.Forms.TabPage();
            this.administrationTab = new System.Windows.Forms.TabPage();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.homeTab);
            this.menu.Controls.Add(this.booksTab);
            this.menu.Controls.Add(this.studentsTab);
            this.menu.Controls.Add(this.rentalsTab);
            this.menu.Controls.Add(this.administrationTab);
            this.menu.Depth = 0;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 64);
            this.menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.menu.Multiline = true;
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(1141, 570);
            this.menu.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Black;
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1133, 581);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "HOME";
            // 
            // booksTab
            // 
            this.booksTab.BackColor = System.Drawing.Color.Black;
            this.booksTab.Location = new System.Drawing.Point(4, 25);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(1133, 581);
            this.booksTab.TabIndex = 1;
            this.booksTab.Text = "BOOKS";
            // 
            // studentsTab
            // 
            this.studentsTab.BackColor = System.Drawing.Color.Black;
            this.studentsTab.Location = new System.Drawing.Point(4, 25);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentsTab.Size = new System.Drawing.Size(1133, 581);
            this.studentsTab.TabIndex = 2;
            this.studentsTab.Text = "STUDENTS";
            // 
            // rentalsTab
            // 
            this.rentalsTab.BackColor = System.Drawing.Color.Black;
            this.rentalsTab.Location = new System.Drawing.Point(4, 25);
            this.rentalsTab.Name = "rentalsTab";
            this.rentalsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentalsTab.Size = new System.Drawing.Size(1133, 581);
            this.rentalsTab.TabIndex = 3;
            this.rentalsTab.Text = "RENTALS";
            // 
            // administrationTab
            // 
            this.administrationTab.BackColor = System.Drawing.Color.Black;
            this.administrationTab.Location = new System.Drawing.Point(4, 25);
            this.administrationTab.Name = "administrationTab";
            this.administrationTab.Padding = new System.Windows.Forms.Padding(3);
            this.administrationTab.Size = new System.Drawing.Size(1133, 541);
            this.administrationTab.TabIndex = 4;
            this.administrationTab.Text = "ADMINISTRATION";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 638);
            this.Controls.Add(this.menu);
            this.DrawerAutoHide = false;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.menu;
            this.DrawerWidth = 250;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRARY";
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl menu;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage studentsTab;
        private System.Windows.Forms.TabPage rentalsTab;
        private System.Windows.Forms.TabPage administrationTab;
    }
}