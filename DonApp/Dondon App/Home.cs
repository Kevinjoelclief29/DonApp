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
    public partial class Home : Form
    {
        private int userId;

        public Home(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            HomeBanner HB = new HomeBanner();
            HB.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(HB);
            HB.Show();
        }

        private void MeBtn_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(userId);
            profileForm.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(profileForm);
            profileForm.Show();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu(userId);
            menuForm.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(menuForm);
            menuForm.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeBanner HB = new HomeBanner();
            HB.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(HB);
            HB.Show();
        }

        private void ReedemBtn_Click(object sender, EventArgs e)
        {
            Reedem rd = new Reedem(userId);
            rd.TopLevel = false;
            Panel1.Controls.Clear();
            Panel1.Controls.Add(rd);
            rd.Show();
        }
    }
}
