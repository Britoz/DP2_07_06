﻿using System;
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
        public SaleReport()
        {
            InitializeComponent();
            LoadDataToSaleReport();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadDataToSaleReport()
        {
            SaleReportController controller = new SaleReportController();
            int i = 0;
            foreach (var data in controller.GetAllSaleRecord())
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
                MessageBox.Show("you want to edit item with ID: " + gvr.Cells[0].Value.ToString());
            }
            if (dgvSaleReport.Columns[e.ColumnIndex].Name == "colRemove")
            {
                //get the id of that row
                DataGridViewRow gvr = dgvSaleReport.Rows[e.RowIndex];
                MessageBox.Show("you want to delete item with ID: " + gvr.Cells[0].Value.ToString());
            }
        }
    }
}