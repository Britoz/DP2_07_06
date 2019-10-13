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
using System.Globalization;


namespace SRPS
{
    public partial class Prediction : Form
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; database = test; username = root; password=;");

        public Prediction()
        {
            InitializeComponent();
            fillCombo();
        }
        private void fillCombo()
        {
            string query = "select * from product";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string Name = r.GetString("name");
                    cbItem.Items.Add(Name);

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            int col1 = dt.AddMonths(-5).Month;
            int col2 = dt.AddMonths(-4).Month;
            int col3 = dt.AddMonths(-3).Month;
            int col4 = dt.AddMonths(-2).Month;
            int col5 = dt.AddMonths(-1).Month;
            int col6 = dt.Month;
            int[] col = new int[6] { dt.AddMonths(-5).Month , dt.AddMonths(-4).Month , dt.AddMonths(-3).Month ,
                dt.AddMonths(-2).Month , dt.AddMonths(-1).Month , dt.Month};
            for (int i = 0; i < col.Length; i++)
            {
                string strMonthName = mfi.GetAbbreviatedMonthName(col[i]);
                string query = " select sum(quantity) from productsales where productname='" + cbItem.Text
                    + "' and year(datetime)= '" + year + "' and month(datetime)= '" + col[i] + "'";
                string query1 = "select sum(quantity) from productsales where year(datetime)= '" + year +
                    "' and month(datetime)= '" + col[i] + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();
                
                try
                {
                    r.Read();
                    int item_quantity = Convert.ToInt32(r[0]);
                    this.chart1.Series["Total sales of an Item monthly"].Points.AddXY(strMonthName, r[0]);
                    connection.Close();
                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    connection.Open();
                    MySqlDataReader r1 = command1.ExecuteReader();
                    while(r1.Read())
                    {
                        int total_quantity = Convert.ToInt32(r1[0]);
                        double rate = (total_quantity / item_quantity);
                        double rate_an_item = (1 / rate) * 100;
                        this.chart1.Series["Rate of an item monthly"].Points.AddXY(strMonthName, rate_an_item);
                    }

                }catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Invalid!");

                }
                connection.Close();

            }

        }
    }
}

