using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Dondon_App
{
    public partial class Profile : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;
        private string username;

        public Profile(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            server = "localhost";
            database = "dondon";
            uid = "root";
            password = "";

            string conString;
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(conString);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            
        }

        private void Profile_Load_1(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            History history = new History(NameLabel.Text, username);
            history.ShowDialog();
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            ChangesPassword cp = new ChangesPassword();
            cp.ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the Login form
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void LoadUserData()
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT * FROM userlog WHERE userId=@userId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming "Name" and "Phone" are column names in your table
                            string name = reader["Name"].ToString();
                            string phoneNumber = reader["Phone"].ToString();
                            string poin = reader["poin"].ToString();
                            string Username = reader["Username"].ToString();

                            // Set the data in the form
                            NameLabel.Text = name;
                            NumberLabel.Text = "+" + phoneNumber;
                            PointLabel.Text = poin + " Poin";
                        }
                        else
                        {
                            MessageBox.Show("User data not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private bool openConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}