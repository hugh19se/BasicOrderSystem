using Serilog;
using System.Configuration;

namespace BasicOrderSystem.WindowsForms
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

            //Configure and create logger
            string loggingPath = ConfigurationManager.AppSettings["LoggingPath"];
            string loggingFormat = ConfigurationManager.AppSettings["LoggingFormat"];
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(loggingPath, outputTemplate: loggingFormat)
                .CreateLogger();

            Application.Run(new OrdersForm());
        }
    }
}