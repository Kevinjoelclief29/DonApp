using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dondon_App
{
    public partial class Menu : Form
    {
        private int userId;
        
        public Menu(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MenuAyam menuAyam = new MenuAyam(userId);
            menuAyam.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(menuAyam);
            menuAyam.Show();
        }

        private void AyamBtn_Click(object sender, EventArgs e)
        {
            MenuAyam menuAyam = new MenuAyam(userId);
            menuAyam.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(menuAyam);
            menuAyam.Show();
        }

        private void DagingBtn_Click(object sender, EventArgs e)
        {
            MenuDaging menuDaging = new MenuDaging(userId);
            menuDaging.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(menuDaging);
            menuDaging.Show();
        }

        private void MinumBtn_Click(object sender, EventArgs e)
        {
            MenuMinuman menuMinuman = new MenuMinuman(userId);
            menuMinuman.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(menuMinuman);
            menuMinuman.Show();
        }

        private void PromoBtn_Click(object sender, EventArgs e)
        {
            MenuPromo menuPromo = new MenuPromo(userId);
            menuPromo.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(menuPromo);
            menuPromo.Show();
        }
    }
}
