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
using SRPS;

namespace SRPS
{
    public partial class Login_in : Form
    {
        private int count = 0;
        MySqlConnection connection = new MySqlConnection("server = localhost; database = test; username = root; password=;");
        public Login_in()
        {
            InitializeComponent();
            
        }

        private void Btbgo_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtname.Text;
            password = txtpassword.Text;

            if (username == "")
            {
                MessageBox.Show("please enter your username");
            }
            else if(password == "")
            {
                MessageBox.Show("please enter your password");
              
            }
            else
            {
                count++;
                if (count > 2)
                {
                    MessageBox.Show("Login in system has been block", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    string query = "SELECT * FROM login WHERE username ='" + username + "'&& password ='" + password + "'";
                    MySqlDataAdapter data = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    //fill all the table 
                    data.Fill(datatable);
                    if (datatable.Rows.Count == 1)
                    {
                        MessageBox.Show("welcome");
                        
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Try again please");
                    }
                }
            }
        }
    }
}
