namespace BasicOrderSystem.WindowsForms
{
    partial class BaseAddressPromptForm
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
            EnterBaseAddressLabel = new Label();
            BaseAddressTextBox = new TextBox();
            OkButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // EnterBaseAddressLabel
            // 
            EnterBaseAddressLabel.AutoSize = true;
            EnterBaseAddressLabel.Location = new Point(12, 9);
            EnterBaseAddressLabel.Name = "EnterBaseAddressLabel";
            EnterBaseAddressLabel.Size = new Size(376, 15);
            EnterBaseAddressLabel.TabIndex = 0;
            EnterBaseAddressLabel.Text = "API Base Address Was Not Found In App.Config. Please Enter It Below:";
            // 
            // BaseAddressTextBox
            // 
            BaseAddressTextBox.Location = new Point(12, 27);
            BaseAddressTextBox.Name = "BaseAddressTextBox";
            BaseAddressTextBox.Size = new Size(376, 23);
            BaseAddressTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(206, 56);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(68, 23);
            OkButton.TabIndex = 2;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(280, 56);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(108, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit Application";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // BaseAddressPromptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 87);
            ControlBox = false;
            Controls.Add(ExitButton);
            Controls.Add(OkButton);
            Controls.Add(BaseAddressTextBox);
            Controls.Add(EnterBaseAddressLabel);
            Name = "BaseAddressPromptForm";
            Text = "Enter Base Address";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EnterBaseAddressLabel;
        private TextBox BaseAddressTextBox;
        private Button OkButton;
        private Button ExitButton;
    }
}