using BasicOrderSystem.Models;
using BasicOrderSystem.WebClients;
using BasicOrderSystem.WebContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace BasicOrderSystem.WindowsForms
{
    public partial class OrdersForm : Form
    {
        private string? AppBaseAddress;
        private OrdersClient OrdersClient;

        public OrdersForm()
        {
            //Check if API Base Address is populated before orders form can open
            AppBaseAddress = ConfigurationManager.AppSettings["OrderAPIBaseAddress"];
            while (string.IsNullOrEmpty(AppBaseAddress))
            {
                BaseAddressPromptForm baseAddressPromptForm = new();
                baseAddressPromptForm.ShowDialog();
                AppBaseAddress = ConfigurationManager.AppSettings["OrderAPIBaseAddress"];
            }
            OrdersClient = new OrdersClient(AppBaseAddress);

            InitializeComponent();
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            //Populate statuses combo box
            foreach (OrderStatuses status in Enum.GetValues(typeof(OrderStatuses)))
            {
                StatusComboBox.Items.Add(status);
            }
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if user has selected a status
                if (string.IsNullOrEmpty(StatusComboBox.Text))
                {
                    MessageBox.Show("Please Enter A Valid Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Make API call
                GetOrdersResponse? response = await OrdersClient.GetOrdersAsync();
                IList<Order> orders = response.Orders;

                //Iterate over orders, add to orderListViewItems
                List<ListViewItem> orderListViewItems = new();
                foreach (Order order in orders)
                {
                    ListViewItem orderItem = new();

                    orderItem.Text = order.OrderID.ToString();
                    orderItem.SubItems.Add(order.CustomerID.ToString());
                    orderItem.SubItems.Add(((OrderStatuses)order.Status).ToString());
                    orderItem.SubItems.Add("£" + order.Total.ToString());
                    orderItem.SubItems.Add(order.OrderPlaced.ToString());
                    orderItem.SubItems.Add(order.OrderDelivered.ToString());

                    orderListViewItems.Add(orderItem);
                }

                //Add new items to OrdersListView
                OrdersListView.BeginUpdate();
                OrdersListView.Items.Clear();
                OrdersListView.Items.AddRange(orderListViewItems.ToArray());
                OrdersListView.EndUpdate();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "EXCEPTION in " + nameof(SearchButton_Click));
                MessageBox.Show("An Error Occurred While Sending The API Request:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}