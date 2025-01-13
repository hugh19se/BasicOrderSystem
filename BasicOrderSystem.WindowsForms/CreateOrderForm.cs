using Serilog;

namespace BasicOrderSystem.WindowsForms
{
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private async void CreateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if user entered customer ID and order totals are valid
                if (!int.TryParse(CustomerIDTextBox.Text, out int customerID) || !float.TryParse(OrderTotalTextBox.Text, out float total))
                {
                    MessageBox.Show("Please Enter Valid Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await Program.OrdersClient.CreateOrderAsync(total, customerID);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Order Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "EXCEPTION in " + nameof(CreateOrderButton_Click));
                MessageBox.Show("An Error Occurred While Creating Order:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}