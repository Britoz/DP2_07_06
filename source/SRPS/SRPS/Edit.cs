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
using SRPS.Model;

namespace SRPS
{
    public partial class Edit : Form
    {
        public int id = 0;
        public int saleId = 0;
        public Edit()
        {
            InitializeComponent();
        }
        public Edit(int data)
        {
            InitializeComponent();
            SaleReportController controller = new SaleReportController();

            //get the sale record by ID
            SaleRecordModel saleEdit = controller.GetValueByID(data.ToString());
            id = data;
            Display(saleEdit);
        }

        public Edit(string data, int quantity)
        {
            InitializeComponent();
            //Display(data);
            txtTotalPrice.Text = quantity.ToString();
        }
        private void Display(SaleRecordModel data)
        {
            txtStaffName.Text = data.StaffName;
            txtTime.Text = data.Time;
            txtDate.Text = data.Date;
            txtTotalPrice.Text = data.TotalPrice.ToString();
            
        }



        private void  Btsave_Click(object sender, EventArgs e)
        {

            SaleRecordModel inputData = new SaleRecordModel();
            inputData.Id = id.ToString();
            inputData.StaffName = txtStaffName.Text;
            inputData.Time = txtTime.Text;
            inputData.Date = txtDate.Text;
            inputData.TotalPrice = Convert.ToInt32(txtTotalPrice.Text);

            SaleReportController controller = new SaleReportController();
            bool update = controller.UpdateData(inputData);
           
            
            if (update == true)
            {
                SaleReport report = new SaleReport();
               
                report.Show();
                this.Owner.Hide();
                MessageBox.Show("Update successfully");

               //saleReport.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Unsuccessfully update");
            }
        }

      

       

        private void BtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SaleRecordModel inputData = new SaleRecordModel();
                inputData.Id = id.ToString();
                inputData.StaffName = "";
                inputData.Time = "";
                inputData.Date = "";
                inputData.TotalPrice = 0;

                SaleReportController controller = new SaleReportController();
                bool delete = controller.DeleteValue(inputData);
                if(delete == true)
                {
                    SaleReport report = new SaleReport();
                    report.Show();
                    this.Owner.Hide();
                    MessageBox.Show("Delete successfully");
                    
                    Close();
                    
                }
                else
                {
                    MessageBox.Show("Unsuccessfully delete");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
