using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;

namespace Dondon_App
{
    public partial class History : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private string name;
        private string username;

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ShowDialog();
        }

        public History(string name, string username)
        {
            InitializeComponent();
            server = "localhost";
            database = "dondon";
            uid = "root";
            password = "";

            string conString;
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(conString);

            this.name = name;
            this.username = username;
        }
            
        private void History_Load(object sender, EventArgs e)
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT customer, pesanan, note, total, poin FROM booking WHERE customer=@name";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);

                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {   
                        adapter.Fill(dataTable);
                    }
                    
                    dataGridView1.DataSource = dataTable;
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
