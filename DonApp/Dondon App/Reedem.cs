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
    public partial class Reedem : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;

        private int userId;
        private string name;
        private string username;
        private int userPoints;
        private int initialUserPoints;

        public Reedem(int userId)
        {
            InitializeComponent();
            server = "localhost";
            database = "dondon";
            uid = "root";
            password = "";

            string conString;
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(conString);

            this.userId = userId;
        }

        private void Reedem_Load(object sender, EventArgs e)
        {
            LoadUserPoints();
        }

        private void reedemBtn_Click(object sender, EventArgs e)
        {
            UpdatePointsInDatabase();
            SendBookingData();
        }

        private void LoadUserPoints()
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT Name, Username, poin FROM userlog WHERE userId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["Name"].ToString();
                            username = reader["Username"].ToString();
                            userPoints = Convert.ToInt32(reader["poin"]);
                            initialUserPoints = userPoints;

                            PointLabel.Text = "Poin: " + userPoints.ToString();
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

        private void addBtn1_Click(object sender, EventArgs e)
        {
            int pointsToDeduct = 240;

            if (userPoints >= pointsToDeduct)
            {
                UpdateQuantity(ref numPesanananLbl1, 1);
                UpdatePoints(-pointsToDeduct);
                GetOrderSummary();
            }
            else
            {
                MessageBox.Show("Insufficient points for this action.");
            }
        }

        private void minBtn1_Click(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(numPesanananLbl1.Text);

            if (currentQuantity > 0)
            {
                UpdateQuantity(ref numPesanananLbl1, -1);
                UpdatePoints(240);
                GetOrderSummary();
            }
        }

        private void addBtn2_Click(object sender, EventArgs e)
        {
            int pointsToDeduct = 250;

            if (userPoints >= pointsToDeduct)
            {
                UpdateQuantity(ref numPesanananLbl2, 1);
                UpdatePoints(-pointsToDeduct);
                GetOrderSummary();
            }
            else
            {
                MessageBox.Show("Insufficient points for this action.");
            }
        }

        private void minBtn2_Click(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(numPesanananLbl2.Text);

            if (currentQuantity > 0)
            {
                UpdateQuantity(ref numPesanananLbl2, -1);
                UpdatePoints(250);
                GetOrderSummary();
            }
        }


        private void UpdateQuantity(ref Label label, int quantityChange)
        {
            int currentQuantity = int.Parse(label.Text);
            int newQuantity = Math.Max(currentQuantity + quantityChange, 0);
            label.Text = newQuantity.ToString();
        }

        private void UpdatePoints(int pointsChange)
        {
            // Update the userPoints without changing the database
            userPoints = Math.Max(userPoints + pointsChange, 0);
            PointLabel.Text = "Poin: " + userPoints.ToString();

            UpdateUsagePoint();
        }

        private void UpdatePointsInDatabase()
        {
            // Update the points in the database
            if (openConnection())
            {
                try
                {
                    string query = "UPDATE userlog SET poin = @newPoints WHERE userId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@newPoints", userPoints);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
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

        private void UpdateUsagePoint()
        {
            int usedPoints = Math.Max(initialUserPoints - userPoints, 0);
            usagePoinLabel.Text = "(-" + usedPoints.ToString() + ")";
        }

        private string GetOrderSummary()
        {
            StringBuilder orderSummary = new StringBuilder();

            int quantity1 = int.Parse(numPesanananLbl1.Text);
            if (quantity1 > 0)
            {
                orderSummary.Append($"{quantity1}x {labelReedem1.Text}");
            }

            int quantity2 = int.Parse(numPesanananLbl2.Text);
            if (quantity2 > 0)
            {
                if (quantity1 > 0)
                {
                    orderSummary.Append(", ");
                }

                orderSummary.Append($"{quantity2}x {labelReedem2.Text}");
            }

            return orderSummary.ToString();
        }

        private void SendBookingData()
        {
            if (openConnection())
            {
                try
                {
                    int latestBookingId = GetLatestBookingId();
                    int newBookingId = latestBookingId + 1;

                    string query = "INSERT INTO booking (bookingId, customer, username, pesanan, note, total, poin) VALUES (@bookingId, @customer, @username, @pesanan, @note, @total, @poin)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@bookingId", newBookingId);
                    cmd.Parameters.AddWithValue("@customer", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pesanan", GetOrderSummary());
                    cmd.Parameters.AddWithValue("@note", noteTextBox.Text);
                    cmd.Parameters.AddWithValue("@total", 0);
                    cmd.Parameters.AddWithValue("@poin","-" + GetUsedPoints());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reedem successful!");
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

        private int GetLatestBookingId()
        {
            string query = "SELECT MAX(bookingId) FROM booking";
            MySqlCommand cmd = new MySqlCommand(query, con);

            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }

        private int GetUsedPoints()
        {
            int usedPoints = Math.Max(initialUserPoints - userPoints, 0);
            return usedPoints;
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
