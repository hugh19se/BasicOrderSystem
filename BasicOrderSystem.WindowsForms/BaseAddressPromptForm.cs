using BasicOrderSystem.WebClients;
using BasicOrderSystem.WebContracts;
using System.Configuration;
using Serilog;

namespace BasicOrderSystem.WindowsForms
{
    public partial class BaseAddressPromptForm : Form
    {
        public BaseAddressPromptForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if user entered API URL will work
                string baseAddress = BaseAddressTextBox.Text;

                using (OrdersClient ordersClient = new(baseAddress))
                {
                    GetCustomersResponse testRequest = await ordersClient.GetCustomersAsync();

                    if (testRequest.HasError)
                    {
                        MessageBox.Show("Could Not Establish Connection To The Web API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //API URL works, save it to App config
                Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                appConfig.AppSettings.Settings.Remove("OrderAPIBaseAddress");
                appConfig.AppSettings.Settings.Add("OrderAPIBaseAddress", baseAddress);
                appConfig.Save(ConfigurationSaveMode.Full);

                //Refresh app config
                ConfigurationManager.RefreshSection(appConfig.AppSettings.SectionInformation.Name);

                MessageBox.Show("API Base Address Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "EXCEPTION in " + nameof(OkButton_Click));
                MessageBox.Show("Could Not Establish Connection To The Web API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}