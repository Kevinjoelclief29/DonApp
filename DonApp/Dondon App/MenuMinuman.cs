using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dondon_App
{
    public partial class MenuMinuman : Form
    {
        private int userId;
        public MenuMinuman(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void orderBtn1_Click(object sender, EventArgs e)
        {
            string promotionName = "Squash Series!";
            int price = 24000;
            int points = 24;
            
            Order orderForm = new Order(userId);
            orderForm.ReceivePromotionDetails(promotionName, price, points);
            orderForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string promotionName = "Squash Series!";
            int price = 24000;
            int points = 24;

            Order orderForm = new Order(userId);
            orderForm.ReceivePromotionDetails(promotionName, price, points);
            orderForm.ShowDialog();
        }
    }
}
