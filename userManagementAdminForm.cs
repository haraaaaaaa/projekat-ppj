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
    public partial class userManagementAdminForm : Form
    {

        String connString = LoginForm.connString;

        public userManagementAdminForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            findUser();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            createUser();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void findUser()
        { 
            try
            {
                String query = "SELECT * FROM users WHERE user_id > 1";

                if (textBoxIDSearch.Text != "")
                {
                    query += "AND user_id = '" + textBoxIDSearch.Text + "'";
                }
                else if (textBoxNameSearch.Text != "")
                {
                    query += "AND name LIKE '" + textBoxNameSearch.Text + "%'";
                }
                else if (textBoxSurnameSearch.Text != "")
                {
                    query += "AND surname LIKE '" + textBoxSurnameSearch.Text + "%'";
                }

                query += " ORDER BY user_id";

                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                userGridView.DataSource = dataTable;
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createUser()
        {
            try
            {
            String query = "INSERT INTO users(name, surname, city, address, phone, username, password) VALUES " +
                    " ('" + textBoxName.Text + "', '" + textBoxSurname.Text + "', '" + textBoxCity.Text + "', '" + textBoxAddress.Text + "', '" + textBoxPhone.Text + "', '" + textBoxUsername.Text + "', '" + textBoxPassword.Text + "' )";

                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Uspjesno ste kreirali novog korisnika!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateUser()
        {
            try
            {
            String query = "UPDATE users" +
                "SET name = '" + textBoxName.Text + "', surname = '" + textBoxSurname.Text + "', city = '" + textBoxCity.Text + "', address = '" + textBoxAddress.Text +
                "', phone = '" + textBoxPhone.Text + "', username = '" + textBoxUsername.Text + "', password = '" + textBoxPassword.Text + "'";
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                connection.Close ();

                MessageBox.Show("Podaci za korisnika ID = " + textBoxID.Text + " su azurirani.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }
        }

        private void adminMenuProducts_Click(object sender, EventArgs e)
        {
            this.Hide();

            productManagementAdminForm productManagementAdminForm = new productManagementAdminForm();
            productManagementAdminForm.Show();
        }

        private void adminMenuOrders_Click(object sender, EventArgs e)
        {
            this.Hide();

            orderManagementAdminForm orderManagementAdminForm = new orderManagementAdminForm();
            orderManagementAdminForm.Show();
        }
    }
}
