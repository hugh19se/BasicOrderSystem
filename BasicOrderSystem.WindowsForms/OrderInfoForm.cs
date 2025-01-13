using BasicOrderSystem.Models;

namespace BasicOrderSystem.WindowsForms
{
    public partial class OrderInfoForm : Form
    {
        private readonly Order OrderInfo;
        private readonly Customer CustomerInfo;
        public OrderInfoForm(Order orderInfo, Customer customerInfo)
        {
            OrderInfo = orderInfo;
            CustomerInfo = customerInfo;

            InitializeComponent();
        }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {
            //Set Order info fields
            OrderIDTextBox.Text = OrderInfo.OrderID.ToString();
            CustomerIDTextBox.Text = OrderInfo.CustomerID.ToString();
            TotalTextBox.Text = "£" + OrderInfo.Total.ToString();
            OrderPlacedDatePicker.Value = OrderInfo.OrderPlaced;
            //Set up status radio buttons
            switch (OrderInfo.Status)
            {
                case OrderStatus.Created:
                    NotDeliveredRadioButton.Checked = true;
                    OrderDeliveredDatePicker.Enabled = false;
                    break;
                case OrderStatus.Delivered:
                    DeliveredRadioButton.Checked = true;
                    OrderDeliveredDatePicker.Value = OrderInfo.OrderDelivered ?? DateTime.MinValue;
                    break;
            }

            //Set Customer info fields
            EmailTextBox.Text = CustomerInfo.Email;
            ForenamesTextBox.Text = CustomerInfo.Forenames;
            SurnameTextBox.Text = CustomerInfo.Surname;
            Line1TextBox.Text = CustomerInfo.Line1;
            Line2TextBox.Text = CustomerInfo.Line2;
            CityTextBox.Text = CustomerInfo.City;
            PostcodeTextBox.Text = CustomerInfo.Postcode;
        }
        private void NotDeliveredRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OrderDeliveredDatePicker.Enabled = false;
        }
        private void DeliveredRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OrderDeliveredDatePicker.Enabled = true;
        }
        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void SaveChangesButton_Click(object sender, EventArgs e)
        {
            //Determine order status
            OrderStatus orderStatus = OrderStatus.Created;
            DateTime? dateDelivered = null;
            if (DeliveredRadioButton.Checked)
            {
                orderStatus = OrderStatus.Delivered;
                dateDelivered = OrderDeliveredDatePicker.Value;

            }

            await Program.OrdersClient.UpdateOrderInfoAsync(OrderInfo.OrderID, orderStatus, dateDelivered);
            DialogResult = DialogResult.OK;
            MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
