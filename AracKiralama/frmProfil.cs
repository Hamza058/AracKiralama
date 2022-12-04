using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;

        public void grid()
        {
            con.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from arac_satis where kayitid='" + Form1.id + "'", con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void grid1()
        {

            con.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from arac_kiralama where kayitid='" + Form1.id + "'", con);
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbOtoKiralamaDataSet1.arac_kiralama' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arac_kiralamaTableAdapter.Fill(this.dbOtoKiralamaDataSet1.arac_kiralama);
            // TODO: Bu kod satırı 'dbOtoKiralamaDataSet5.arac_satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arac_satisTableAdapter.Fill(this.dbOtoKiralamaDataSet5.arac_satis);
            lblAd.Text = Form1.isim.ToString() + " " + Form1.soyisim.ToString();
            lblTc.Text = Form1.tc.ToString();
            lblMail.Text = Form1.eposta.ToString();
            lblSifre.Text = Form1.sifre.ToString();
            lblTlfn.Text = Form1.telefon.ToString();
            grid();
            grid1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAnasayfa gec = new frmAnasayfa();
            gec.Show();
            this.Close();
        }
    }
}
