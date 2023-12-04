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
    public partial class MenuAyam : Form
    {
        private int userId;
        
        public MenuAyam(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void orderBtn1_Click(object sender, EventArgs e)
        {
            string promotionName = "Ayam Geprek Sambal Matah";
            int price = 25000;
            int points = 25;

            Order orderForm = new Order(userId);
            orderForm.ReceivePromotionDetails(promotionName, price, points);
            orderForm.ShowDialog();
        }

        private void MenuAyam_Load(object sender, EventArgs e)
        {

        }
    }
}
