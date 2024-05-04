using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gr3_projektni_zadatak
{
    public partial class orderManagementAdminForm : Form
    {
        String connString = LoginForm.connString;

        public orderManagementAdminForm()
        {
            InitializeComponent();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            deleteOrder();
        }

        private void deleteOrder()
        {
            try
            {
                String query = "DELETE FROM orders WHERE order_id = '" + textBoxID.Text + "'";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Narudzba uspjesno obrisana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showOrders()
        {
            try
            {
                // morao sam napisati sa JOIN statement zbog novije verzije NaviCat koja ne prihvata provjeru preko ID
                String query = "SELECT u.user_id, CONCAT(u.name, ' ', u.surname) AS 'Ime i prezime', o.order_id, o.date FROM users u " +
                    "JOIN orders o ON o.user_id = u.user_id";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                orderDataGrid.DataSource = table;

                dataAdapter.Dispose();
                connection.Close() ;
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

        private void adminMenuProducts_Click(object sender, EventArgs e)
        {
            this.Hide();

            productManagementAdminForm productManagementAdminForm = new productManagementAdminForm();
            productManagementAdminForm.Show();
        }
    }
}
