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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static int sirano = 1;
        public static int sirano1 = 11;
        public static int sirano2 = 14;
        public static int sirano3 = 17;
        frmSepet gec2 = new frmSepet();

        public void griddoldur()
        {
            da = new SqlDataAdapter("Select *From arac_satis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Staj");
            con.Close();
        }

        public void satinalim(String ad, String fiyat)
        {
            string id = Form1.id.ToString();
            con.Open();
            string ekle = "insert into arac_satis(kayitid,arac_adi,arac_fiyat)" + "values ('" + id + "','" + ad + "','" + fiyat + "')";
            cmd = new SqlCommand(ekle, con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + 1 + ".jpg");
            pct2.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + 1 + ".jpeg");
            pct3.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + 11 + ".jpg");
            pct4.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + 1 + ".png");
            pct5.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + 14 + ".jpg");
            pct6.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + 17 + ".jpg");
            label6.Text = Form1.isim.ToString() + " " + Form1.soyisim.ToString();
        }

        #region Resim
        private void pct_azalt1_Click(object sender, EventArgs e)
        {
            sirano -= 1;
            if (sirano == 0)
                sirano = 2;
            pct1.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano + ".jpg");
        }

        private void pct_arttir1_Click(object sender, EventArgs e)
        {
            if (sirano == 2)
                sirano = 0;
            sirano += 1;
            pct1.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano + ".jpg");
        }

        private void pct_azalt2_Click(object sender, EventArgs e)
        {
            sirano -= 1;
            if (sirano == 0)
                sirano = 2;
            pct2.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano + ".jpeg");
        }

        private void pct_arttir2_Click(object sender, EventArgs e)
        {
            if (sirano == 2)
                sirano = 0;
            sirano += 1;
            pct2.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano + ".jpeg");
        }

        private void pct_azalt3_Click(object sender, EventArgs e)
        {
            sirano1 -= 1;
            if (sirano1 == 10)
                sirano1 = 12;
            pct3.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano1 + ".jpg");
        }

        private void pct_arttir3_Click(object sender, EventArgs e)
        {
            if (sirano1 == 12)
                sirano1 = 10;
            sirano1 += 1;
            pct3.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano1 + ".jpg");
        }

        private void pct_azalt4_Click(object sender, EventArgs e)
        {
            sirano -= 1;
            if (sirano == 0)
                sirano = 2;
            pct4.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano + ".png");
        }

        private void pct_arttir4_Click(object sender, EventArgs e)
        {
            if (sirano == 2)
                sirano = 0;
            sirano += 1;
            pct4.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano + ".png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAnasayfa gec = new frmAnasayfa();
            gec.Show();
            this.Close();
        }

        private void pct_azalt5_Click(object sender, EventArgs e)
        {
            sirano2 -= 1;
            if (sirano2 == 13)
                sirano2 = 15;
            pct5.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano2 + ".jpg");
        }

        private void pct_arttir5_Click(object sender, EventArgs e)
        {
            if (sirano2 == 15)
                sirano2 = 13;
            sirano2 += 1;
            pct5.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano2 + ".jpg");
        }

        private void pct_azalt6_Click(object sender, EventArgs e)
        {
            sirano3 -= 1;
            if (sirano3 == 16)
                sirano3 = 18;
            pct6.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano3 + ".jpg");
        }

        private void pct_arttir6_Click(object sender, EventArgs e)
        {
            if (sirano3 == 18)
                sirano3 = 16;
            sirano3 += 1;
            pct6.Image = Image.FromFile(Application.StartupPath + "\\resim\\" + sirano3 + ".jpg");
        }
        #endregion

        #region Satis
        private void button1_Click(object sender, EventArgs e)
        {
            satinalim(lblAd1.Text, lblFyt1.Text);
            gec2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satinalim(lblAd2.Text, lblFyt2.Text);
            gec2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            satinalim(lblAd3.Text, lblFyt3.Text);
            gec2.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            satinalim(lblAd4.Text, lblFyt4.Text);
            gec2.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            satinalim(lblAd5.Text, lblFyt5.Text);
            gec2.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            satinalim(lblAd6.Text, lblFyt6.Text);
            gec2.Show();
            this.Close();
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmProfil gec = new frmProfil();
            gec.Show();
            this.Close();
        }

        #region Form Hareketleri

        int hareket;
        int Mouse_X;
        int Mouse_Y;
        private void frmSatis_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = 0;
        }

        private void frmSatis_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void frmSatis_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        #endregion
    }
}
