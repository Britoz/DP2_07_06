using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRPS.Controller;

namespace SRPS
{
    public partial class SaleReport : Form
    {
        private string[] monthly = new string[] { "January", "February", "March", "April", "May",
        "June","July","August","September","October","November","December"};
        public SaleReport()
        {
            InitializeComponent();
            LoadDataToSaleReport();
            initSetting();
        }

        public void initSetting()
        {
            rbMonthly.Checked = true;

            if(rbMonthly.Checked == true)
            {
                foreach(var month in monthly)
                {
                    cbChoosing.Items.Add(month);
                }
            }
            cbChoosing.Text = "Choosing month";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadDataToSaleReport()
        {
            saleRecordModelBindingSource.Clear();
            SaleReportController controller = new SaleReportController();
            foreach (var data in controller.GetAllSaleRecord())
            {
                saleRecordModelBindingSource.Add(data);
            }
        }

        private void LoadMonthlyData(monthInYear type, int year)
        {
            saleRecordModelBindingSource.Clear();
            SaleReportController controller = new SaleReportController();
            foreach (var data in controller.GetALlSaleRecordByMonthAndYear(type, year))
            {
                saleRecordModelBindingSource.Add(data);
            }
        }

        private void lsvSaleReport_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //show edit sale report table
        private void EditSaleReport()
        {

        }

        private void dgvSaleReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click to the Edit button in the cell
            if(dgvSaleReport.Columns[e.ColumnIndex].Name == "colEditButton")
            {
                //get the id of that row
                DataGridViewRow gvr = dgvSaleReport.Rows[e.RowIndex];
                Edit edit = new Edit(Convert.ToInt32(gvr.Cells[0].Value.ToString()));
                edit.Owner = this;
                edit.Show();
            }
           
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {

        }

        private void CbChoosing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RbWeekly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int year = 0;
            try
            {
                year = Convert.ToInt32(txtYear.Text);

                if (year >= 2000 && year <= DateTime.Now.Year)
                {
                    LoadMonthlyData((monthInYear)cbChoosing.SelectedIndex + 1, year);
                }
                else
                {
                    MessageBox.Show("invalide year");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("year cannot be empty: " + ex);
            }
            
        }
    }
}
