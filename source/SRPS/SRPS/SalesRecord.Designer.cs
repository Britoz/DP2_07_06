namespace SRPS
{
    partial class SalesRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addproductbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosspriceproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addproductbtn
            // 
            this.addproductbtn.Location = new System.Drawing.Point(520, 102);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Size = new System.Drawing.Size(120, 44);
            this.addproductbtn.TabIndex = 0;
            this.addproductbtn.Text = "Add";
            this.addproductbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SerialNumberOfProduct\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addproductbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 647);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item List";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.quantityproduct,
            this.priceproduct,
            this.grosspriceproduct});
            this.dataGridView1.Location = new System.Drawing.Point(0, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(848, 437);
            this.dataGridView1.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // quantityproduct
            // 
            this.quantityproduct.HeaderText = "Price/unit";
            this.quantityproduct.MinimumWidth = 8;
            this.quantityproduct.Name = "quantityproduct";
            this.quantityproduct.Width = 150;
            // 
            // priceproduct
            // 
            this.priceproduct.HeaderText = "Quantity";
            this.priceproduct.MinimumWidth = 8;
            this.priceproduct.Name = "priceproduct";
            this.priceproduct.Width = 150;
            // 
            // grosspriceproduct
            // 
            this.grosspriceproduct.HeaderText = "GrossPrice";
            this.grosspriceproduct.MinimumWidth = 8;
            this.grosspriceproduct.Name = "grosspriceproduct";
            this.grosspriceproduct.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 44);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(866, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 348);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Invoice Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Staff Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Items";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(313, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 44);
            this.textBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(937, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "TOTAL";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1538, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 100);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1297, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "DATE";
            this.label7.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(951, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "123";
            this.label8.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1286, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "12/09/2019";
            this.label9.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 37);
            this.label10.TabIndex = 5;
            this.label10.Text = "12324";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 37);
            this.label11.TabIndex = 5;
            this.label11.Text = "10";
            // 
            // SalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1720, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesRecord";
            this.Text = "Total Price";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addproductbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosspriceproduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

