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
using SRPS.Model;

namespace SRPS.View
{
    public partial class ProductAddForm : Form
    {
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductController controller = new ProductController();

            SalesProductModel model = new SalesProductModel();
            ProductDBModel db = new ProductDBModel();

            model.Name = txtProductName.Text;
            model.Serialnumber = Convert.ToInt32(txtSerialnumber.Text);
            model.Quantity = Convert.ToInt32(txtQuantity.Text);
            model.Unitprice = Convert.ToInt32(txtPricePerUnit.Text);
            model.Description = txtDescription.Text;
            model.DateImport = dtpDateImport.Text;

            //true mean visible, have to use another
            if (db.CheckVisibleName(model.Name))
            {
                MessageBox.Show("Name visible");
            }
            else
            {
                if (db.CheckVisibleSerialnumber(model.Serialnumber.ToString()))
                {
                    MessageBox.Show("Serialnumber visible");
                }
                else
                {
                    if (controller.AddProduct(model))
                    {
                        MessageBox.Show("insert successful");
                    }
                    else
                    {
                        MessageBox.Show("insert invalide");
                    }
                }
                
            }
            

        }
    }
}
