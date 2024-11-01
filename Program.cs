using MB01.A1_2;

namespace MB01
{
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


            //Application.Run(new A1_2_1());
            //Application.Run(new A1_2_2());
            //Application.Run(new A1_2_3());
            Application.Run(new A1_2_4cs());
        }
    }
}