namespace gr3_projektni_zadatak
{
    partial class AdminForm
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
            adminMenu = new MenuStrip();
            customers = new ToolStripMenuItem();
            products = new ToolStripMenuItem();
            orders = new ToolStripMenuItem();
            adminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // adminMenu
            // 
            adminMenu.Items.AddRange(new ToolStripItem[] { customers, products, orders });
            adminMenu.Location = new Point(0, 0);
            adminMenu.Name = "adminMenu";
            adminMenu.Size = new Size(314, 24);
            adminMenu.TabIndex = 0;
            adminMenu.Text = "menuStrip1";
            // 
            // customers
            // 
            customers.Name = "customers";
            customers.Size = new Size(52, 20);
            customers.Text = "KUPCI";
            // 
            // products
            // 
            products.Name = "products";
            products.Size = new Size(58, 20);
            products.Text = "ARTIKLI";
            // 
            // orders
            // 
            orders.Name = "orders";
            orders.Size = new Size(79, 20);
            orders.Text = "NARUDŽBE";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 211);
            Controls.Add(adminMenu);
            MainMenuStrip = adminMenu;
            Name = "AdminForm";
            Text = "AdminForm";
            adminMenu.ResumeLayout(false);
            adminMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip adminMenu;
        private ToolStripMenuItem customers;
        private ToolStripMenuItem products;
        private ToolStripMenuItem orders;
    }
}