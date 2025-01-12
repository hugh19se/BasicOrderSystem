using BasicOrderSystem.Models;
using BasicOrderSystem.WebClients;
using BasicOrderSystem.WebContracts;
using Serilog;
using System.Configuration;

namespace BasicOrderSystem.WindowsForms
{
    public partial class OrdersForm : Form
    {
        private string? AppBaseAddress;

        public OrdersForm()
        {
            InitializeComponent();
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            //Populate statuses combo box
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadOrderData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "EXCEPTION in " + nameof(SearchButton_Click));
                MessageBox.Show("An Error Occurred While Searching For Orders:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void OrderInfoMenuItem_Click(object sender, EventArgs e)
        {
            //Get Order Info
            ListViewItem? selectedOrderItem = OrdersListView.SelectedItems[0];
            int orderID = Convert.ToInt32(selectedOrderItem.SubItems[0].Text);
            GetOrderInfoResponse orderInfo = await Program.OrdersClient.GetOrderInfoAsync(orderID);

            //Open Order Info Form
            OrderInfoForm orderInfoForm = new(orderInfo.OrderInfo.Order, orderInfo.OrderInfo.Customer);
            orderInfoForm.ShowDialog();

            //Check if order info form exited with the Save Changes button
            if (orderInfoForm.DialogResult == DialogResult.OK)
            {
                //Reload form info
                await LoadOrderData();
            }
        }

        private async Task LoadOrderData()
        {
            try
            {
                //Check if user has selected a status
                if (!Enum.TryParse(StatusComboBox.Text, out OrderStatus orderStatus) && string.IsNullOrEmpty(StatusComboBox.Text))
                {
                    MessageBox.Show("Please Enter A Valid Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Make API call
                GetOrdersResponse? response = await Program.OrdersClient.GetOrdersAsync(FromDatePicker.Value, ToDatePicker.Value, orderStatus);
                IList<Order> orders = response.Orders;

                //Iterate over orders, add to orderListViewItems
                List<ListViewItem> orderListViewItems = new();
                foreach (Order order in orders)
                {
                    ListViewItem orderItem = new();

                    orderItem.Text = order.OrderID.ToString();
                    orderItem.SubItems.Add(order.CustomerID.ToString());
                    orderItem.SubItems.Add(order.Status.ToString());
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
                Log.Error(ex, "EXCEPTION in " + nameof(LoadOrderData));
                MessageBox.Show("An Error Occurred While Sending The API Request:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}