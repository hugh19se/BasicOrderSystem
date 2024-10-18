using BasicOrderSystem.WebClients;
using System.Configuration;

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
            //Check if user entered API URL will work
            string baseAddress = BaseAddressTextBox.Text;
            try
            {
                OrdersClient ordersClient = new(baseAddress);

                var testRequest = await ordersClient.GetCustomersAsync();
                if (testRequest.HasError)
                {
                    MessageBox.Show("Could Not Establish Connection To Web API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Establish Connection To Web API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //API URL works, save it to App config
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appConfig.AppSettings.Settings.Remove("OrderAPIBaseAddress");
            appConfig.AppSettings.Settings.Add("OrderAPIBaseAddress", baseAddress);
            appConfig.Save(ConfigurationSaveMode.Full);

            //Refresh app config
            ConfigurationManager.RefreshSection(appConfig.AppSettings.SectionInformation.Name);

            MessageBox.Show("API Base Address Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}