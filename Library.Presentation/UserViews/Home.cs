using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Presentation.UserViews
{
    public partial class Home : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Home()
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
            MaterialSkin.TextShade.WHITE
            );


            foreach (var book in _books) 
            {
                
            }
        }

        private List<Book> _books = new List<Book>() 
        {
            new Book 
            {
                Id = 1,
                Name = "Batman",
                Picture = Image.FromFile(@"C:\Projects\Library\Library.Presentation\Resources\Images\Batman.jpg")
            },
            new Book 
            {
                Id = 2,
                Name = "Flash",
                Picture = Image.FromFile(@"C:\Projects\Library\Library.Presentation\Resources\Images\Flash.jpg")
            },
            new Book 
            {
                Id = 3,
                Name = "Joker",
                Picture = Image.FromFile(@"C:\Projects\Library\Library.Presentation\Resources\Images\Joker.jpg")
            },
            new Book 
            {
                Id = 4,
                Name = "GreenLantern",
                Picture = Image.FromFile(@"C:\Projects\Library\Library.Presentation\Resources\Images\GreenLantern.jpg")
            },
            new Book 
            {
                Id = 5,
                Name = "Aquaman",
                Picture = Image.FromFile(@"C:\Projects\Library\Library.Presentation\Resources\Images\Aquaman.jpg")
            }
        };

        public class Book 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Image Picture { get; set; }
            public string Description { get; set; }
        }
    }
}
