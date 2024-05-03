namespace gr3_projektni_zadatak
{
    partial class CustomerForm
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
            customerMenu = new MenuStrip();
            newOrder = new ToolStripMenuItem();
            viewOrders = new ToolStripMenuItem();
            customerMenu.SuspendLayout();
            SuspendLayout();
            // 
            // customerMenu
            // 
            customerMenu.Items.AddRange(new ToolStripItem[] { newOrder, viewOrders });
            customerMenu.Location = new Point(0, 0);
            customerMenu.Name = "customerMenu";
            customerMenu.Size = new Size(314, 24);
            customerMenu.TabIndex = 0;
            customerMenu.Text = "menuStrip1";
            // 
            // newOrder
            // 
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(116, 20);
            newOrder.Text = "NOVA NARUDŽBA";
            // 
            // viewOrders
            // 
            viewOrders.Name = "viewOrders";
            viewOrders.Size = new Size(127, 20);
            viewOrders.Text = "PREGLED NARUDŽBI";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 211);
            Controls.Add(customerMenu);
            MainMenuStrip = customerMenu;
            Name = "CustomerForm";
            Text = "CustomerForm";
            customerMenu.ResumeLayout(false);
            customerMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip customerMenu;
        private ToolStripMenuItem newOrder;
        private ToolStripMenuItem viewOrders;
    }
}