using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPS.View
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //design

        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show(this);
        }

        private void pbAddProduct_Click_1(object sender, EventArgs e)
        {
            ProductAddForm addProduct = new ProductAddForm();
            addProduct.Show(this);
        }
    }
}
