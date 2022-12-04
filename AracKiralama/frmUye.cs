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
using System.Net.Mail;

namespace AracKiralama
{
    public partial class frmUye : Form
    {
        public frmUye()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string durum = "";
        
        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                durum = "var";
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void griddoldur()
        {
            da = new SqlDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Staj");
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 gec = new Form1();
            gec.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTc.Text == "" || txtMail.Text == "" || txtSifre.Text == "" || txtTlfn.Text == "")
                MessageBox.Show("Lütfen Tüm Bilgileri Doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Email_Format_Kontrol(txtMail.Text);
                if (durum == "var")
                {
                    if (txtTc.TextLength > 10)
                    {
                        con.Open();
                        string ekle;
                        ekle = "insert into kayit(ad,soyad,tc,eposta,sifre,telefon)" + "values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTc.Text + "','" + txtMail.Text + "','" + txtSifre.Text + "','" + txtTlfn.Text + "')";
                        cmd = new SqlCommand(ekle, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        griddoldur();

                        MessageBox.Show("Kaydınız Başarılı Bir Şekilde Oluşturulmuştur");
                        Form1 gec = new Form1();
                        gec.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Geçerli bir TC no giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Geçerli bir eposta giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
                label8.Visible = false;
            else
                label8.Visible = true;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            if (txtSoyad.Text != "")
                label9.Visible = false;
            else
                label9.Visible = true;
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text != "")
                label10.Visible = false;
            else
                label10.Visible = true;
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text != "")
                label11.Visible = false;
            else
                label11.Visible = true;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text != "")
                label12.Visible = false;
            else
                label12.Visible = true;
        }

        private void txtTlfn_TextChanged(object sender, EventArgs e)
        {
            if (txtTlfn.Text != "")
                label13.Visible = false;
            else
                label13.Visible = true;
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTlfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
