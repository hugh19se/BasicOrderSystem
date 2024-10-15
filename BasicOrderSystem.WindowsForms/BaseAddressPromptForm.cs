using BasicOrderSystem.WebClients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Exit();
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
            catch (Exception ex)
            {
                MessageBox.Show("Could Not Establish Connection To Web API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //API URL works, save it to App config
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            appConfig.AppSettings.Settings.Add("OrderAPIBaseAddress", baseAddress);
            appConfig.Save(ConfigurationSaveMode.Minimal);
            MessageBox.Show("API Base Address Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}