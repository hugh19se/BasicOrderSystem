using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (!int.TryParse(CustomerIDTextBox.Text, out int customerID) || !float.TryParse(OrderTotalTextBox.Text, out float total))
            {
                MessageBox.Show("Please Enter Valid Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await Program.OrdersClient.CreateOrderAsync(total, customerID);
            DialogResult = DialogResult.OK;
            MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
