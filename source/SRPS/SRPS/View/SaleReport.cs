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
using MySql.Data.MySqlClient;
using SRPS.View;
using System.IO;

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
            LoadListMonth();
            rbMonthly.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rbWeekly.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }
        //load all month in one year to the combobox
        private void LoadListMonth()
        {
            
            foreach (var month in monthly)
            {
                cbChoosing.Items.Add(month);
            }
            cbChoosing.Text = "Choosing month";
        }

        //we will load all 52 week to the combobox
        private void LoadListWeek()
        {
            for (int i = 1;i<=52;i++)
            {
                cbChoosing.Items.Add(i);
            }
            cbChoosing.Text = "Choosing week";
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

        //we will load the weekly by get the week and the year and send the request to ask the datas of the weekly 
        //to controller, then controller will do the rest.
        //after get the value from controller, we will store them to the saleRecord Model
        private void LoadWeeklyData(int week, int year)
        {
            //we call the controller to send the request
            SaleReportController controller = new SaleReportController();

            //firstly we have to clear the sale record to make sure it will be empty before reload it again
            saleRecordModelBindingSource.Clear();

            //View will send the request to controller to ask the value in specifict week in that year
            //then we will get each date in that week and show them in Sale record
            foreach (var data in controller.GetAllSaleRecordByWeekAndYear(week, year))
            {
                saleRecordModelBindingSource.Add(data);
            }
        }

        private void LoadMonthlyData(monthInYear type, int year)
        {
            saleRecordModelBindingSource.Clear();
            SaleReportController controller = new SaleReportController();

            MySqlConnection connection = new MySqlConnection("server = localhost; database = srps; username = root; password=123456;");
            string txt = "select sum(totalprice) from salesrecord group by year(date)='" + year.ToString() + "'" + ", month(date)='" + type.ToString() + "'";
            MySqlCommand command = new MySqlCommand(txt, connection);
            connection.Open();
            MySqlDataReader r = command.ExecuteReader();
            MonthlyResult monthlyResult = new MonthlyResult((int)type,year);
            
            while (r.Read())
            {
                int total = int.Parse(r[0].ToString());
                int monthly = Convert.ToInt32(type);
                //int totalItems = int.Parse(r[1].ToString());

                monthlyResult.LoadData(year, monthly, total);
            }
            monthlyResult.Show();
            //foreach (var data in controller.GetALlSaleRecordByMonthAndYear(type, year))
            //{
            //    saleRecordModelBindingSource.Add(data);
            //}
            
            
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

        private void RbWeekly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //year cannot be empty, because that we need year to know which month in year or which week in year
            if(txtYear.Text != "")
            {
                int year = 0;
                //checking if they want to sort the report by Monthly or by Weekly

                if (rbMonthly.Checked)
                {
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("year cannot be empty: " + ex);
                    }
                }
                else
                {
                    try
                    {
                        year = Convert.ToInt32(txtYear.Text);

                        if (year >= 2000 && year <= DateTime.Now.Year)
                        {
                            LoadWeeklyData(cbChoosing.SelectedIndex + 1, year);
                        }
                        else
                        {
                            MessageBox.Show("invalide year");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("year cannot be empty: " + ex);
                    }
                }
                
            }
            else
            {
                
            }
           
        }

        //allow user to change the combobox while they change the radio button
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            //before we reload the combobox, we have to clear all previous value first, 
            //in case of we dupplicate vaule
            cbChoosing.Items.Clear();
            if (rbMonthly.Checked)
            {
                LoadListMonth();
            }
            else if (rbWeekly.Checked)
            {
                LoadListWeek();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SalesRecord add = new SalesRecord();
            add.Show();
        }

        private void btnExtractCSV_Click(object sender, EventArgs e)
        {
            StringBuilder csvContent = new StringBuilder();

            WriteTitleCSVFile(csvContent);
            WriteValueCSVFile(csvContent);

            string csvPath = "";
            //looking the file, if it is not exit, create new
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            dlg.SelectedPath = @"C:\Users\lythe\OneDrive - Swinburne University\year 3\sem 2\DP2\Clone\DP2_07_06\source\SRPS\SRPS\CSV\";
            // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                csvPath = dlg.SelectedPath;

                if (rbMonthly.Checked)
                {
                    csvPath += @"\monthly.csv";
                }
                else if (rbWeekly.Checked)
                {
                    csvPath += @"\weekly.csv";
                }

                try
                {
                    File.WriteAllText(csvPath, csvContent.ToString());
                    MessageBox.Show("write file successful");
                }
                catch (DirectoryNotFoundException exc)
                {
                    MessageBox.Show("Path not exit: " + exc);
                }
            }
            else
            {
                // This prevents a crash when you close out of the window with nothing
            }
        }

        private void WriteTitleCSVFile(StringBuilder csvContent)
        {
            int numberOfColumn = dgvSaleReport.DisplayedColumnCount(true);

            string titleName = "";
            for(int i = 0; i<numberOfColumn-1; i++)
            {
                titleName += dgvSaleReport.Columns[i].DataPropertyName + ",";
            }
            titleName += dgvSaleReport.Columns[numberOfColumn-1].DataPropertyName;

            csvContent.AppendLine(titleName);
        }

        private void WriteValueCSVFile(StringBuilder csvContent)
        {
            int numberOfValue = dgvSaleReport.DisplayedRowCount(true) - 1;
            int numberOfColumn = dgvSaleReport.DisplayedColumnCount(true);

            for(int i=0;i< numberOfValue; i++)
            {
                DataGridViewRow gvr = dgvSaleReport.Rows[i];
                string columnValue = "";
                for (int j=0;j < numberOfColumn - 1; j++)
                {
                    //gvr.Cells[0].Value.ToString()
                    columnValue += gvr.Cells[j].Value.ToString() + ",";
                }
                columnValue += gvr.Cells[numberOfColumn-1].Value.ToString();

                csvContent.AppendLine(columnValue);
            }
        }
    }
}
