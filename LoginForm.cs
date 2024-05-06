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
        public static String userId;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();

            try {
                String username = textBoxUsername.Text;
                String password = textBoxPassword.Text;

                String query = "SELECT user_id, username, password, CONCAT(name, ' ', surname) FROM users WHERE username = '" + username + "' ";

                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();


                if (!reader.HasRows) {
                    errorProvider.SetError(textBoxUsername, "Korisnik sa tim korisničkim imenom ne postoji.");
                }
                else{
                    // cuvamo userId za forme u buducnosti
                    userId = reader[0].ToString();

                    if (password == reader[2].ToString()) {
                        MessageBox.Show("Uspješno ste logovani " + reader[3].ToString());

                        if (reader[0].ToString() == "1") {
                            this.Hide();
                            userManagementAdminForm adminForm = new userManagementAdminForm();
                            adminForm.Show();
                        }
                        else {
                            this.Hide();
                            createOrderCustomerForm customerForm = new createOrderCustomerForm();
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
            }
        }
    }
}
