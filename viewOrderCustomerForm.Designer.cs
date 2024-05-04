namespace gr3_projektni_zadatak
{
    partial class viewOrderCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewOrderCustomerForm));
            customerMenu = new ToolStrip();
            customerMenuCreateOrder = new ToolStripButton();
            groupBox1 = new GroupBox();
            buttonShowItems = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxTotalPrice = new TextBox();
            textBoxOrderID = new TextBox();
            itemGrid = new DataGridView();
            orderGrid = new DataGridView();
            customerMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderGrid).BeginInit();
            SuspendLayout();
            // 
            // customerMenu
            // 
            customerMenu.Items.AddRange(new ToolStripItem[] { customerMenuCreateOrder });
            customerMenu.Location = new Point(0, 0);
            customerMenu.Name = "customerMenu";
            customerMenu.Size = new Size(554, 25);
            customerMenu.TabIndex = 0;
            customerMenu.Text = "toolStrip1";
            // 
            // customerMenuCreateOrder
            // 
            customerMenuCreateOrder.DisplayStyle = ToolStripItemDisplayStyle.Text;
            customerMenuCreateOrder.Image = (Image)resources.GetObject("customerMenuCreateOrder.Image");
            customerMenuCreateOrder.ImageTransparentColor = Color.Magenta;
            customerMenuCreateOrder.Name = "customerMenuCreateOrder";
            customerMenuCreateOrder.Size = new Size(97, 22);
            customerMenuCreateOrder.Text = "Kreiraj narudzbu";
            customerMenuCreateOrder.Click += customerMenuCreateOrder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonShowItems);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxTotalPrice);
            groupBox1.Controls.Add(textBoxOrderID);
            groupBox1.Controls.Add(itemGrid);
            groupBox1.Controls.Add(orderGrid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 291);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pregled narudzbi";
            // 
            // buttonShowItems
            // 
            buttonShowItems.Location = new Point(451, 184);
            buttonShowItems.Name = "buttonShowItems";
            buttonShowItems.Size = new Size(74, 38);
            buttonShowItems.TabIndex = 7;
            buttonShowItems.Text = "Prikaz stavki";
            buttonShowItems.UseVisualStyleBackColor = true;
            buttonShowItems.Click += buttonShowItems_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 245);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 6;
            label3.Text = "KM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 245);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 196);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 4;
            label1.Text = "ID Narudzbe:";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(365, 242);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(80, 23);
            textBoxTotalPrice.TabIndex = 3;
            // 
            // textBoxOrderID
            // 
            textBoxOrderID.Location = new Point(365, 193);
            textBoxOrderID.Name = "textBoxOrderID";
            textBoxOrderID.Size = new Size(80, 23);
            textBoxOrderID.TabIndex = 2;
            // 
            // itemGrid
            // 
            itemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemGrid.Location = new Point(284, 35);
            itemGrid.Name = "itemGrid";
            itemGrid.Size = new Size(232, 141);
            itemGrid.TabIndex = 1;
            // 
            // orderGrid
            // 
            orderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGrid.Location = new Point(8, 35);
            orderGrid.Name = "orderGrid";
            orderGrid.Size = new Size(248, 230);
            orderGrid.TabIndex = 0;
            // 
            // viewOrderCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 352);
            Controls.Add(groupBox1);
            Controls.Add(customerMenu);
            Name = "viewOrderCustomerForm";
            Text = "Prikaz Narudzbi";
            Load += viewOrderCustomerForm_Load;
            customerMenu.ResumeLayout(false);
            customerMenu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip customerMenu;
        private ToolStripButton customerMenuCreateOrder;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxTotalPrice;
        private TextBox textBoxOrderID;
        private DataGridView itemGrid;
        private DataGridView orderGrid;
        private Button buttonShowItems;
        private Label label3;
        private Label label2;
    }
}