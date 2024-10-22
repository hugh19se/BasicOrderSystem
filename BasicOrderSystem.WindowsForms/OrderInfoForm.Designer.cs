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
            OrderIDLabel.Location = new Point(22, 19);
            OrderIDLabel.Margin = new Padding(6, 0, 6, 0);
            OrderIDLabel.Name = "OrderIDLabel";
            OrderIDLabel.Size = new Size(105, 32);
            OrderIDLabel.TabIndex = 0;
            OrderIDLabel.Text = "Order ID";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CustomerIDLabel.Location = new Point(22, 113);
            CustomerIDLabel.Margin = new Padding(6, 0, 6, 0);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(147, 32);
            CustomerIDLabel.TabIndex = 9;
            CustomerIDLabel.Text = "Customer ID";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            TotalLabel.Location = new Point(22, 211);
            TotalLabel.Margin = new Padding(6, 0, 6, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(65, 32);
            TotalLabel.TabIndex = 11;
            TotalLabel.Text = "Total";
            // 
            // Line1Label
            // 
            Line1Label.AutoSize = true;
            Line1Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Line1Label.Location = new Point(412, 305);
            Line1Label.Margin = new Padding(6, 0, 6, 0);
            Line1Label.Name = "Line1Label";
            Line1Label.Size = new Size(169, 32);
            Line1Label.TabIndex = 12;
            Line1Label.Text = "Address Line 1";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            SurnameLabel.Location = new Point(412, 211);
            SurnameLabel.Margin = new Padding(6, 0, 6, 0);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(109, 32);
            SurnameLabel.TabIndex = 13;
            SurnameLabel.Text = "Surname";
            // 
            // ForenamesLabel
            // 
            ForenamesLabel.AutoSize = true;
            ForenamesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ForenamesLabel.Location = new Point(412, 113);
            ForenamesLabel.Margin = new Padding(6, 0, 6, 0);
            ForenamesLabel.Name = "ForenamesLabel";
            ForenamesLabel.Size = new Size(131, 32);
            ForenamesLabel.TabIndex = 14;
            ForenamesLabel.Text = "Forenames";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CityLabel.Location = new Point(412, 493);
            CityLabel.Margin = new Padding(6, 0, 6, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(55, 32);
            CityLabel.TabIndex = 15;
            CityLabel.Text = "City";
            // 
            // Line2Label
            // 
            Line2Label.AutoSize = true;
            Line2Label.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Line2Label.Location = new Point(412, 399);
            Line2Label.Margin = new Padding(6, 0, 6, 0);
            Line2Label.Name = "Line2Label";
            Line2Label.Size = new Size(169, 32);
            Line2Label.TabIndex = 16;
            Line2Label.Text = "Address Line 2";
            // 
            // Postcode
            // 
            Postcode.AutoSize = true;
            Postcode.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Postcode.Location = new Point(412, 585);
            Postcode.Margin = new Padding(6, 0, 6, 0);
            Postcode.Name = "Postcode";
            Postcode.Size = new Size(110, 32);
            Postcode.TabIndex = 17;
            Postcode.Text = "Postcode";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(412, 19);
            EmailLabel.Margin = new Padding(6, 0, 6, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(71, 32);
            EmailLabel.TabIndex = 18;
            EmailLabel.Text = "Email";
            // 
            // OrderDeliveredLabel
            // 
            OrderDeliveredLabel.AutoSize = true;
            OrderDeliveredLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            OrderDeliveredLabel.Location = new Point(22, 399);
            OrderDeliveredLabel.Margin = new Padding(6, 0, 6, 0);
            OrderDeliveredLabel.Name = "OrderDeliveredLabel";
            OrderDeliveredLabel.Size = new Size(241, 32);
            OrderDeliveredLabel.TabIndex = 19;
            OrderDeliveredLabel.Text = "Date Order Delivered";
            // 
            // OrderPlacedLabel
            // 
            OrderPlacedLabel.AutoSize = true;
            OrderPlacedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            OrderPlacedLabel.Location = new Point(22, 305);
            OrderPlacedLabel.Margin = new Padding(6, 0, 6, 0);
            OrderPlacedLabel.Name = "OrderPlacedLabel";
            OrderPlacedLabel.Size = new Size(208, 32);
            OrderPlacedLabel.TabIndex = 20;
            OrderPlacedLabel.Text = "Date Order Placed";
            // 
            // OrderIDTextBox
            // 
            OrderIDTextBox.Enabled = false;
            OrderIDTextBox.Location = new Point(22, 58);
            OrderIDTextBox.Margin = new Padding(6);
            OrderIDTextBox.Name = "OrderIDTextBox";
            OrderIDTextBox.Size = new Size(368, 39);
            OrderIDTextBox.TabIndex = 24;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Enabled = false;
            CustomerIDTextBox.Location = new Point(22, 151);
            CustomerIDTextBox.Margin = new Padding(6);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(368, 39);
            CustomerIDTextBox.TabIndex = 25;
            // 
            // TotalTextBox
            // 
            TotalTextBox.Enabled = false;
            TotalTextBox.Location = new Point(22, 250);
            TotalTextBox.Margin = new Padding(6);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.Size = new Size(368, 39);
            TotalTextBox.TabIndex = 27;
            // 
            // OrderDeliveredDatePicker
            // 
            OrderDeliveredDatePicker.Location = new Point(22, 544);
            OrderDeliveredDatePicker.Margin = new Padding(6);
            OrderDeliveredDatePicker.Name = "OrderDeliveredDatePicker";
            OrderDeliveredDatePicker.Size = new Size(368, 39);
            OrderDeliveredDatePicker.TabIndex = 29;
            // 
            // NotDeliveredRadioButton
            // 
            NotDeliveredRadioButton.AutoSize = true;
            NotDeliveredRadioButton.Location = new Point(22, 437);
            NotDeliveredRadioButton.Margin = new Padding(6);
            NotDeliveredRadioButton.Name = "NotDeliveredRadioButton";
            NotDeliveredRadioButton.Size = new Size(194, 36);
            NotDeliveredRadioButton.TabIndex = 30;
            NotDeliveredRadioButton.TabStop = true;
            NotDeliveredRadioButton.Text = "Not Delivered";
            NotDeliveredRadioButton.UseVisualStyleBackColor = true;
            NotDeliveredRadioButton.CheckedChanged += NotDeliveredRadioButton_CheckedChanged;
            // 
            // DeliveredRadioButton
            // 
            DeliveredRadioButton.AutoSize = true;
            DeliveredRadioButton.Location = new Point(20, 491);
            DeliveredRadioButton.Margin = new Padding(6);
            DeliveredRadioButton.Name = "DeliveredRadioButton";
            DeliveredRadioButton.Size = new Size(147, 36);
            DeliveredRadioButton.TabIndex = 31;
            DeliveredRadioButton.TabStop = true;
            DeliveredRadioButton.Text = "Delivered";
            DeliveredRadioButton.UseVisualStyleBackColor = true;
            DeliveredRadioButton.CheckedChanged += DeliveredRadioButton_CheckedChanged;
            // 
            // PostcodeTextBox
            // 
            PostcodeTextBox.Enabled = false;
            PostcodeTextBox.Location = new Point(412, 623);
            PostcodeTextBox.Margin = new Padding(6);
            PostcodeTextBox.Name = "PostcodeTextBox";
            PostcodeTextBox.Size = new Size(368, 39);
            PostcodeTextBox.TabIndex = 32;
            // 
            // CityTextBox
            // 
            CityTextBox.Enabled = false;
            CityTextBox.Location = new Point(412, 531);
            CityTextBox.Margin = new Padding(6);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(368, 39);
            CityTextBox.TabIndex = 33;
            // 
            // Line2TextBox
            // 
            Line2TextBox.Enabled = false;
            Line2TextBox.Location = new Point(412, 437);
            Line2TextBox.Margin = new Padding(6);
            Line2TextBox.Name = "Line2TextBox";
            Line2TextBox.Size = new Size(368, 39);
            Line2TextBox.TabIndex = 34;
            // 
            // Line1TextBox
            // 
            Line1TextBox.Enabled = false;
            Line1TextBox.Location = new Point(412, 343);
            Line1TextBox.Margin = new Padding(6);
            Line1TextBox.Name = "Line1TextBox";
            Line1TextBox.Size = new Size(368, 39);
            Line1TextBox.TabIndex = 35;
            // 
            // ForenamesTextBox
            // 
            ForenamesTextBox.Enabled = false;
            ForenamesTextBox.Location = new Point(412, 151);
            ForenamesTextBox.Margin = new Padding(6);
            ForenamesTextBox.Name = "ForenamesTextBox";
            ForenamesTextBox.Size = new Size(368, 39);
            ForenamesTextBox.TabIndex = 36;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Enabled = false;
            SurnameTextBox.Location = new Point(412, 250);
            SurnameTextBox.Margin = new Padding(6);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(368, 39);
            SurnameTextBox.TabIndex = 37;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Enabled = false;
            EmailTextBox.Location = new Point(412, 58);
            EmailTextBox.Margin = new Padding(6);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(368, 39);
            EmailTextBox.TabIndex = 38;
            // 
            // CancelChangesButton
            // 
            CancelChangesButton.Location = new Point(22, 700);
            CancelChangesButton.Margin = new Padding(6);
            CancelChangesButton.Name = "CancelChangesButton";
            CancelChangesButton.Size = new Size(371, 53);
            CancelChangesButton.TabIndex = 39;
            CancelChangesButton.Text = "Cancel";
            CancelChangesButton.UseVisualStyleBackColor = true;
            CancelChangesButton.Click += CancelChangesButton_Click;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(412, 700);
            SaveChangesButton.Margin = new Padding(6);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(368, 53);
            SaveChangesButton.TabIndex = 40;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // OrderPlacedDatePicker
            // 
            OrderPlacedDatePicker.Location = new Point(22, 343);
            OrderPlacedDatePicker.Margin = new Padding(6);
            OrderPlacedDatePicker.Name = "OrderPlacedDatePicker";
            OrderPlacedDatePicker.Size = new Size(368, 39);
            OrderPlacedDatePicker.TabIndex = 41;
            // 
            // OrderInfoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 779);
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
            Margin = new Padding(6);
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