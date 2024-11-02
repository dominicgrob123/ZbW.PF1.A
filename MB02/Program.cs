using MB02.A3_1;
using MB02.A4_1;
using MB02.A4_2;
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
            //Application.Run(new A3_1_2());
            //Application.Run(new A3_1_6());
            //Application.Run(new A4_1_4());
            //Application.Run(new A4_2_1());
            Application.Run(new A4_2_2());
        }
    }
}