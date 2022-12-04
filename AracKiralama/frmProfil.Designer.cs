namespace AracKiralama
{
    partial class frmProfil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfil));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTlfn = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbOtoKiralamaDataSet5 = new AracKiralama.DbOtoKiralamaDataSet5();
            this.aracsatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_satisTableAdapter = new AracKiralama.DbOtoKiralamaDataSet5TableAdapters.arac_satisTableAdapter();
            this.dbOtoKiralamaDataSet1 = new AracKiralama.DbOtoKiralamaDataSet1();
            this.arackiralamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_kiralamaTableAdapter = new AracKiralama.DbOtoKiralamaDataSet1TableAdapters.arac_kiralamaTableAdapter();
            this.aracadiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracfiyatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadetarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoKiralamaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoKiralamaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arackiralamaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(416, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "deneme@hotmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MidnightBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(308, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Bize Ulaşın:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(435, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Kiraladıklarım";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracadiDataGridViewTextBoxColumn1,
            this.aracfiyatDataGridViewTextBoxColumn1,
            this.alistarihiDataGridViewTextBoxColumn,
            this.iadetarihiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.arackiralamaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(311, 404);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(333, 169);
            this.dataGridView2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(74, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Satın Aldıklarım";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracadiDataGridViewTextBoxColumn,
            this.aracfiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracsatisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 404);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(248, 169);
            this.dataGridView1.TabIndex = 47;
            // 
            // lblTlfn
            // 
            this.lblTlfn.AutoSize = true;
            this.lblTlfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTlfn.ForeColor = System.Drawing.Color.Transparent;
            this.lblTlfn.Location = new System.Drawing.Point(143, 316);
            this.lblTlfn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTlfn.Name = "lblTlfn";
            this.lblTlfn.Size = new System.Drawing.Size(16, 17);
            this.lblTlfn.TabIndex = 46;
            this.lblTlfn.Text = "0";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Transparent;
            this.lblSifre.Location = new System.Drawing.Point(497, 271);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(16, 17);
            this.lblSifre.TabIndex = 45;
            this.lblSifre.Text = "0";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Transparent;
            this.lblMail.Location = new System.Drawing.Point(248, 273);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(16, 17);
            this.lblMail.TabIndex = 44;
            this.lblMail.Text = "0";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.Transparent;
            this.lblTc.Location = new System.Drawing.Point(65, 274);
            this.lblTc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(16, 17);
            this.lblTc.TabIndex = 43;
            this.lblTc.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(9, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(453, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(189, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Eposta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "TC No:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(622, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Transparent;
            this.lblAd.Location = new System.Drawing.Point(237, 215);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(70, 25);
            this.lblAd.TabIndex = 37;
            this.lblAd.Text = "label1";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // dbOtoKiralamaDataSet5
            // 
            this.dbOtoKiralamaDataSet5.DataSetName = "DbOtoKiralamaDataSet5";
            this.dbOtoKiralamaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracsatisBindingSource
            // 
            this.aracsatisBindingSource.DataMember = "arac_satis";
            this.aracsatisBindingSource.DataSource = this.dbOtoKiralamaDataSet5;
            // 
            // arac_satisTableAdapter
            // 
            this.arac_satisTableAdapter.ClearBeforeFill = true;
            // 
            // dbOtoKiralamaDataSet1
            // 
            this.dbOtoKiralamaDataSet1.DataSetName = "DbOtoKiralamaDataSet1";
            this.dbOtoKiralamaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arackiralamaBindingSource
            // 
            this.arackiralamaBindingSource.DataMember = "arac_kiralama";
            this.arackiralamaBindingSource.DataSource = this.dbOtoKiralamaDataSet1;
            // 
            // arac_kiralamaTableAdapter
            // 
            this.arac_kiralamaTableAdapter.ClearBeforeFill = true;
            // 
            // aracadiDataGridViewTextBoxColumn1
            // 
            this.aracadiDataGridViewTextBoxColumn1.DataPropertyName = "arac_adi";
            this.aracadiDataGridViewTextBoxColumn1.HeaderText = "ARAC-ADI";
            this.aracadiDataGridViewTextBoxColumn1.Name = "aracadiDataGridViewTextBoxColumn1";
            // 
            // aracfiyatDataGridViewTextBoxColumn1
            // 
            this.aracfiyatDataGridViewTextBoxColumn1.DataPropertyName = "arac_fiyat";
            this.aracfiyatDataGridViewTextBoxColumn1.HeaderText = "ARAC-FIYAT";
            this.aracfiyatDataGridViewTextBoxColumn1.Name = "aracfiyatDataGridViewTextBoxColumn1";
            this.aracfiyatDataGridViewTextBoxColumn1.Width = 70;
            // 
            // alistarihiDataGridViewTextBoxColumn
            // 
            this.alistarihiDataGridViewTextBoxColumn.DataPropertyName = "alis_tarihi";
            this.alistarihiDataGridViewTextBoxColumn.HeaderText = "ALIS-TARIHI";
            this.alistarihiDataGridViewTextBoxColumn.Name = "alistarihiDataGridViewTextBoxColumn";
            // 
            // iadetarihiDataGridViewTextBoxColumn
            // 
            this.iadetarihiDataGridViewTextBoxColumn.DataPropertyName = "iade_tarihi";
            this.iadetarihiDataGridViewTextBoxColumn.HeaderText = "IADE-TARIHI";
            this.iadetarihiDataGridViewTextBoxColumn.Name = "iadetarihiDataGridViewTextBoxColumn";
            // 
            // aracadiDataGridViewTextBoxColumn
            // 
            this.aracadiDataGridViewTextBoxColumn.DataPropertyName = "arac_adi";
            this.aracadiDataGridViewTextBoxColumn.HeaderText = "ARAC-ADI";
            this.aracadiDataGridViewTextBoxColumn.Name = "aracadiDataGridViewTextBoxColumn";
            this.aracadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // aracfiyatDataGridViewTextBoxColumn
            // 
            this.aracfiyatDataGridViewTextBoxColumn.DataPropertyName = "arac_fiyat";
            this.aracfiyatDataGridViewTextBoxColumn.HeaderText = "arac_fiyat";
            this.aracfiyatDataGridViewTextBoxColumn.Name = "aracfiyatDataGridViewTextBoxColumn";
            this.aracfiyatDataGridViewTextBoxColumn.Width = 80;
            // 
            // frmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(665, 593);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTlfn);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfil";
            this.Load += new System.EventHandler(this.frmProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoKiralamaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoKiralamaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arackiralamaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTlfn;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DbOtoKiralamaDataSet5 dbOtoKiralamaDataSet5;
        private System.Windows.Forms.BindingSource aracsatisBindingSource;
        private DbOtoKiralamaDataSet5TableAdapters.arac_satisTableAdapter arac_satisTableAdapter;
        private DbOtoKiralamaDataSet1 dbOtoKiralamaDataSet1;
        private System.Windows.Forms.BindingSource arackiralamaBindingSource;
        private DbOtoKiralamaDataSet1TableAdapters.arac_kiralamaTableAdapter arac_kiralamaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracadiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracfiyatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iadetarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracfiyatDataGridViewTextBoxColumn;
    }
}