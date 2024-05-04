using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gr3_projektni_zadatak
{
    public partial class productManagementAdminForm : Form
    {

        String connString = LoginForm.connString;
        public productManagementAdminForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            findProduct();
        }
        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            createProduct();
        }
        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void findProduct()
        {
            try
            {
                String query = "SELECT * FROM products";


                if (textBoxIDSearch.Text != "")
                {
                    query += " WHERE product_id = '" + textBoxIDSearch.Text + "'";
                }
                else if (textBoxTitleSearch.Text != "")
                {
                    query += " AND title LIKE '" + textBoxTitleSearch.Text + "%'";
                }

                query += " ORDER BY product_id";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection); 
                
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                productGridView.DataSource = table;

                dataAdapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createProduct()
        {
            try
            {
                String createProductQuery = "INSERT INTO products(title, type, price) VALUES" +
                 "('" + textBoxTitle.Text + "', '" + textBoxType.Text + "', '" + textBoxPrice.Text + "')";

                String getIDQuery = "SELECT product_id FROM products WHERE title = '" + textBoxTitle.Text + "' AND type = '" + textBoxType.Text + "' AND price = '" + textBoxPrice.Text + "'";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlCommand createProductCmd = new MySqlCommand(createProductQuery, connection);
                createProductCmd.ExecuteNonQuery();

                MySqlCommand getIdCmd = new MySqlCommand(getIDQuery, connection);
                MySqlDataReader reader = getIdCmd.ExecuteReader();

                String createStorageInfoQuery = "INSERT INTO storage(product_id, quantity) VALUES" +
                    "('" + reader[0].ToString() + "', '" + textBoxQuantity.Text + "')";

                MySqlCommand createStorageInfoCmd = new MySqlCommand(createStorageInfoQuery, connection);
                createStorageInfoCmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Artikal uspjesno kreiran!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void adminMenuUsers_Click(object sender, EventArgs e)
        {
            this.Hide();

            userManagementAdminForm userManagementAdminForm = new userManagementAdminForm();
            userManagementAdminForm.Show();
        }

        private void adminMenuOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderManagementAdminForm orderManagementAdminForm = new orderManagementAdminForm();
            orderManagementAdminForm.Show();
        }

    }
}
