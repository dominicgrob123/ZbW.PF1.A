using MB02.A3_1;
namespace MB02
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
            
            
            //Application.Run(new A3_1_1());
            Application.Run(new A3_1_2());
        }
    }
}