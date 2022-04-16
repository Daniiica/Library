using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presentation.UserViews
{
    public partial class Book : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Book()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
            MaterialSkin.Primary.Grey900,
            MaterialSkin.Primary.Grey900,
            MaterialSkin.Primary.Red400,
            MaterialSkin.Accent.Pink200,
            MaterialSkin.TextShade.WHITE);
        }
    }
}
