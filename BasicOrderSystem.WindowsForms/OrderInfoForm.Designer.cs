namespace BasicOrderSystem.WindowsForms
{
    partial class OrderInfoForm
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
            OrderIDLabel = new Label();
            CustomerIDLabel = new Label();
            TotalLabel = new Label();
            Line1Label = new Label();
            SurnameLabel = new Label();
            ForenamesLabel = new Label();
            CityLabel = new Label();
            Line2Label = new Label();
            Postcode = new Label();
            EmailLabel = new Label();
            OrderDeliveredLabel = new Label();
            OrderPlacedLabel = new Label();
            OrderIDTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            TotalTextBox = new TextBox();
            OrderDeliveredDatePicker = new DateTimePicker();
            NotDeliveredRadioButton = new RadioButton();
            DeliveredRadioButton = new RadioButton();
            PostcodeTextBox = new TextBox();
            CityTextBox = new TextBox();
            Line2TextBox = new TextBox();
            Line1TextBox = new TextBox();
            ForenamesTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            CancelChangesButton = new Button();
            SaveChangesButton = new Button();
            OrderPlacedDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // OrderIDLabel
            // 
            OrderIDLabel.AutoSize = true;
            OrderIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            OrderIDLabel.Location = new Point(12, 9);
            OrderIDLabel.Name = "OrderIDLabel";
            OrderIDLabel.Size = new Size(51, 15);
            OrderIDLabel.TabIndex = 0;
            OrderIDLabel.Text = "Order ID";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CustomerIDLabel.Location = new Point(12, 53);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(73, 15);
            CustomerIDLabel.TabIndex = 9;
            CustomerIDLabel.Text = "Customer ID";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            TotalLabel.Location = new Point(12, 99);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(33, 15);
            TotalLabel.TabIndex = 11;
            TotalLabel.Text = "Total";
            // 
            // Line1Label
            // 
            Line1Label.AutoSize = true;
            Line1Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Line1Label.Location = new Point(222, 143);
            Line1Label.Name = "Line1Label";
            Line1Label.Size = new Size(83, 15);
            Line1Label.TabIndex = 12;
            Line1Label.Text = "Address Line 1";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            SurnameLabel.Location = new Point(222, 99);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(54, 15);
            SurnameLabel.TabIndex = 13;
            SurnameLabel.Text = "Surname";
            // 
            // ForenamesLabel
            // 
            ForenamesLabel.AutoSize = true;
            ForenamesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ForenamesLabel.Location = new Point(222, 53);
            ForenamesLabel.Name = "ForenamesLabel";
            ForenamesLabel.Size = new Size(65, 15);
            ForenamesLabel.TabIndex = 14;
            ForenamesLabel.Text = "Forenames";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CityLabel.Location = new Point(222, 231);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 15;
            CityLabel.Text = "City";
            // 
            // Line2Label
            // 
            Line2Label.AutoSize = true;
            Line2Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Line2Label.Location = new Point(222, 187);
            Line2Label.Name = "Line2Label";
            Line2Label.Size = new Size(83, 15);
            Line2Label.TabIndex = 16;
            Line2Label.Text = "Address Line 2";
            // 
            // Postcode
            // 
            Postcode.AutoSize = true;
            Postcode.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Postcode.Location = new Point(222, 274);
            Postcode.Name = "Postcode";
            Postcode.Size = new Size(56, 15);
            Postcode.TabIndex = 17;
            Postcode.Text = "Postcode";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(222, 9);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 18;
            EmailLabel.Text = "Email";
            // 
            // OrderDeliveredLabel
            // 
            OrderDeliveredLabel.AutoSize = true;
            OrderDeliveredLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            OrderDeliveredLabel.Location = new Point(12, 187);
            OrderDeliveredLabel.Name = "OrderDeliveredLabel";
            OrderDeliveredLabel.Size = new Size(116, 15);
            OrderDeliveredLabel.TabIndex = 19;
            OrderDeliveredLabel.Text = "Date Order Delivered";
            // 
            // OrderPlacedLabel
            // 
            OrderPlacedLabel.AutoSize = true;
            OrderPlacedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            OrderPlacedLabel.Location = new Point(12, 143);
            OrderPlacedLabel.Name = "OrderPlacedLabel";
            OrderPlacedLabel.Size = new Size(102, 15);
            OrderPlacedLabel.TabIndex = 20;
            OrderPlacedLabel.Text = "Date Order Placed";
            // 
            // OrderIDTextBox
            // 
            OrderIDTextBox.Enabled = false;
            OrderIDTextBox.Location = new Point(12, 27);
            OrderIDTextBox.Name = "OrderIDTextBox";
            OrderIDTextBox.Size = new Size(200, 23);
            OrderIDTextBox.TabIndex = 24;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Enabled = false;
            CustomerIDTextBox.Location = new Point(12, 71);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(200, 23);
            CustomerIDTextBox.TabIndex = 25;
            // 
            // TotalTextBox
            // 
            TotalTextBox.Enabled = false;
            TotalTextBox.Location = new Point(12, 117);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.Size = new Size(200, 23);
            TotalTextBox.TabIndex = 27;
            // 
            // OrderDeliveredDatePicker
            // 
            OrderDeliveredDatePicker.Location = new Point(12, 255);
            OrderDeliveredDatePicker.Name = "OrderDeliveredDatePicker";
            OrderDeliveredDatePicker.Size = new Size(200, 23);
            OrderDeliveredDatePicker.TabIndex = 29;
            // 
            // NotDeliveredRadioButton
            // 
            NotDeliveredRadioButton.AutoSize = true;
            NotDeliveredRadioButton.Location = new Point(12, 205);
            NotDeliveredRadioButton.Name = "NotDeliveredRadioButton";
            NotDeliveredRadioButton.Size = new Size(97, 19);
            NotDeliveredRadioButton.TabIndex = 30;
            NotDeliveredRadioButton.TabStop = true;
            NotDeliveredRadioButton.Text = "Not Delivered";
            NotDeliveredRadioButton.UseVisualStyleBackColor = true;
            NotDeliveredRadioButton.CheckedChanged += NotDeliveredRadioButton_CheckedChanged;
            // 
            // DeliveredRadioButton
            // 
            DeliveredRadioButton.AutoSize = true;
            DeliveredRadioButton.Location = new Point(11, 230);
            DeliveredRadioButton.Name = "DeliveredRadioButton";
            DeliveredRadioButton.Size = new Size(74, 19);
            DeliveredRadioButton.TabIndex = 31;
            DeliveredRadioButton.TabStop = true;
            DeliveredRadioButton.Text = "Delivered";
            DeliveredRadioButton.UseVisualStyleBackColor = true;
            DeliveredRadioButton.CheckedChanged += DeliveredRadioButton_CheckedChanged;
            // 
            // PostcodeTextBox
            // 
            PostcodeTextBox.Enabled = false;
            PostcodeTextBox.Location = new Point(222, 292);
            PostcodeTextBox.Name = "PostcodeTextBox";
            PostcodeTextBox.Size = new Size(200, 23);
            PostcodeTextBox.TabIndex = 32;
            // 
            // CityTextBox
            // 
            CityTextBox.Enabled = false;
            CityTextBox.Location = new Point(222, 249);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(200, 23);
            CityTextBox.TabIndex = 33;
            // 
            // Line2TextBox
            // 
            Line2TextBox.Enabled = false;
            Line2TextBox.Location = new Point(222, 205);
            Line2TextBox.Name = "Line2TextBox";
            Line2TextBox.Size = new Size(200, 23);
            Line2TextBox.TabIndex = 34;
            // 
            // Line1TextBox
            // 
            Line1TextBox.Enabled = false;
            Line1TextBox.Location = new Point(222, 161);
            Line1TextBox.Name = "Line1TextBox";
            Line1TextBox.Size = new Size(200, 23);
            Line1TextBox.TabIndex = 35;
            // 
            // ForenamesTextBox
            // 
            ForenamesTextBox.Enabled = false;
            ForenamesTextBox.Location = new Point(222, 71);
            ForenamesTextBox.Name = "ForenamesTextBox";
            ForenamesTextBox.Size = new Size(200, 23);
            ForenamesTextBox.TabIndex = 36;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Enabled = false;
            SurnameTextBox.Location = new Point(222, 117);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(200, 23);
            SurnameTextBox.TabIndex = 37;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Enabled = false;
            EmailTextBox.Location = new Point(222, 27);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(200, 23);
            EmailTextBox.TabIndex = 38;
            // 
            // CancelChangesButton
            // 
            CancelChangesButton.Location = new Point(12, 328);
            CancelChangesButton.Name = "CancelChangesButton";
            CancelChangesButton.Size = new Size(200, 25);
            CancelChangesButton.TabIndex = 39;
            CancelChangesButton.Text = "Cancel";
            CancelChangesButton.UseVisualStyleBackColor = true;
            CancelChangesButton.Click += CancelChangesButton_Click;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(222, 328);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(198, 25);
            SaveChangesButton.TabIndex = 40;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // OrderPlacedDatePicker
            // 
            OrderPlacedDatePicker.Location = new Point(12, 161);
            OrderPlacedDatePicker.Name = "OrderPlacedDatePicker";
            OrderPlacedDatePicker.Size = new Size(200, 23);
            OrderPlacedDatePicker.TabIndex = 41;
            // 
            // OrderInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 365);
            Controls.Add(OrderPlacedDatePicker);
            Controls.Add(SaveChangesButton);
            Controls.Add(CancelChangesButton);
            Controls.Add(EmailTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(ForenamesTextBox);
            Controls.Add(Line1TextBox);
            Controls.Add(Line2TextBox);
            Controls.Add(CityTextBox);
            Controls.Add(PostcodeTextBox);
            Controls.Add(DeliveredRadioButton);
            Controls.Add(NotDeliveredRadioButton);
            Controls.Add(OrderDeliveredDatePicker);
            Controls.Add(TotalTextBox);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(OrderIDTextBox);
            Controls.Add(OrderPlacedLabel);
            Controls.Add(OrderDeliveredLabel);
            Controls.Add(EmailLabel);
            Controls.Add(Postcode);
            Controls.Add(Line2Label);
            Controls.Add(CityLabel);
            Controls.Add(ForenamesLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(Line1Label);
            Controls.Add(TotalLabel);
            Controls.Add(CustomerIDLabel);
            Controls.Add(OrderIDLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderInfoForm";
            Text = "Order Information";
            Load += OrderInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrderIDLabel;
        private Label CustomerIDLabel;
        private Label TotalLabel;
        private Label Line1Label;
        private Label SurnameLabel;
        private Label ForenamesLabel;
        private Label CityLabel;
        private Label Line2Label;
        private Label Postcode;
        private Label EmailLabel;
        private Label OrderDeliveredLabel;
        private Label OrderPlacedLabel;
        private TextBox OrderIDTextBox;
        private TextBox CustomerIDTextBox;
        private TextBox TotalTextBox;
        private DateTimePicker OrderDeliveredDatePicker;
        private RadioButton NotDeliveredRadioButton;
        private RadioButton DeliveredRadioButton;
        private TextBox PostcodeTextBox;
        private TextBox CityTextBox;
        private TextBox Line2TextBox;
        private TextBox Line1TextBox;
        private TextBox ForenamesTextBox;
        private TextBox SurnameTextBox;
        private TextBox EmailTextBox;
        private Button CancelChangesButton;
        private Button SaveChangesButton;
        private DateTimePicker OrderPlacedDatePicker;
    }
}