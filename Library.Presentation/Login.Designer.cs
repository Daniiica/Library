namespace Library.Presentation
{
    partial class Login
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
            this.usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AnimateReadOnly = false;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox.Hint = "Username";
            this.usernameTextBox.LeadingIcon = null;
            this.usernameTextBox.Location = new System.Drawing.Point(19, 98);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(410, 50);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "";
            this.usernameTextBox.TrailingIcon = null;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.AllowPromptAsInput = true;
            this.passwordTextbox.AnimateReadOnly = false;
            this.passwordTextbox.AsciiOnly = false;
            this.passwordTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextbox.BeepOnError = false;
            this.passwordTextbox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passwordTextbox.Depth = 0;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextbox.HidePromptOnLeave = false;
            this.passwordTextbox.HideSelection = true;
            this.passwordTextbox.Hint = "Password";
            this.passwordTextbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.passwordTextbox.LeadingIcon = null;
            this.passwordTextbox.Location = new System.Drawing.Point(19, 164);
            this.passwordTextbox.Mask = "";
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '\0';
            this.passwordTextbox.PrefixSuffixText = null;
            this.passwordTextbox.PromptChar = '_';
            this.passwordTextbox.ReadOnly = false;
            this.passwordTextbox.RejectInputOnFirstFailure = false;
            this.passwordTextbox.ResetOnPrompt = true;
            this.passwordTextbox.ResetOnSpace = true;
            this.passwordTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.ShortcutsEnabled = true;
            this.passwordTextbox.Size = new System.Drawing.Size(410, 48);
            this.passwordTextbox.SkipLiterals = true;
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.TabStop = false;
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextbox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passwordTextbox.TrailingIcon = null;
            this.passwordTextbox.UseSystemPasswordChar = false;
            this.passwordTextbox.ValidatingType = null;
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(358, 249);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(64, 36);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(19, 294);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(410, 1);
            this.materialDivider1.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 325);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Lost your password?";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.White;
            this.materialLabel2.Location = new System.Drawing.Point(371, 325);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Register";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(454, 366);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox passwordTextbox;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}