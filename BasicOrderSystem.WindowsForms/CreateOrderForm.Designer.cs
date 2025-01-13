namespace BasicOrderSystem.WindowsForms
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CustomerIDLabel = new Label();
            CustomerIDTextBox = new TextBox();
            OrderTotalLabel = new Label();
            OrderTotalTextBox = new TextBox();
            CreateOrderButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CustomerIDLabel.Location = new Point(12, 9);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(73, 15);
            CustomerIDLabel.TabIndex = 1;
            CustomerIDLabel.Text = "Customer ID";
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(12, 27);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(225, 23);
            CustomerIDTextBox.TabIndex = 25;
            // 
            // OrderTotalLabel
            // 
            OrderTotalLabel.AutoSize = true;
            OrderTotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            OrderTotalLabel.Location = new Point(12, 53);
            OrderTotalLabel.Name = "OrderTotalLabel";
            OrderTotalLabel.Size = new Size(66, 15);
            OrderTotalLabel.TabIndex = 26;
            OrderTotalLabel.Text = "Order Total";
            // 
            // OrderTotalTextBox
            // 
            OrderTotalTextBox.Location = new Point(12, 71);
            OrderTotalTextBox.Name = "OrderTotalTextBox";
            OrderTotalTextBox.Size = new Size(225, 23);
            OrderTotalTextBox.TabIndex = 27;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(10, 100);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(227, 23);
            CreateOrderButton.TabIndex = 28;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(10, 129);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(227, 23);
            CancelButton.TabIndex = 29;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 162);
            Controls.Add(CancelButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(OrderTotalTextBox);
            Controls.Add(OrderTotalLabel);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(CustomerIDLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateOrderForm";
            Text = "Create Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CustomerIDLabel;
        private TextBox CustomerIDTextBox;
        private Label OrderTotalLabel;
        private TextBox OrderTotalTextBox;
        private Button CreateOrderButton;
        private Button CancelButton;
    }
}