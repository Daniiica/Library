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
            this.homeTab = new System.Windows.Forms.TabPage();
            this.userMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.homeTab.SuspendLayout();
            this.userMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalsTab
            // 
            this.rentalsTab.BackColor = System.Drawing.Color.Black;
            this.rentalsTab.Location = new System.Drawing.Point(4, 25);
            this.rentalsTab.Name = "rentalsTab";
            this.rentalsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentalsTab.Size = new System.Drawing.Size(1133, 541);
            this.rentalsTab.TabIndex = 3;
            this.rentalsTab.Text = "RENTALS";
            this.rentalsTab.UseVisualStyleBackColor = true;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Black;
            this.homeTab.Controls.Add(this.materialTextBox21);
            this.homeTab.Controls.Add(this.materialTextBox1);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1133, 541);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "HOME";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // userMenu
            // 
            this.userMenu.Controls.Add(this.homeTab);
            this.userMenu.Controls.Add(this.rentalsTab);
            this.userMenu.Controls.Add(this.profileTab);
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
            this.profileTab.Location = new System.Drawing.Point(4, 25);
            this.profileTab.Name = "profileTab";
            this.profileTab.Size = new System.Drawing.Size(1133, 541);
            this.profileTab.TabIndex = 4;
            this.profileTab.Text = "PROFILE";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(304, 50);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(100, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(304, 119);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox21.TabIndex = 1;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.Text = "materialTextBox21";
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
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
            this.homeTab.ResumeLayout(false);
            this.userMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage rentalsTab;
        private System.Windows.Forms.TabPage homeTab;
        private MaterialSkin.Controls.MaterialTabControl userMenu;
        private System.Windows.Forms.TabPage profileTab;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}