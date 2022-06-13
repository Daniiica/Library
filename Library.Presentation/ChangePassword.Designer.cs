
namespace Library.Presentation
{
    partial class ChangePassword
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
            this.CANCELButton = new MaterialSkin.Controls.MaterialButton();
            this.NewPasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ConfirmNewPasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.OKButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CANCELButton
            // 
            this.CANCELButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CANCELButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CANCELButton.Depth = 0;
            this.CANCELButton.HighEmphasis = true;
            this.CANCELButton.Icon = null;
            this.CANCELButton.Location = new System.Drawing.Point(364, 321);
            this.CANCELButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CANCELButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CANCELButton.Name = "CANCELButton";
            this.CANCELButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CANCELButton.Size = new System.Drawing.Size(77, 36);
            this.CANCELButton.TabIndex = 11;
            this.CANCELButton.Text = "CANCEL";
            this.CANCELButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CANCELButton.UseAccentColor = false;
            this.CANCELButton.UseVisualStyleBackColor = true;
            this.CANCELButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.AnimateReadOnly = false;
            this.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordTextBox.Depth = 0;
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewPasswordTextBox.Hint = "New Password";
            this.NewPasswordTextBox.LeadingIcon = null;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(20, 161);
            this.NewPasswordTextBox.MaxLength = 50;
            this.NewPasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NewPasswordTextBox.Multiline = false;
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Password = true;
            this.NewPasswordTextBox.Size = new System.Drawing.Size(410, 50);
            this.NewPasswordTextBox.TabIndex = 10;
            this.NewPasswordTextBox.Text = "";
            this.NewPasswordTextBox.TrailingIcon = null;
            // 
            // ConfirmNewPasswordTextBox
            // 
            this.ConfirmNewPasswordTextBox.AnimateReadOnly = false;
            this.ConfirmNewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmNewPasswordTextBox.Depth = 0;
            this.ConfirmNewPasswordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ConfirmNewPasswordTextBox.Hint = "Confirm New Password";
            this.ConfirmNewPasswordTextBox.LeadingIcon = null;
            this.ConfirmNewPasswordTextBox.Location = new System.Drawing.Point(20, 238);
            this.ConfirmNewPasswordTextBox.MaxLength = 50;
            this.ConfirmNewPasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ConfirmNewPasswordTextBox.Multiline = false;
            this.ConfirmNewPasswordTextBox.Name = "ConfirmNewPasswordTextBox";
            this.ConfirmNewPasswordTextBox.Password = true;
            this.ConfirmNewPasswordTextBox.Size = new System.Drawing.Size(410, 50);
            this.ConfirmNewPasswordTextBox.TabIndex = 9;
            this.ConfirmNewPasswordTextBox.Text = "";
            this.ConfirmNewPasswordTextBox.TrailingIcon = null;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AnimateReadOnly = false;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Depth = 0;
            this.EmailTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailTextBox.Hint = "Email";
            this.EmailTextBox.LeadingIcon = null;
            this.EmailTextBox.Location = new System.Drawing.Point(20, 87);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(410, 50);
            this.EmailTextBox.TabIndex = 8;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.TrailingIcon = null;
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = false;
            this.OKButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OKButton.Depth = 0;
            this.OKButton.HighEmphasis = true;
            this.OKButton.Icon = null;
            this.OKButton.Location = new System.Drawing.Point(272, 321);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OKButton.Size = new System.Drawing.Size(77, 36);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKButton.UseAccentColor = false;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 366);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CANCELButton);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.ConfirmNewPasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton CANCELButton;
        private MaterialSkin.Controls.MaterialTextBox NewPasswordTextBox;
        private MaterialSkin.Controls.MaterialTextBox ConfirmNewPasswordTextBox;
        private MaterialSkin.Controls.MaterialTextBox EmailTextBox;
        private MaterialSkin.Controls.MaterialButton OKButton;
    }
}