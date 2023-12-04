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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = new CrystalReport1();
            crystalReportViewer1.Refresh();
        }
    }
}
