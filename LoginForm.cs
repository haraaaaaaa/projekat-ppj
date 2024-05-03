using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace gr3_projektni_zadatak
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static String connString = "Server=localhost; Port=3306; Database=gr3-projektni-zadatak; Uid=grupa3; Pwd=grupa3";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            String query = "SELECT user_id, username, password, CONCAT(name, ' ', surname) FROM users WHERE username = '" + username + "' ";

            try {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show(reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + reader[3].ToString());

                if (!reader.HasRows) {
                    errorProvider.SetError(textBoxUsername, "Korisnik sa tim korisničkim imenom ne postoji.");
                }
                else{
                    reader.Read();
                    
                    if (password == reader[2].ToString()) {
                        MessageBox.Show("Uspješno ste logovani " + reader[3].ToString());

                        if (reader[0].ToString() == "1") {
                            this.Hide();
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else {
                            this.Hide();
                            CustomerForm customerForm = new CustomerForm();
                            customerForm.Show();
                        }
                    } 
                    else {
                        errorProvider.SetError(textBoxPassword, "Unijeli ste netačnu lozinku!");
                    }
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }*/

            createOrderCustomerForm customerForm = new createOrderCustomerForm();
            customerForm.Show();
            this.Hide();
        }
    }
}
