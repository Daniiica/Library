namespace Library.Presentation.UserViews
{
    partial class Book
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.BookName = new MaterialSkin.Controls.MaterialLabel();
            this.bookImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(110, 133);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(600, 269);
            this.materialCard1.TabIndex = 0;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Depth = 0;
            this.BookName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BookName.Location = new System.Drawing.Point(110, 82);
            this.BookName.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(1, 0);
            this.BookName.TabIndex = 1;
            // 
            // bookImages
            // 
            this.bookImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.bookImages.ImageSize = new System.Drawing.Size(32, 32);
            this.bookImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.materialCard1);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel BookName;
        private System.Windows.Forms.ImageList bookImages;
    }
}