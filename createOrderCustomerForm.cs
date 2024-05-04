using MySql.Data.MySqlClient;
using System.Data;

namespace gr3_projektni_zadatak
{
    public partial class createOrderCustomerForm : Form
    {
        String connString = LoginForm.connString;
        String userId = LoginForm.userId;
        public createOrderCustomerForm()
        {
            InitializeComponent();
        }

        private void createOrderCustomerForm_Load(object sender, EventArgs e)
        {
            showProducts();
        }

        private void addToCart()
        {
            try
            {
                String showProductInCartQuery = "SELECT product_id, title FROM products WHERE product_id = '" + textBoxID.Text + "'";
                String getStorageInfoQuery = "SELECT quantity FROM storage WHERE product_id = '" + textBoxID.Text + "'";
                String updateStorageInfoQuery = "UPDATE storage SET quantity = quantity - '" + textBoxQuantity.Text + "'";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlCommand getStorageInfoCmd = new MySqlCommand(getStorageInfoQuery, connection);
                MySqlDataReader reader = getStorageInfoCmd.ExecuteReader();
                reader.Read();

                // kreira tabelu u datagrid
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("colId", typeof(string)));
                table.Columns.Add(new DataColumn("colTitle", typeof(string)));
                table.Columns.Add(new DataColumn("colQuantity", typeof(string)));


                if (reader.GetInt32(0) > Convert.ToInt32(textBoxQuantity.Text) ) 
                {
                    MessageBox.Show("Ne posjedujemo toliku kolicinu tog artikla u skladistu, uzmite manju vrijednost.");
                }
                else
                {

                    MySqlCommand updateStorageInfoCmd = new MySqlCommand(updateStorageInfoQuery, connection);
                    updateStorageInfoCmd.ExecuteNonQuery();

                    MySqlCommand showProductInCartCmd = new MySqlCommand(showProductInCartQuery, connection);

                    MySqlDataReader dataReader = showProductInCartCmd.ExecuteReader();

                    this.cartGrid.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), textBoxQuantity.Text);

                    MessageBox.Show("Uspjesno ste dodali artikal u korpu!");
                }

                cartGrid.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeFromCart()
        {
            try
            {
                foreach (DataGridViewRow row in cartGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(textBoxID.Text))
                    {
                        row.Selected = true;
                        cartGrid.Rows.Remove(row);

                        MessageBox.Show("Uspjesno ste izbrisali artikal iz korpe.");

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void placeOrder()
        {
            try
            {
                DateTime date = DateTime.Today;

                String orderQuery = "INSERT INTO orders(user_id, date) VALUES " +
                    "('" + userId + "', '" + date.ToString("yyyy-mm-dd") + "' ";
                String getOrderIdQuery = "SELECT order_id FROM orders WHERE date = '" + date.ToString("yyyy-mm-dd") + "' AND user_id = '" + userId + "' ORDER BY order_id LIMIT 1";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlCommand orderCmd = new MySqlCommand(orderQuery, connection);
                MySqlCommand getOrderIdCmd = new MySqlCommand(getOrderIdQuery, connection);

                MySqlDataReader reader = getOrderIdCmd.ExecuteReader();
                string orderId = reader[0].ToString();

                String orderItemsQuery = "INSERT INTO order_items(order_id, product_id, quantity) VALUES";
                String productId, quantity;

                foreach (DataGridViewRow row in cartGrid.Rows)
                {
                    productId = row.Cells[0].Value.ToString();
                    quantity = row.Cells[2].Value.ToString();

                    orderItemsQuery += "('" + orderId + "', '" + productId + "', '" + quantity + "'";
                }

                MySqlCommand insertOrderItemsCmd = new MySqlCommand(orderItemsQuery, connection);
                insertOrderItemsCmd.ExecuteNonQuery();

                MessageBox.Show("Narudzba uspjesno kreirana!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showProducts()
        {
            try
            {
                String query = "SELECT * FROM products";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                productGrid.DataSource = table;

                dataAdapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
