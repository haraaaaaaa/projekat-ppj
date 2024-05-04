namespace gr3_projektni_zadatak
{
    partial class createOrderCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createOrderCustomerForm));
            customerMenu = new ToolStrip();
            customerMenuShowOrders = new ToolStripButton();
            customerMenu.SuspendLayout();
            SuspendLayout();
            // 
            // customerMenu
            // 
            customerMenu.Items.AddRange(new ToolStripItem[] { customerMenuShowOrders });
            customerMenu.Location = new Point(0, 0);
            customerMenu.Name = "customerMenu";
            customerMenu.Size = new Size(314, 25);
            customerMenu.TabIndex = 0;
            customerMenu.Text = "toolStrip1";
            // 
            // customerMenuShowOrders
            // 
            customerMenuShowOrders.DisplayStyle = ToolStripItemDisplayStyle.Text;
            customerMenuShowOrders.Image = (Image)resources.GetObject("customerMenuShowOrders.Image");
            customerMenuShowOrders.ImageTransparentColor = Color.Magenta;
            customerMenuShowOrders.Name = "customerMenuShowOrders";
            customerMenuShowOrders.Size = new Size(93, 22);
            customerMenuShowOrders.Text = "Prikaz Narudzbi";
            // 
            // createOrderCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 211);
            Controls.Add(customerMenu);
            Name = "createOrderCustomerForm";
            Text = "Kreiranje Narudzbe";
            customerMenu.ResumeLayout(false);
            customerMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip customerMenu;
        private ToolStripButton customerMenuShowOrders;
    }
}