using artgallery_sgdb.UserControls;
using System.Runtime.CompilerServices;

namespace artgallery_sgdb {


    public static class Program {

        public static Login ventana;
        public static MainWindow mw;
        public static Visualizador vis;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ventana = new Login();

            Application.Run(ventana);
            
        }


    }
}