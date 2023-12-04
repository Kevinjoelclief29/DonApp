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
    public partial class MenuPromo : Form
    {
        private int userId;
        public MenuPromo(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void MenuPromo_Load(object sender, EventArgs e)
        {

        }

        private void promoBtn1_Click(object sender, EventArgs e)
        {
            string promotionName = "2 Drink + Kombinasi Mie Goreng dan Nasi Goreng";
            int price = 64000;
            int points = 64;

            Order orderForm = new Order(userId);
            orderForm.ReceivePromotionDetails(promotionName, price, points);
            orderForm.ShowDialog();
        }

        private void promoBtn2_Click(object sender, EventArgs e)
        {
            string promotionName = "Fruty Blender + Nasi Ayam Goreng Mentega";
            int price = 43000;
            int points = 43;

            Order orderForm = new Order(userId);
            orderForm.ReceivePromotionDetails(promotionName, price, points);
            orderForm.ShowDialog();
        }

        private void promoBtn3_Click(object sender, EventArgs e)
        {
            string promotionName = "2 Drinks 22OZ + Chocho Cheese Toast";
            int price = 47000;
            int points = 47;

            Order orderForm = new Order(userId);
            orderForm.ReceivePromotionDetails(promotionName, price, points);
            orderForm.ShowDialog();
        }

        private void promoBtn4_Click(object sender, EventArgs e)
        {
            string promotionName = "2 Drinks 14OZ + Chocho Cheese Toast";
            int price = 37000;
            int points = 37;

            Order orderForm = new Order(userId);
            orderForm.ReceivePromotionDetails(promotionName, price, points);
            orderForm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
