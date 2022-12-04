using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSatis gec = new frmSatis();
            gec.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmKiralama gec = new frmKiralama();
            gec.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 gec = new Form1();
            gec.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmProfil gec = new frmProfil();
            gec.Show();
            this.Close();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            label6.Text = Form1.isim.ToString() + " " + Form1.soyisim.ToString();
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
