using System.Collections;

namespace libraryManagementSystem
{

    public static class GlobalData
    {

        public static ArrayList books = new ArrayList();

        public static ArrayList members = new ArrayList();


    }


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}