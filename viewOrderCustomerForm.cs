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
    public partial class viewOrderCustomerForm : Form
    {
        String connString = LoginForm.connString;
        String userId = LoginForm.userId;

        public viewOrderCustomerForm()
        {
            InitializeComponent();
        }

        private void showOrders()
        {
            try
            {
                String query = "SELECT * FROM orders WHERE user_id = '" + userId + "'";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                orderGrid.DataSource = table;

                dataAdapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showOrderItems()
        {
            try
            {
                String query = "SELECT p.title, p.price, oi.quantity FROM products p JOIN order_items oi ON oi.product_id = p.product_id WHERE order_id = '" + textBoxOrderID.Text + "'";
                
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                itemGrid.DataSource = table;

                int totalPrice = 0; 
                foreach (DataGridViewRow row in itemGrid.Rows)
                {
                    int price = Convert.ToInt32(row.Cells[1].Value);
                    int quantity = Convert.ToInt32(row.Cells[2].Value);

                    totalPrice += price * quantity;
                }

                textBoxTotalPrice.Text = totalPrice.ToString();

                dataAdapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerMenuCreateOrder_Click(object sender, EventArgs e)
        {
            this.Hide();

            createOrderCustomerForm createOrderCustomerForm = new createOrderCustomerForm();
            createOrderCustomerForm.Show();
        }

        private void viewOrderCustomerForm_Load(object sender, EventArgs e)
        {
            showOrders();
        }

        private void buttonShowItems_Click(object sender, EventArgs e)
        {
            showOrderItems();
        }
    }
}
