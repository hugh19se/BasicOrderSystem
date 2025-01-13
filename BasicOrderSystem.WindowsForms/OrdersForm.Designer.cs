namespace BasicOrderSystem.WindowsForms
{
    partial class OrdersForm
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
            components = new System.ComponentModel.Container();
            FromDatePicker = new DateTimePicker();
            ToDatePicker = new DateTimePicker();
            FromLabel = new Label();
            ToLabel = new Label();
            StatusComboBox = new ComboBox();
            StatusLabel = new Label();
            SearchButton = new Button();
            OrdersListView = new ListView();
            OrderIDHeader = new ColumnHeader();
            CustomerIDHeader = new ColumnHeader();
            StatusHeader = new ColumnHeader();
            TotalHeader = new ColumnHeader();
            OrderPlacedHeader = new ColumnHeader();
            OrderDeliveredHeader = new ColumnHeader();
            OrdersContextMenu = new ContextMenuStrip(components);
            OrderInfoMenuItem = new ToolStripMenuItem();
            DeleteOrderMenuItem = new ToolStripMenuItem();
            CreateOrderButton = new Button();
            OrdersContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // FromDatePicker
            // 
            FromDatePicker.Location = new Point(12, 27);
            FromDatePicker.Name = "FromDatePicker";
            FromDatePicker.Size = new Size(200, 23);
            FromDatePicker.TabIndex = 0;
            // 
            // ToDatePicker
            // 
            ToDatePicker.Location = new Point(218, 27);
            ToDatePicker.Name = "ToDatePicker";
            ToDatePicker.Size = new Size(200, 23);
            ToDatePicker.TabIndex = 1;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(12, 9);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(35, 15);
            FromLabel.TabIndex = 2;
            FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(218, 9);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(20, 15);
            ToLabel.TabIndex = 3;
            ToLabel.Text = "To";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(424, 27);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(93, 23);
            StatusComboBox.TabIndex = 4;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(424, 9);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Status";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(523, 26);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // OrdersListView
            // 
            OrdersListView.Columns.AddRange(new ColumnHeader[] { OrderIDHeader, CustomerIDHeader, StatusHeader, TotalHeader, OrderPlacedHeader, OrderDeliveredHeader });
            OrdersListView.ContextMenuStrip = OrdersContextMenu;
            OrdersListView.FullRowSelect = true;
            OrdersListView.Location = new Point(12, 56);
            OrdersListView.MultiSelect = false;
            OrdersListView.Name = "OrdersListView";
            OrdersListView.Size = new Size(776, 226);
            OrdersListView.TabIndex = 7;
            OrdersListView.UseCompatibleStateImageBehavior = false;
            OrdersListView.View = View.Details;
            // 
            // OrderIDHeader
            // 
            OrderIDHeader.Text = "Order ID";
            // 
            // CustomerIDHeader
            // 
            CustomerIDHeader.Text = "Customer ID";
            CustomerIDHeader.Width = 80;
            // 
            // StatusHeader
            // 
            StatusHeader.Text = "Status";
            StatusHeader.Width = 70;
            // 
            // TotalHeader
            // 
            TotalHeader.Text = "Order Total";
            TotalHeader.Width = 80;
            // 
            // OrderPlacedHeader
            // 
            OrderPlacedHeader.Text = "Order Placed";
            OrderPlacedHeader.Width = 145;
            // 
            // OrderDeliveredHeader
            // 
            OrderDeliveredHeader.Text = "Order Delivered";
            OrderDeliveredHeader.Width = 145;
            // 
            // OrdersContextMenu
            // 
            OrdersContextMenu.Items.AddRange(new ToolStripItem[] { OrderInfoMenuItem, DeleteOrderMenuItem });
            OrdersContextMenu.Name = "OrdersContextMenu";
            OrdersContextMenu.Size = new Size(141, 48);
            // 
            // OrderInfoMenuItem
            // 
            OrderInfoMenuItem.Name = "OrderInfoMenuItem";
            OrderInfoMenuItem.Size = new Size(140, 22);
            OrderInfoMenuItem.Text = "Order Info";
            OrderInfoMenuItem.Click += OrderInfoMenuItem_Click;
            // 
            // DeleteOrderMenuItem
            // 
            DeleteOrderMenuItem.Name = "DeleteOrderMenuItem";
            DeleteOrderMenuItem.Size = new Size(140, 22);
            DeleteOrderMenuItem.Text = "Delete Order";
            DeleteOrderMenuItem.Click += DeleteOrderMenuItem_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(12, 288);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(97, 23);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateOrderButton);
            Controls.Add(OrdersListView);
            Controls.Add(SearchButton);
            Controls.Add(StatusLabel);
            Controls.Add(StatusComboBox);
            Controls.Add(ToLabel);
            Controls.Add(FromLabel);
            Controls.Add(ToDatePicker);
            Controls.Add(FromDatePicker);
            Name = "OrdersForm";
            Text = "Orders";
            Load += OrdersForm_Load;
            OrdersContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker FromDatePicker;
        private DateTimePicker ToDatePicker;
        private Label FromLabel;
        private Label ToLabel;
        private ComboBox StatusComboBox;
        private Label StatusLabel;
        private Button SearchButton;
        private ListView OrdersListView;
        private ColumnHeader OrderIDHeader;
        private ColumnHeader CustomerIDHeader;
        private ColumnHeader StatusHeader;
        private ColumnHeader TotalHeader;
        private ColumnHeader OrderPlacedHeader;
        private ColumnHeader OrderDeliveredHeader;
        private ContextMenuStrip OrdersContextMenu;
        private ToolStripMenuItem OrderInfoMenuItem;
        private ToolStripMenuItem DeleteOrderMenuItem;
        private Button CreateOrderButton;
    }
}