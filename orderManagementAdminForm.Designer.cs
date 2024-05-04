namespace gr3_projektni_zadatak
{
    partial class orderManagementAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderManagementAdminForm));
            toolStrip1 = new ToolStrip();
            adminMenuUsers = new ToolStripButton();
            adminMenuProducts = new ToolStripButton();
            groupBox1 = new GroupBox();
            orderDataGrid = new DataGridView();
            textBoxID = new TextBox();
            label1 = new Label();
            buttonDeleteOrder = new Button();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { adminMenuUsers, adminMenuProducts });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(460, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            // adminMenuProducts
            // 
            adminMenuProducts.DisplayStyle = ToolStripItemDisplayStyle.Text;
            adminMenuProducts.Image = (Image)resources.GetObject("adminMenuProducts.Image");
            adminMenuProducts.ImageTransparentColor = Color.Magenta;
            adminMenuProducts.Name = "adminMenuProducts";
            adminMenuProducts.Size = new Size(106, 22);
            adminMenuProducts.Text = "Upravljaj artiklima";
            adminMenuProducts.Click += adminMenuProducts_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDeleteOrder);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(orderDataGrid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 184);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz / Brisanje Narudzbe";
            // 
            // orderDataGrid
            // 
            orderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGrid.Location = new Point(17, 32);
            orderDataGrid.Name = "orderDataGrid";
            orderDataGrid.Size = new Size(404, 108);
            orderDataGrid.TabIndex = 0;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(92, 150);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "ID ?";
            textBoxID.Size = new Size(59, 23);
            textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 153);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "ID Narudzbe:";
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Location = new Point(163, 150);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(107, 23);
            buttonDeleteOrder.TabIndex = 3;
            buttonDeleteOrder.Text = "Obrisi narudzbu";
            buttonDeleteOrder.UseVisualStyleBackColor = true;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // orderManagementAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 239);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "orderManagementAdminForm";
            Text = "Upravljanje Narudzbama";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton adminMenuUsers;
        private ToolStripButton adminMenuProducts;
        private GroupBox groupBox1;
        private Button buttonDeleteOrder;
        private Label label1;
        private TextBox textBoxID;
        private DataGridView orderDataGrid;
    }
}