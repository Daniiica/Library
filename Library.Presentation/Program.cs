using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Library.Presentation
{
    internal static class Program
    {
        public static readonly MaterialSkin.MaterialSkinManager MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeMaterialManager();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        private static void InitializeMaterialManager() 
        {
            MaterialSkinManager.EnforceBackcolorOnAllComponents = true;
            MaterialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            MaterialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
            MaterialSkin.Primary.Grey900,
            MaterialSkin.Primary.Grey900,
            MaterialSkin.Primary.Red400,
            MaterialSkin.Accent.Red700,
            MaterialSkin.TextShade.WHITE
            );
          
        }
    }
}
