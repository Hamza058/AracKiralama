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
    public partial class frmSepet : Form
    {
        public frmSepet()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public void griddoldur()
        {
            da = new SqlDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Staj");
            con.Close();
        }

        private void frmSepet_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(Application.StartupPath + "\\sozlesme.pdf");
            if (comboBox1.Text == "Bayiden Alacam")
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAnasayfa gec = new frmAnasayfa();
            gec.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adres = "";
            con.Open();
            if (comboBox1.Text == "Adresime Getirin")
                adres = textBox1.Text;
            else
                adres = "Bayiden Alınacak";
            cmd = new SqlCommand("update kayit set adres='" + adres + "'where Eposta='" + Form1.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            frmAnasayfa gec = new frmAnasayfa();
            gec.Show();
            this.Close();
            MessageBox.Show("İşeleminiz Tamamlanmıştır");
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
