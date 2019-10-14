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
using SRPS.Controller;

namespace SRPS
{
    public partial class Login_in : Form
    {
        connectionSetting connectionValue = new connectionSetting();

        private int count = 0;
        MySqlConnection connection;

        public Login_in()
        {
            connection = new MySqlConnection("server = " + connectionValue.server()
                + "; database = " + connectionValue.database() + "; username = "+connectionValue.username()
                +"; password="+connectionValue.password()+";");
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

        private void Login_in_Load(object sender, EventArgs e)
        {

        }
    }
}
