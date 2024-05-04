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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonRemoveFromCart = new Button();
            buttonAddToCart = new Button();
            textBoxQuantity = new TextBox();
            textBoxID = new TextBox();
            textBoxTotalPrice = new TextBox();
            buttonPlaceOrder = new Button();
            label2 = new Label();
            cartGrid = new DataGridView();
            label1 = new Label();
            productGrid = new DataGridView();
            customerMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productGrid).BeginInit();
            SuspendLayout();
            // 
            // customerMenu
            // 
            customerMenu.Items.AddRange(new ToolStripItem[] { customerMenuShowOrders });
            customerMenu.Location = new Point(0, 0);
            customerMenu.Name = "customerMenu";
            customerMenu.Size = new Size(539, 25);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonRemoveFromCart);
            groupBox1.Controls.Add(buttonAddToCart);
            groupBox1.Controls.Add(textBoxQuantity);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(textBoxTotalPrice);
            groupBox1.Controls.Add(buttonPlaceOrder);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cartGrid);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(productGrid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 355);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kreiraj narudzbu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 269);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 12;
            label5.Text = "Ukupna cijena:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 212);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 11;
            label4.Text = "Kolicina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 212);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 10;
            label3.Text = "ID:";
            // 
            // buttonRemoveFromCart
            // 
            buttonRemoveFromCart.Location = new Point(254, 244);
            buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            buttonRemoveFromCart.Size = new Size(56, 23);
            buttonRemoveFromCart.TabIndex = 9;
            buttonRemoveFromCart.Text = "Obrisi";
            buttonRemoveFromCart.UseVisualStyleBackColor = true;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(254, 215);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(56, 23);
            buttonAddToCart.TabIndex = 8;
            buttonAddToCart.Text = "Dodaj";
            buttonAddToCart.UseVisualStyleBackColor = true;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(379, 230);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(57, 23);
            textBoxQuantity.TabIndex = 7;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(316, 230);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(57, 23);
            textBoxID.TabIndex = 6;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(364, 287);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(140, 23);
            textBoxTotalPrice.TabIndex = 5;
            // 
            // buttonPlaceOrder
            // 
            buttonPlaceOrder.Location = new Point(364, 316);
            buttonPlaceOrder.Name = "buttonPlaceOrder";
            buttonPlaceOrder.Size = new Size(140, 33);
            buttonPlaceOrder.TabIndex = 4;
            buttonPlaceOrder.Text = "Kreiraj narudzbu";
            buttonPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 37);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Korpa:";
            // 
            // cartGrid
            // 
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Location = new Point(256, 55);
            cartGrid.Name = "cartGrid";
            cartGrid.Size = new Size(238, 126);
            cartGrid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Pregled artikala:";
            // 
            // productGrid
            // 
            productGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGrid.Location = new Point(29, 55);
            productGrid.Name = "productGrid";
            productGrid.Size = new Size(204, 282);
            productGrid.TabIndex = 0;
            // 
            // createOrderCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 408);
            Controls.Add(groupBox1);
            Controls.Add(customerMenu);
            Name = "createOrderCustomerForm";
            Text = "Kreiranje Narudzbe";
            Load += createOrderCustomerForm_Load;
            customerMenu.ResumeLayout(false);
            customerMenu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip customerMenu;
        private ToolStripButton customerMenuShowOrders;
        private GroupBox groupBox1;
        private TextBox textBoxQuantity;
        private TextBox textBoxID;
        private TextBox textBoxTotalPrice;
        private Button buttonPlaceOrder;
        private Label label2;
        private DataGridView cartGrid;
        private Label label1;
        private DataGridView productGrid;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonRemoveFromCart;
        private Button buttonAddToCart;
    }
}