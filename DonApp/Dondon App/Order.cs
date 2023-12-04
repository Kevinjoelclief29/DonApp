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
    public partial class Order : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;

        private int userId;
        private int currentQuantity = 1;
        private int basePrice;
        private int basePoints;
        private string name;
        private string username;

        public Order(int userId)
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

        private void Order_Load(object sender, EventArgs e)
        {
            LoadUserData();
            numPesanananLbl.Text = currentQuantity.ToString();
        }

        public void ReceivePromotionDetails(string Desc, int price, int points)
        {
            descLabel.Text = Desc;
            basePrice = price;
            basePoints = points;
            UpdatePriceAndPoints();
        }

        private void UpdatePriceAndPoints()
        {
            int totalPrice = basePrice * currentQuantity;
            int totalPoints = basePoints * currentQuantity;

            priceLabel.Text = "Rp." + totalPrice.ToString();
            pointsLabel.Text = totalPoints.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upadateOrderBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                try
                {
                    // Retrieve the maximum bookingId from the database
                    string getMaxBookingIdQuery = "SELECT MAX(bookingId) FROM booking";
                    MySqlCommand getMaxBookingIdCmd = new MySqlCommand(getMaxBookingIdQuery, con);
                    int maxBookingId = Convert.ToInt32(getMaxBookingIdCmd.ExecuteScalar());

                    // Increment the bookingId for the new order
                    int newBookingId = maxBookingId + 1;

                    // Insert the new order into the database
                    string insertQuery = "INSERT INTO booking (bookingId, customer, username, pesanan, note, total, poin) VALUES (@bookingId, @customer, @username, @pesanan, @note, @total, @poin)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@bookingId", newBookingId);
                    insertCmd.Parameters.AddWithValue("@customer", name);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@pesanan", numPesanananLbl.Text + "x " + descLabel.Text);
                    insertCmd.Parameters.AddWithValue("@note", noteTextBox.Text);
                    insertCmd.Parameters.AddWithValue("@total", priceLabel.Text.Replace("Rp.", ""));
                    insertCmd.Parameters.AddWithValue("@poin", "+" + pointsLabel.Text);

                    insertCmd.ExecuteNonQuery();

                    // Update the user's points in the userlog table
                    string updatePointsQuery = "UPDATE userlog SET poin = poin + @poin WHERE userId = @userId";
                    MySqlCommand updatePointsCmd = new MySqlCommand(updatePointsQuery, con);

                    // Include the userId parameter in the update query
                    updatePointsCmd.Parameters.AddWithValue("@poin", pointsLabel.Text);
                    updatePointsCmd.Parameters.AddWithValue("@userId", userId);

                    updatePointsCmd.ExecuteNonQuery();

                    MessageBox.Show("Order updated successfully!");
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


        private void minBtn_Click(object sender, EventArgs e)
        {
            currentQuantity = Math.Max(currentQuantity - 1, 1);
            numPesanananLbl.Text = currentQuantity.ToString();
            UpdatePriceAndPoints();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            currentQuantity++;
            numPesanananLbl.Text = currentQuantity.ToString();
            UpdatePriceAndPoints();
        }

        private void LoadUserData()
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT Name, Username FROM userlog WHERE userId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["Name"].ToString();
                            username = reader["Username"].ToString();
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
