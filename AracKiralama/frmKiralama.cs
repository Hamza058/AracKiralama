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
    public partial class frmKiralama : Form
    {
        public frmKiralama()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        DataSet ds;

        public void griddoldur(DataGridView data,String komut)
        {
            da = new SqlDataAdapter(komut, con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            data.DataSource = dt;
            con.Close();
        }

        public void kiralama(String ad, String fiyat, String alis, String iade, String komut)
        {
            string id = Form1.id.ToString();
            con.Open();
            string ekle = "insert into arac_kiralama(kayitid,arac_adi,arac_fiyat,alis_tarihi,iade_tarihi)" + "values ('" + id + "','" + ad + "','" + fiyat + "','" + alis + "','" + iade + "')";
            cmd = new SqlCommand(ekle, con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dataGridView1, komut);
        }

        public void yorum(String Aracad, String yorum)
        {
            con.Open();
            string ekle = "insert into kiralama_yorum(Arac_adi,Ad,Soyad,yorum)" + "values ('" + Aracad + "','" + Form1.isim + "','" + Form1.soyisim + "','" + yorum + "')";
            cmd = new SqlCommand(ekle, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yorumunuz Yapılmıştır.Teşekkür Ederiz...");
        }

        private void frmKiralama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbOtoKiralamaDataSet4.kiralama_yorum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiralama_yorumTableAdapter.Fill(this.dbOtoKiralamaDataSet4.kiralama_yorum);
            pct1.Image = Image.FromFile(Application.StartupPath + "\\resim\\egea.png");
            pct2.Image = Image.FromFile(Application.StartupPath + "\\resim\\i20.png");
            pct3.Image = Image.FromFile(Application.StartupPath + "\\resim\\corolla.png");
            pct4.Image = Image.FromFile(Application.StartupPath + "\\resim\\megane.png");
            pct5.Image = Image.FromFile(Application.StartupPath + "\\resim\\a200amg.png");
            pct6.Image = Image.FromFile(Application.StartupPath + "\\resim\\a3.png");
            label98.Text = Form1.isim.ToString() + " " + Form1.soyisim.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAnasayfa gec = new frmAnasayfa();
            gec.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmProfil gec = new frmProfil();
            gec.Show();
            this.Close();
        }
       
        #region Arac-1
        private void btnGonder1_Click(object sender, EventArgs e)
        {
            yorum(lblAd1.Text, richTextBox1.Text);
            richTextBox1.Clear();
        }
        private void pctYorumOf1_Click(object sender, EventArgs e)
        {
            pnlYorum1.Visible = false;
        }
        private void pnlYorum1_Paint(object sender, PaintEventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd1.Text + "'";
            griddoldur(dataGridView1,komut);
        }
        private void btnFyt1_Click(object sender, EventArgs e)
        {
            int fiyat = 200;
            TimeSpan fark = Convert.ToDateTime(dateTimePicker1.Text) - Convert.ToDateTime(dateTimePicker2.Value);
            int fark1 = Convert.ToInt32(fark.TotalDays) * (-1);
            lblFiyat1.Text = (fark1 * fiyat).ToString() + " TL";
            if (lblFiyat1.Text != "0 TL" && fark1 > 0)
                btnKirala1.Enabled = true;
        }
        private void btnKirala1_Click(object sender, EventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd1.Text + "'";
            kiralama(lblAd1.Text, lblFiyat1.Text, dateTimePicker1.Text, dateTimePicker2.Text, komut);
            frmSepet gec2 = new frmSepet();
            gec2.Show();
            this.Close();
        }
        private void btnYorum1_Click(object sender, EventArgs e)
        {
            pnlYorum1.Visible = true;
        }
        #endregion

        #region Arac-2
        private void btnGonder2_Click(object sender, EventArgs e)
        {
            yorum(lblAd2.Text, richTextBox2.Text);
            richTextBox2.Clear();
        }
        private void pctYorumOf2_Click(object sender, EventArgs e)
        {
            pnlYorum2.Visible = false;
        }
        private void pnlYorum2_Paint(object sender, PaintEventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd2.Text + "'";
            griddoldur(dataGridView2, komut);
        }
        private void btnFyt2_Click(object sender, EventArgs e)
        {
            int fiyat = 150;
            TimeSpan fark = Convert.ToDateTime(dateTimePicker4.Text) - Convert.ToDateTime(dateTimePicker3.Value);
            int fark1 = Convert.ToInt32(fark.TotalDays) * (-1);
            lblFiyat2.Text = (fark1 * fiyat).ToString() + " TL";
            if (lblFiyat2.Text != "0 TL" && fark1 > 0)
                btnKirala2.Enabled = true;
        }
        private void btnKirala2_Click(object sender, EventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd2.Text + "'";
            kiralama(lblAd2.Text, lblFiyat2.Text, dateTimePicker4.Text, dateTimePicker3.Text, komut);
        }
        private void btnYorum2_Click(object sender, EventArgs e)
        {
            pnlYorum2.Visible = true;
        }
        #endregion

        #region Arac_3
        private void btnFyt3_Click(object sender, EventArgs e)
        {
            int fiyat = 300;
            TimeSpan fark = Convert.ToDateTime(dateTimePicker8.Text) - Convert.ToDateTime(dateTimePicker7.Value);
            int fark1 = Convert.ToInt32(fark.TotalDays) * (-1);
            lblFiyat3.Text = (fark1 * fiyat).ToString() + " TL";
            if (lblFiyat3.Text != "0 TL" && fark1 > 0)
                btnKirala3.Enabled = true;
        }

        private void btnKirala3_Click(object sender, EventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd3.Text + "'";
            kiralama(lblAd3.Text, lblFiyat3.Text, dateTimePicker8.Text, dateTimePicker7.Text, komut);
        }

        private void btnYorum3_Click(object sender, EventArgs e)
        {
            pnlYorum3.Visible = true;
        }

        private void btnGonder3_Click(object sender, EventArgs e)
        {
            yorum(lblAd3.Text, richTextBox3.Text);
            richTextBox3.Clear();
        }

        private void pctYorumOf3_Click(object sender, EventArgs e)
        {
            pnlYorum3.Visible = false;
        }

        private void pnlYorum3_Paint(object sender, PaintEventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd3.Text + "'";
            griddoldur(dataGridView3, komut);
        }
        #endregion

        #region Arac_4
        private void btnFyt4_Click(object sender, EventArgs e)
        {
            int fiyat = 250;
            TimeSpan fark = Convert.ToDateTime(dateTimePicker6.Text) - Convert.ToDateTime(dateTimePicker5.Value);
            int fark1 = Convert.ToInt32(fark.TotalDays) * (-1);
            lblFiyat4.Text = (fark1 * fiyat).ToString() + " TL";
            if (lblFiyat4.Text != "0 TL" && fark1 > 0)
                btnKirala4.Enabled = true;
        }

        private void btnKirala4_Click(object sender, EventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd4.Text + "'";
            kiralama(lblAd4.Text, lblFiyat4.Text, dateTimePicker6.Text, dateTimePicker5.Text, komut);
        }

        private void btnYorum4_Click(object sender, EventArgs e)
        {
            pnlYorum4.Visible = true;
        }

        private void btnGonder4_Click(object sender, EventArgs e)
        {
            yorum(lblAd4.Text, richTextBox4.Text);
        }

        private void pctYorumOf4_Click(object sender, EventArgs e)
        {
            pnlYorum4.Visible = false;
        }

        private void pnlYorum4_Paint(object sender, PaintEventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd4.Text + "'";
            griddoldur(dataGridView4, komut);
        }
        #endregion

        #region Arac_5
        private void btnFyt5_Click(object sender, EventArgs e)
        {
            int fiyat = 450;
            TimeSpan fark = Convert.ToDateTime(dateTimePicker12.Text) - Convert.ToDateTime(dateTimePicker11.Value);
            int fark1 = Convert.ToInt32(fark.TotalDays) * (-1);
            lblFiyat5.Text = (fark1 * fiyat).ToString() + " TL";
            if (lblFiyat5.Text != "0 TL" && fark1 > 0)
                btnKirala5.Enabled = true;
        }

        private void btnKirala5_Click(object sender, EventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd5.Text + "'";
            kiralama(lblAd5.Text, lblFiyat5.Text, dateTimePicker12.Text, dateTimePicker11.Text, komut);
        }

        private void btnYorum5_Click(object sender, EventArgs e)
        {
            pnlYorum5.Visible = true;
        }

        private void btnGonder5_Click(object sender, EventArgs e)
        {
            yorum(lblAd5.Text, richTextBox5.Text);
            richTextBox5.Clear();
        }

        private void pctYorumOf5_Click(object sender, EventArgs e)
        {
            pnlYorum5.Visible = false;
        }

        private void pnlYorum5_Paint(object sender, PaintEventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd5.Text + "'";
            griddoldur(dataGridView5, komut);
        }
        #endregion

        #region Arac_6
        private void btnFyt6_Click(object sender, EventArgs e)
        {
            int fiyat = 400;
            TimeSpan fark = Convert.ToDateTime(dateTimePicker10.Text) - Convert.ToDateTime(dateTimePicker9.Value);
            int fark1 = Convert.ToInt32(fark.TotalDays) * (-1);
            lblFiyat6.Text = (fark1 * fiyat).ToString() + " TL";
            if (lblFiyat6.Text != "0 TL" && fark1 > 0)
                btnKirala6.Enabled = true;
        }

        private void btnKirala6_Click(object sender, EventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd6.Text + "'";
            kiralama(lblAd6.Text, lblFiyat6.Text, dateTimePicker10.Text, dateTimePicker9.Text, komut);
        }

        private void btnYorum6_Click(object sender, EventArgs e)
        {
            pnlYorum6.Visible = true;
        }

        private void btnGonder6_Click(object sender, EventArgs e)
        {
            yorum(lblAd6.Text, richTextBox6.Text);
            richTextBox6.Clear();
        }

        private void pctYorumOf6_Click(object sender, EventArgs e)
        {
            pnlYorum6.Visible = false;
        }

        private void pnlYorum6_Paint(object sender, PaintEventArgs e)
        {
            string komut = "select * from kiralama_yorum where Arac_adi='" + lblAd6.Text + "'";
            griddoldur(dataGridView6, komut);
        }
        #endregion

        #region Form Hareketleri

        int hareket;
        int Mouse_X;
        int Mouse_Y;
        private void frmKiralama_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = 0;
        }

        private void frmKiralama_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void frmKiralama_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        #endregion
    }
}
