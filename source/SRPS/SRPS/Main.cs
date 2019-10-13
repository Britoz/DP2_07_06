using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SalesRecord salesRecord = new SalesRecord();
            salesRecord.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            SaleReport salesReport = new SaleReport();
            salesReport.Show();
            this.Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Prediction prediction = new Prediction();
            prediction.Show();
            this.Hide();
        }
    }
}
