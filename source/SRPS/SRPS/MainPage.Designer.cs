namespace SRPS.View
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSalesRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMainPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(906, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // lblSalesRecord
            // 
            this.lblSalesRecord.AutoSize = true;
            this.lblSalesRecord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSalesRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesRecord.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSalesRecord.Image = ((System.Drawing.Image)(resources.GetObject("lblSalesRecord.Image")));
            this.lblSalesRecord.Location = new System.Drawing.Point(432, 677);
            this.lblSalesRecord.Name = "lblSalesRecord";
            this.lblSalesRecord.Size = new System.Drawing.Size(219, 37);
            this.lblSalesRecord.TabIndex = 2;
            this.lblSalesRecord.Text = "Sales Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(948, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sales Report";
            // 
            // lblMainPage
            // 
            this.lblMainPage.AutoSize = true;
            this.lblMainPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMainPage.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPage.Image = ((System.Drawing.Image)(resources.GetObject("lblMainPage.Image")));
            this.lblMainPage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMainPage.Location = new System.Drawing.Point(658, 48);
            this.lblMainPage.Name = "lblMainPage";
            this.lblMainPage.Size = new System.Drawing.Size(271, 65);
            this.lblMainPage.TabIndex = 4;
            this.lblMainPage.Text = "Main Page";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1636, 1032);
            this.Controls.Add(this.lblMainPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSalesRecord);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSalesRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMainPage;
    }
}