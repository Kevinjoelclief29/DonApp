using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dondon_App
{
    public partial class ChangesPassword : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        
        public ChangesPassword()
        {
            InitializeComponent();
            server = "localhost";
            database = "dondon";
            uid = "root";
            password = "";

            string conString;
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(conString);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                try
                {
                    string checkUserQuery = "SELECT * FROM userlog WHERE Name=@name AND Username=@username";
                    MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, con);

                    checkUserCmd.Parameters.AddWithValue("@name", NameTxt.Text);
                    checkUserCmd.Parameters.AddWithValue("@username", NewPassTxt.Text);

                    using (MySqlDataReader reader = checkUserCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reader.Close();

                            string updatePasswordQuery = "UPDATE userlog SET Password=@newPassword WHERE Name=@name AND Username=@username";
                            MySqlCommand updatePasswordCmd = new MySqlCommand(updatePasswordQuery, con);

                            updatePasswordCmd.Parameters.AddWithValue("@newPassword", NewPassTxt.Text);
                            updatePasswordCmd.Parameters.AddWithValue("@name", NameTxt.Text);
                            updatePasswordCmd.Parameters.AddWithValue("@username", UserTxt.Text);

                            updatePasswordCmd.ExecuteNonQuery();

                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("User not found!");
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
