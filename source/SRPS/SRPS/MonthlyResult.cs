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
using SRPS.Controller;

namespace SRPS.View
{
    public partial class MonthlyResult : Form
    {

        public MonthlyResult(int month, int year)
        {
            InitializeComponent();
            LoadGridViewMonth(month, year);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadData(int month,int year, int total)
        {

            lbMonthYear.Text = " " + month + "/" + year + " ";
            lbTotalPrice.Text = " " + total + " ";
        }

        private void LoadGridViewMonth(int month, int year)
        {
            SaleReportController controller = new SaleReportController();

            foreach (var data in controller.GetALlSaleRecordByMonthAndYear((monthInYear)month, year))
            {
                saleRecordModelBindingSource1.Add(data);
            }
        }

        private void MonthlyResult_Load(object sender, EventArgs e)
        {

        }
    }
}
