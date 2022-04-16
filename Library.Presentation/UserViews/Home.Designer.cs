namespace Library.Presentation.UserViews
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.imageList = new MaterialSkin.Controls.MaterialListView();
            this.topBooks = new System.Windows.Forms.ImageList(this.components);
            this.imagesTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.AutoSizeTable = true;
            this.imageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageList.Depth = 0;
            this.imageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageList.FullRowSelect = true;
            this.imageList.HideSelection = false;
            this.imageList.Location = new System.Drawing.Point(3, 64);
            this.imageList.MinimumSize = new System.Drawing.Size(200, 100);
            this.imageList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.imageList.MouseState = MaterialSkin.MouseState.OUT;
            this.imageList.Name = "imageList";
            this.imageList.OwnerDraw = true;
            this.imageList.Scrollable = false;
            this.imageList.Size = new System.Drawing.Size(200, 100);
            this.imageList.TabIndex = 0;
            this.imageList.TileSize = new System.Drawing.Size(200, 250);
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.View = System.Windows.Forms.View.Details;
            // 
            // topBooks
            // 
            this.topBooks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("topBooks.ImageStream")));
            this.topBooks.TransparentColor = System.Drawing.Color.Transparent;
            this.topBooks.Images.SetKeyName(0, "Aquaman.jpg");
            this.topBooks.Images.SetKeyName(1, "Batman.jpg");
            this.topBooks.Images.SetKeyName(2, "Flash.jpg");
            this.topBooks.Images.SetKeyName(3, "GreenLantern.jpg");
            this.topBooks.Images.SetKeyName(4, "Joker.jpg");
            // 
            // imagesTable
            // 
            this.imagesTable.ColumnCount = 1;
            this.imagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1360F));
            this.imagesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.imagesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesTable.Location = new System.Drawing.Point(3, 64);
            this.imagesTable.Name = "imagesTable";
            this.imagesTable.RowCount = 2;
            this.imagesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imagesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imagesTable.Size = new System.Drawing.Size(1360, 701);
            this.imagesTable.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.imagesTable);
            this.Controls.Add(this.imageList);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView imageList;
        private System.Windows.Forms.ImageList topBooks;
        private System.Windows.Forms.TableLayoutPanel imagesTable;
    }
}