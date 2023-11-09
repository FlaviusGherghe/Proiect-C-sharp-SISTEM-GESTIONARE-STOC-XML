namespace Proiect_GHERGHE_FLAVIUS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            pictureBox8 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CatLbl = new Label();
            label3 = new Label();
            panel3 = new Panel();
            FurLbl = new Label();
            label4 = new Label();
            panel6 = new Panel();
            TopComandaLbl = new Label();
            label19 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SkyBlue;
            label2.Location = new Point(66, 67);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 37;
            label2.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 42);
            panel1.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(21, 24);
            label11.Name = "label11";
            label11.Size = new Size(29, 13);
            label11.TabIndex = 15;
            label11.Text = "Stoc";
            label11.Click += label11_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(28, 30);
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(492, 24);
            label10.Name = "label10";
            label10.Size = new Size(64, 13);
            label10.TabIndex = 13;
            label10.Text = "Dashboard";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(412, 24);
            label9.Name = "label9";
            label9.Size = new Size(51, 13);
            label9.TabIndex = 12;
            label9.Text = "Comenzi";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(326, 23);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 11;
            label8.Text = "Furnizori";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(247, 24);
            label7.Name = "label7";
            label7.Size = new Size(40, 13);
            label7.TabIndex = 10;
            label7.Text = "Clienti";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(164, 23);
            label6.Name = "label6";
            label6.Size = new Size(54, 13);
            label6.TabIndex = 9;
            label6.Text = "Categorii";
            label6.Click += label6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(469, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 30);
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(390, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 30);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(299, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 30);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(224, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 27);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(137, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 24);
            label5.Name = "label5";
            label5.Size = new Size(49, 13);
            label5.TabIndex = 3;
            label5.Text = "Produse";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 27);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(637, 7);
            label1.Name = "label1";
            label1.Size = new Size(281, 30);
            label1.TabIndex = 1;
            label1.Text = "SISTEM GESTIONARE STOC";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 152);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(CatLbl);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(11, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 189);
            panel2.TabIndex = 38;
            // 
            // CatLbl
            // 
            CatLbl.AutoSize = true;
            CatLbl.BackColor = Color.Transparent;
            CatLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CatLbl.ForeColor = Color.Azure;
            CatLbl.Location = new Point(169, 77);
            CatLbl.Name = "CatLbl";
            CatLbl.Size = new Size(38, 30);
            CatLbl.TabIndex = 39;
            CatLbl.Text = "Nr";
            CatLbl.TextAlign = ContentAlignment.TopCenter;
            CatLbl.Click += CatLbl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(136, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 38;
            label3.Text = "Categorii";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(FurLbl);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(431, 336);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 189);
            panel3.TabIndex = 39;
            // 
            // FurLbl
            // 
            FurLbl.AutoSize = true;
            FurLbl.BackColor = Color.Transparent;
            FurLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FurLbl.ForeColor = Color.Azure;
            FurLbl.Location = new Point(170, 77);
            FurLbl.Name = "FurLbl";
            FurLbl.Size = new Size(38, 30);
            FurLbl.TabIndex = 41;
            FurLbl.Text = "Nr";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Azure;
            label4.Location = new Point(134, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 41;
            label4.Text = "Furnizori";
            // 
            // panel6
            // 
            panel6.BackColor = Color.SkyBlue;
            panel6.Controls.Add(TopComandaLbl);
            panel6.Controls.Add(label19);
            panel6.Location = new Point(846, 336);
            panel6.Name = "panel6";
            panel6.Size = new Size(373, 189);
            panel6.TabIndex = 42;
            // 
            // TopComandaLbl
            // 
            TopComandaLbl.AutoSize = true;
            TopComandaLbl.BackColor = Color.Transparent;
            TopComandaLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TopComandaLbl.ForeColor = Color.Azure;
            TopComandaLbl.Location = new Point(80, 77);
            TopComandaLbl.Name = "TopComandaLbl";
            TopComandaLbl.Size = new Size(38, 30);
            TopComandaLbl.TabIndex = 39;
            TopComandaLbl.Text = "Nr";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Azure;
            label19.Location = new Point(112, 0);
            label19.Name = "label19";
            label19.Size = new Size(145, 30);
            label19.TabIndex = 38;
            label19.Text = "Top comanda";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1231, 621);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label11;
        private PictureBox pictureBox8;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label CatLbl;
        private Label label3;
        private Panel panel3;
        private Label FurLbl;
        private Label label4;
        private Panel panel6;
        private Label TopComandaLbl;
        private Label label19;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}