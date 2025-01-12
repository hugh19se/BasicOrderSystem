using BasicOrderSystem.WebClients;
using Serilog;
using System.Configuration;

namespace BasicOrderSystem.WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static OrdersClient OrdersClient;

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

            //Check if API Base Address is populated before forms can open
            string appBaseAddress = ConfigurationManager.AppSettings["OrderAPIBaseAddress"];
            while (string.IsNullOrEmpty(appBaseAddress))
            {
                BaseAddressPromptForm baseAddressPromptForm = new();
                baseAddressPromptForm.ShowDialog();
                appBaseAddress = ConfigurationManager.AppSettings["OrderAPIBaseAddress"];
            }
            OrdersClient = new OrdersClient(appBaseAddress);

            Application.Run(new OrdersForm());
        }
    }
}