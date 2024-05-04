namespace gr3_projektni_zadatak
{
    partial class productManagementAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productManagementAdminForm));
            adminMenu = new ToolStrip();
            adminMenuUsers = new ToolStripButton();
            adminMenuOrders = new ToolStripButton();
            groupBox = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonUpdateProduct = new Button();
            buttonCreateProduct = new Button();
            buttonSearch = new Button();
            addQuantity = new NumericUpDown();
            textBoxID = new TextBox();
            textBoxType = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxTitle = new TextBox();
            productGridView = new DataGridView();
            textBoxTitleSearch = new TextBox();
            textBoxIDSearch = new TextBox();
            adminMenu.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // adminMenu
            // 
            adminMenu.Items.AddRange(new ToolStripItem[] { adminMenuUsers, adminMenuOrders });
            adminMenu.Location = new Point(0, 0);
            adminMenu.Name = "adminMenu";
            adminMenu.Size = new Size(535, 25);
            adminMenu.TabIndex = 0;
            adminMenu.Text = "toolStrip1";
            // 
            // adminMenuUsers
            // 
            adminMenuUsers.DisplayStyle = ToolStripItemDisplayStyle.Text;
            adminMenuUsers.Image = (Image)resources.GetObject("adminMenuUsers.Image");
            adminMenuUsers.ImageTransparentColor = Color.Magenta;
            adminMenuUsers.Name = "adminMenuUsers";
            adminMenuUsers.Size = new Size(121, 22);
            adminMenuUsers.Text = "Upravljaj korisnicima";
            adminMenuUsers.Click += adminMenuUsers_Click;
            // 
            // adminMenuOrders
            // 
            adminMenuOrders.DisplayStyle = ToolStripItemDisplayStyle.Text;
            adminMenuOrders.Image = (Image)resources.GetObject("adminMenuOrders.Image");
            adminMenuOrders.ImageTransparentColor = Color.Magenta;
            adminMenuOrders.Name = "adminMenuOrders";
            adminMenuOrders.Size = new Size(126, 22);
            adminMenuOrders.Text = "Upravljaj narudzbama";
            adminMenuOrders.Click += adminMenuOrders_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(buttonUpdateProduct);
            groupBox.Controls.Add(buttonCreateProduct);
            groupBox.Controls.Add(buttonSearch);
            groupBox.Controls.Add(addQuantity);
            groupBox.Controls.Add(textBoxID);
            groupBox.Controls.Add(textBoxType);
            groupBox.Controls.Add(textBoxPrice);
            groupBox.Controls.Add(textBoxQuantity);
            groupBox.Controls.Add(textBoxTitle);
            groupBox.Controls.Add(productGridView);
            groupBox.Controls.Add(textBoxTitleSearch);
            groupBox.Controls.Add(textBoxIDSearch);
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(12, 51);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(508, 433);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Dodavanje / Azuriranje Artikala";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 345);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 17;
            label6.Text = "Dodaj kolicinu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 316);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 16;
            label5.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 374);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 15;
            label4.Text = "Kolicina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 345);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "Cijena:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 316);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Vrsta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 284);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 12;
            label1.Text = "Naziv:";
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.Location = new Point(326, 400);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(113, 23);
            buttonUpdateProduct.TabIndex = 11;
            buttonUpdateProduct.Text = "Azuriraj artikal";
            buttonUpdateProduct.UseVisualStyleBackColor = true;
            buttonUpdateProduct.Click += buttonUpdateProduct_Click;
            // 
            // buttonCreateProduct
            // 
            buttonCreateProduct.Location = new Point(109, 400);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.Size = new Size(113, 23);
            buttonCreateProduct.TabIndex = 10;
            buttonCreateProduct.Text = "Dodaj artikal";
            buttonCreateProduct.UseVisualStyleBackColor = true;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(183, 36);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(95, 23);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Trazi artikle";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // addQuantity
            // 
            addQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addQuantity.Location = new Point(361, 343);
            addQuantity.Name = "addQuantity";
            addQuantity.Size = new Size(78, 23);
            addQuantity.TabIndex = 8;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(361, 313);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(78, 23);
            textBoxID.TabIndex = 7;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(109, 313);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(113, 23);
            textBoxType.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(109, 342);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(113, 23);
            textBoxPrice.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(109, 371);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(113, 23);
            textBoxQuantity.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(109, 284);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(113, 23);
            textBoxTitle.TabIndex = 3;
            // 
            // productGridView
            // 
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Location = new Point(13, 82);
            productGridView.Name = "productGridView";
            productGridView.Size = new Size(481, 171);
            productGridView.TabIndex = 2;
            // 
            // textBoxTitleSearch
            // 
            textBoxTitleSearch.Location = new Point(58, 36);
            textBoxTitleSearch.Name = "textBoxTitleSearch";
            textBoxTitleSearch.PlaceholderText = "Naziv artikla";
            textBoxTitleSearch.Size = new Size(113, 23);
            textBoxTitleSearch.TabIndex = 1;
            // 
            // textBoxIDSearch
            // 
            textBoxIDSearch.Location = new Point(19, 36);
            textBoxIDSearch.Name = "textBoxIDSearch";
            textBoxIDSearch.PlaceholderText = "ID";
            textBoxIDSearch.Size = new Size(33, 23);
            textBoxIDSearch.TabIndex = 0;
            // 
            // productManagementAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 510);
            Controls.Add(groupBox);
            Controls.Add(adminMenu);
            Name = "productManagementAdminForm";
            Text = "productManagementAdminForm";
            adminMenu.ResumeLayout(false);
            adminMenu.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip adminMenu;
        private ToolStripButton adminMenuUsers;
        private ToolStripButton adminMenuOrders;
        private GroupBox groupBox;
        private TextBox textBoxType;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private TextBox textBoxTitle;
        private DataGridView productGridView;
        private TextBox textBoxTitleSearch;
        private TextBox textBoxIDSearch;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonUpdateProduct;
        private Button buttonCreateProduct;
        private Button buttonSearch;
        private NumericUpDown addQuantity;
        private TextBox textBoxID;
    }
}