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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public static string id = "";
        public static string isim = "";
        public static string soyisim = "";
        public static string tc = "";
        public static string eposta = "";
        public static string sifre = "";
        public static string telefon = "";
        public static string kullanici;
        public static string sifre2;

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnasayfa gec1 = new frmAnasayfa();
            kullanici = txtMail.Text;
            sifre2 = txtSifre.Text;

            if (txtMail.Text == "admin" && txtSifre.Text == "admin")
            {
                frmAdmin gec2 = new frmAdmin();
                gec2.Show();
                this.Hide();
            }
            else
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM kayit where Eposta='" + kullanici + "' AND Sifre='" + sifre2 + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = dr[0].ToString();
                    isim = dr[1].ToString();
                    soyisim = dr[2].ToString();
                    tc = dr[3].ToString();
                    eposta = dr[4].ToString();
                    sifre = dr[5].ToString();
                    telefon = dr[6].ToString();

                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    gec1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();
            }
        }

        private void lblsifre_Click(object sender, EventArgs e)
        {
            frmSifreUnuttum gec = new frmSifreUnuttum();
            gec.Show();
            this.Hide();
        }

        private void lbluye_Click(object sender, EventArgs e)
        {
            frmUye gec = new frmUye();
            gec.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://facebook.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://instagram.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }

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
