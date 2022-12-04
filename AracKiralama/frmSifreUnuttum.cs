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
    public partial class frmSifreUnuttum : Form
    {
        public frmSifreUnuttum()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 gec = new Form1();
            gec.Show();
            this.Close();
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSifreTekrar.UseSystemPasswordChar == true)
            {
                txtSifreTekrar.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifreTekrar.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMail.Text != "" || txtSifre.Text != "" || txtSifreTekrar.Text != "")
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    con.Open();
                    cmd = new SqlCommand("update kayit set Sifre='" + txtSifre.Text + "'where Eposta='" + txtMail.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Şifreniz Değiştirilmiştir");
                    Form1 gec = new Form1();
                    gec.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Şifreler eşleşmiyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
