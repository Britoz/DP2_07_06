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
using SRPS.Model;

namespace SRPS
{
    public partial class SalesRecord : Form
    {
        MySqlConnection connection = new MySqlConnection("server =localhost;database =srps;username = root;password =123456;");
        static int totalPrice = 0;
        static int totalItems = 0;
        private readonly DataGridView _dataGridView;

        public DataGridView DataGridView => _dataGridView;

        public SalesRecord()
        {
            InitializeComponent();
            _dataGridView = dataGridView1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            lblTime.Text = DateTime.Now.ToShortTimeString();
            salesNumberUpdate();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {
                    }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Addproductbtn_Click(object sender, EventArgs e)
        {
            try {
                string txt = "select * from product where serialnumber='" + textBoxSerialNumber.Text + "'";
                MySqlCommand command = new MySqlCommand(txt, connection);
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();
                //name of the medicine
                
                while (r.Read())
                {
                    int price = int.Parse(textBoxQuantity.Text.Trim()) * int.Parse(r[5].ToString());
                    totalItems += int.Parse(textBoxQuantity.Text.Trim());
                    totalPrice += price;

                    dataGridView1.Rows.Add("Edit",dataGridView1.RowCount, r[1], r[5], textBoxQuantity.Text.Trim(), price);
                }
                
                lblTotal.Text = " " + totalPrice + " ";
                lblItems.Text = " " + totalItems + " ";
                connection.Close();

            } catch(Exception ee)
            {
                MessageBox.Show(ee.Message, "Error from database");
            }
            textBoxSerialNumber.Focus();
            textBoxSerialNumber.Clear();
            textBoxQuantity.Clear();

        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                textBoxQuantity.Enabled = true;
                textBoxQuantity.Focus();
            }
        }

        
        private void salesNumberUpdate()
        {
            connection.Open();
            string query = "select max(id) from salesrecord ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dr;
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                string salesnumber = dr[0].ToString();
                if (salesnumber == "")
                {
                    lblSalesNumber.Text = "1";
                }
                else
                {
                    int num = int.Parse(dr[0].ToString());
                    num += 1;
                    lblSalesNumber.Text = num.ToString();
                }
            }
            connection.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("There is no sales added in this record !! Please insert sales items");
                textBoxSerialNumber.Focus();
            }
            else if (txtStaffName.Text == "")
            {
                MessageBox.Show("Staff name required");
                txtStaffName.Focus();
            }
            else
            {
                try {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "insert into salesrecord(salesid,totalprice,staffname,date,time)values(@salesid,@totalprice," +
                        "@staffname,@date,@time)";
                    cmd.Parameters.AddWithValue("@salesid", lblSalesNumber.Text);
                    cmd.Parameters.AddWithValue("@totalprice", lblTotal.Text);
                    cmd.Parameters.AddWithValue("@staffname", txtStaffName.Text);
                    cmd.Parameters.AddWithValue("@date", lblDate.Text);
                    cmd.Parameters.AddWithValue("@time", lblTime.Text);
                  

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record added...");
                    connection.Close();
                    txtStaffName.Clear();
                    lblItems.Text = "0";
                    lblTotal.Text = "0";
                    dataGridView1.Rows.Clear();
                    salesNumberUpdate();

                    
                }catch(Exception ee)
                {
                    MessageBox.Show(ee.Message, "Invalid Database!");
                }
            }
        }
        
      
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Edit edit = new Edit(100);
            edit.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click to the Edit button in the cell
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit")
            {
                //get the id of that row
                DataGridViewRow gvr = dataGridView1.Rows[e.RowIndex];

                Edit edit = new Edit(gvr.Cells[1].Value.ToString(), totalItems);
                edit.Show();
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            SaleReport report = new SaleReport();
            report.Show();
        }
    }
}
