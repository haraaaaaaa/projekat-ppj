namespace gr3_projektni_zadatak
{
    partial class userManagementAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userManagementAdminForm));
            adminMenu = new ToolStrip();
            adminMenuProducts = new ToolStripButton();
            adminMenuOrders = new ToolStripButton();
            groupBox = new GroupBox();
            textBoxIDSearch = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            textBoxID = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxCity = new TextBox();
            textBoxAddress = new TextBox();
            userGridView = new DataGridView();
            buttonSearch = new Button();
            textBoxSurnameSearch = new TextBox();
            textBoxNameSearch = new TextBox();
            adminMenu.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            SuspendLayout();
            // 
            // adminMenu
            // 
            adminMenu.Items.AddRange(new ToolStripItem[] { adminMenuProducts, adminMenuOrders });
            adminMenu.Location = new Point(0, 0);
            adminMenu.Name = "adminMenu";
            adminMenu.Size = new Size(621, 25);
            adminMenu.TabIndex = 0;
            adminMenu.Text = "toolStrip1";
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
            // adminMenuOrders
            // 
            adminMenuOrders.DisplayStyle = ToolStripItemDisplayStyle.Text;
            adminMenuOrders.Image = (Image)resources.GetObject("adminMenuOrders.Image");
            adminMenuOrders.ImageTransparentColor = Color.Magenta;
            adminMenuOrders.Name = "adminMenuOrders";
            adminMenuOrders.Size = new Size(126, 22);
            adminMenuOrders.Text = "Upravljaj narudbzama";
            adminMenuOrders.Click += adminMenuOrders_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBoxIDSearch);
            groupBox.Controls.Add(label8);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(buttonCreate);
            groupBox.Controls.Add(buttonUpdate);
            groupBox.Controls.Add(textBoxID);
            groupBox.Controls.Add(textBoxPassword);
            groupBox.Controls.Add(textBoxUsername);
            groupBox.Controls.Add(textBoxPhone);
            groupBox.Controls.Add(textBoxName);
            groupBox.Controls.Add(textBoxSurname);
            groupBox.Controls.Add(textBoxCity);
            groupBox.Controls.Add(textBoxAddress);
            groupBox.Controls.Add(userGridView);
            groupBox.Controls.Add(buttonSearch);
            groupBox.Controls.Add(textBoxSurnameSearch);
            groupBox.Controls.Add(textBoxNameSearch);
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox.Location = new Point(26, 49);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(570, 443);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Kreiranje / Azuriranje Novog Kupca";
            // 
            // textBoxIDSearch
            // 
            textBoxIDSearch.Location = new Point(31, 49);
            textBoxIDSearch.Name = "textBoxIDSearch";
            textBoxIDSearch.PlaceholderText = "ID ?";
            textBoxIDSearch.Size = new Size(62, 23);
            textBoxIDSearch.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 402);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 24;
            label8.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 260);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 23;
            label7.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 289);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 22;
            label6.Text = "Korisnicko ime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 318);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 21;
            label5.Text = "Lozinka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 344);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 20;
            label4.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 315);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 19;
            label3.Text = "Grad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 289);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 18;
            label2.Text = "Prezime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 260);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 17;
            label1.Text = "Ime:";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(363, 344);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(113, 25);
            buttonCreate.TabIndex = 16;
            buttonCreate.Text = "Kreiraj kupca";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(203, 402);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(138, 25);
            buttonUpdate.TabIndex = 15;
            buttonUpdate.Text = "Azuriraj podatke";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(74, 403);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(113, 23);
            textBoxID.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(363, 315);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(113, 23);
            textBoxPassword.TabIndex = 13;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(363, 286);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(113, 23);
            textBoxUsername.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(363, 257);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(113, 23);
            textBoxPhone.TabIndex = 11;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(74, 257);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(113, 23);
            textBoxName.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(74, 286);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(113, 23);
            textBoxSurname.TabIndex = 9;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(74, 315);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(113, 23);
            textBoxCity.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(74, 344);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(113, 23);
            textBoxAddress.TabIndex = 7;
            // 
            // userGridView
            // 
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridView.Location = new Point(30, 106);
            userGridView.Name = "userGridView";
            userGridView.Size = new Size(511, 132);
            userGridView.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 9F);
            buttonSearch.Location = new Point(434, 49);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(107, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Trazi";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSurnameSearch
            // 
            textBoxSurnameSearch.Location = new Point(218, 49);
            textBoxSurnameSearch.Name = "textBoxSurnameSearch";
            textBoxSurnameSearch.PlaceholderText = "Prezime ?";
            textBoxSurnameSearch.Size = new Size(113, 23);
            textBoxSurnameSearch.TabIndex = 1;
            // 
            // textBoxNameSearch
            // 
            textBoxNameSearch.Location = new Point(99, 49);
            textBoxNameSearch.Name = "textBoxNameSearch";
            textBoxNameSearch.PlaceholderText = "Ime ?";
            textBoxNameSearch.Size = new Size(113, 23);
            textBoxNameSearch.TabIndex = 0;
            // 
            // userManagementAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 540);
            Controls.Add(groupBox);
            Controls.Add(adminMenu);
            Name = "userManagementAdminForm";
            Text = "Upravljanje Korisnicima";
            adminMenu.ResumeLayout(false);
            adminMenu.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip adminMenu;
        private ToolStripButton adminMenuProducts;
        private ToolStripButton adminMenuOrders;
        private GroupBox groupBox;
        private DataGridView userGridView;
        private Button buttonSearch;
        private TextBox textBoxSurnameSearch;
        private TextBox textBoxNameSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCreate;
        private Button buttonUpdate;
        private TextBox textBoxID;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxCity;
        private TextBox textBoxAddress;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox textBoxIDSearch;
    }
}