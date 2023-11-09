namespace Proiect_GHERGHE_FLAVIUS
{
    partial class Furnizori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Furnizori));
            FurnizoriAfisare = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            StergeBtn = new Button();
            SalveazaBtn = new Button();
            AdresaFurnizorTb = new TextBox();
            TelefonFurnizorTb = new TextBox();
            NumeFurnizorTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
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
            EditeazaBtn = new Button();
            AdaugaBtn = new Button();
            IncarcaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)FurnizoriAfisare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FurnizoriAfisare
            // 
            FurnizoriAfisare.BackgroundColor = Color.SkyBlue;
            FurnizoriAfisare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FurnizoriAfisare.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            FurnizoriAfisare.Location = new Point(293, 91);
            FurnizoriAfisare.MultiSelect = false;
            FurnizoriAfisare.Name = "FurnizoriAfisare";
            FurnizoriAfisare.ReadOnly = true;
            FurnizoriAfisare.RowTemplate.Height = 25;
            FurnizoriAfisare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FurnizoriAfisare.Size = new Size(920, 501);
            FurnizoriAfisare.TabIndex = 47;
            FurnizoriAfisare.MouseClick += FurnizoriAfisare_MouseClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Furnizor";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 292;
            // 
            // Column2
            // 
            Column2.HeaderText = "Telefon";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 292;
            // 
            // Column3
            // 
            Column3.HeaderText = "Adresa";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 292;
            // 
            // StergeBtn
            // 
            StergeBtn.BackColor = Color.Red;
            StergeBtn.ForeColor = SystemColors.ControlLightLight;
            StergeBtn.Location = new Point(155, 521);
            StergeBtn.Name = "StergeBtn";
            StergeBtn.Size = new Size(75, 23);
            StergeBtn.TabIndex = 46;
            StergeBtn.Text = "Sterge";
            StergeBtn.UseVisualStyleBackColor = false;
            StergeBtn.Click += StergeBtn_Click;
            // 
            // SalveazaBtn
            // 
            SalveazaBtn.BackColor = Color.Green;
            SalveazaBtn.ForeColor = SystemColors.ControlLightLight;
            SalveazaBtn.Location = new Point(108, 550);
            SalveazaBtn.Name = "SalveazaBtn";
            SalveazaBtn.Size = new Size(75, 23);
            SalveazaBtn.TabIndex = 44;
            SalveazaBtn.Text = "Salveaza";
            SalveazaBtn.UseVisualStyleBackColor = false;
            SalveazaBtn.Click += SalveazaBtn_Click;
            // 
            // AdresaFurnizorTb
            // 
            AdresaFurnizorTb.Location = new Point(54, 396);
            AdresaFurnizorTb.Multiline = true;
            AdresaFurnizorTb.Name = "AdresaFurnizorTb";
            AdresaFurnizorTb.PlaceholderText = "Adresa";
            AdresaFurnizorTb.Size = new Size(181, 53);
            AdresaFurnizorTb.TabIndex = 42;
            // 
            // TelefonFurnizorTb
            // 
            TelefonFurnizorTb.Location = new Point(54, 342);
            TelefonFurnizorTb.Name = "TelefonFurnizorTb";
            TelefonFurnizorTb.PlaceholderText = "Telefon";
            TelefonFurnizorTb.Size = new Size(181, 23);
            TelefonFurnizorTb.TabIndex = 41;
            // 
            // NumeFurnizorTb
            // 
            NumeFurnizorTb.Location = new Point(54, 290);
            NumeFurnizorTb.Name = "NumeFurnizorTb";
            NumeFurnizorTb.PlaceholderText = "NumeFurnizor";
            NumeFurnizorTb.Size = new Size(181, 23);
            NumeFurnizorTb.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SkyBlue;
            label4.Location = new Point(52, 256);
            label4.Name = "label4";
            label4.Size = new Size(178, 21);
            label4.TabIndex = 39;
            label4.Text = "Gestioneaza furnizorii";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SkyBlue;
            label3.Location = new Point(721, 56);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 38;
            label3.Text = "Furnizori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SkyBlue;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(281, 30);
            label2.TabIndex = 37;
            label2.Text = "SISTEM GESTIONARE STOC";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 152);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
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
            label11.Location = new Point(22, 24);
            label11.Name = "label11";
            label11.Size = new Size(29, 13);
            label11.TabIndex = 15;
            label11.Text = "Stoc";
            label11.Click += label11_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 9);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(28, 30);
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(506, 24);
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
            label9.Location = new Point(423, 23);
            label9.Name = "label9";
            label9.Size = new Size(51, 13);
            label9.TabIndex = 12;
            label9.Text = "Comenzi";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(337, 22);
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
            label7.Location = new Point(253, 24);
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
            label6.Location = new Point(160, 24);
            label6.Name = "label6";
            label6.Size = new Size(54, 13);
            label6.TabIndex = 9;
            label6.Text = "Categorii";
            label6.Click += label6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(480, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 30);
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(401, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 30);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(310, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 30);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(223, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 27);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(133, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(78, 24);
            label5.Name = "label5";
            label5.Size = new Size(49, 13);
            label5.TabIndex = 3;
            label5.Text = "Produse";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(57, 12);
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
            // EditeazaBtn
            // 
            EditeazaBtn.BackColor = Color.DarkGray;
            EditeazaBtn.ForeColor = SystemColors.ControlLightLight;
            EditeazaBtn.Location = new Point(155, 482);
            EditeazaBtn.Name = "EditeazaBtn";
            EditeazaBtn.Size = new Size(75, 23);
            EditeazaBtn.TabIndex = 48;
            EditeazaBtn.Text = "Editeaza";
            EditeazaBtn.UseVisualStyleBackColor = false;
            EditeazaBtn.Click += EditeazaBtn_Click;
            // 
            // AdaugaBtn
            // 
            AdaugaBtn.BackColor = Color.LimeGreen;
            AdaugaBtn.ForeColor = SystemColors.ControlLightLight;
            AdaugaBtn.Location = new Point(52, 482);
            AdaugaBtn.Name = "AdaugaBtn";
            AdaugaBtn.Size = new Size(75, 23);
            AdaugaBtn.TabIndex = 50;
            AdaugaBtn.Text = "Adauga";
            AdaugaBtn.UseVisualStyleBackColor = false;
            AdaugaBtn.Click += AdaugaBtn_Click;
            // 
            // IncarcaBtn
            // 
            IncarcaBtn.BackColor = Color.Brown;
            IncarcaBtn.ForeColor = SystemColors.ControlLightLight;
            IncarcaBtn.Location = new Point(52, 521);
            IncarcaBtn.Name = "IncarcaBtn";
            IncarcaBtn.Size = new Size(75, 23);
            IncarcaBtn.TabIndex = 51;
            IncarcaBtn.Text = " Incarca";
            IncarcaBtn.UseVisualStyleBackColor = false;
            IncarcaBtn.Click += IncarcaBtn_Click;
            // 
            // Furnizori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1231, 621);
            Controls.Add(IncarcaBtn);
            Controls.Add(AdaugaBtn);
            Controls.Add(EditeazaBtn);
            Controls.Add(FurnizoriAfisare);
            Controls.Add(StergeBtn);
            Controls.Add(SalveazaBtn);
            Controls.Add(AdresaFurnizorTb);
            Controls.Add(TelefonFurnizorTb);
            Controls.Add(NumeFurnizorTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Furnizori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Furnizori";
            ((System.ComponentModel.ISupportInitialize)FurnizoriAfisare).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FurnizoriAfisare;
        private Button StergeBtn;
        private Button SalveazaBtn;
        private TextBox AdresaFurnizorTb;
        private TextBox TelefonFurnizorTb;
        private TextBox NumeFurnizorTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
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
        private Button EditeazaBtn;
        private Button AdaugaBtn;
        private Button IncarcaBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}