using BasicOrderSystem.Models;
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
            Close();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            //save info

            MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
