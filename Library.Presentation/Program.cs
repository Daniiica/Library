using Library.Presentation.Bussiness;
using System;
using System.Windows.Forms;

namespace Library.Presentation
{
    internal static class Program
    {
        public static readonly MaterialSkin.MaterialSkinManager MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        public static Session Current = new Session();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeMaterialManager();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            var loginFrm = new Login();
            loginFrm.Show();
            Application.Run();
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
