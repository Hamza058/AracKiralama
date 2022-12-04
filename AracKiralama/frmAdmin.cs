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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=DbOtoKiralama;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;

        public void griddoldur()
        {
            con.Open();
            da = new SqlDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        public void griddoldur1()
        {
            con.Open();
            da = new SqlDataAdapter("Select *From kiralama_yorum", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];
            con.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbOtoKiralamaDataSet3.kiralama_yorum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiralama_yorumTableAdapter.Fill(this.dbOtoKiralamaDataSet3.kiralama_yorum);
            // TODO: Bu kod satırı 'dbOtoKiralamaDataSet2.arac_satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arac_satisTableAdapter.Fill(this.dbOtoKiralamaDataSet2.arac_satis);
            // TODO: Bu kod satırı 'dbOtoKiralamaDataSet1.arac_kiralama' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arac_kiralamaTableAdapter.Fill(this.dbOtoKiralamaDataSet1.arac_kiralama);
            // TODO: Bu kod satırı 'dbOtoKiralamaDataSet.kayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayitTableAdapter.Fill(this.dbOtoKiralamaDataSet.kayit);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 gec = new Form1();
            gec.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from kayit where ad like'%" + textBox1.Text + "%'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from kayit where soyad like'%" + textBox2.Text + "%'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from arac_kiralama where kayitid like'%" + textBox3.Text + "%'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from arac_satis where kayitid like'%" + textBox4.Text + "%'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            DialogResult durum;
            try
            {
                durum = MessageBox.Show("Kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    SqlCommand sil = new SqlCommand("delete from kayit where id='" + textBox5.Text + "'", con);
                    sil.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("İŞLEM BAŞARILIDIR!");
                    textBox1.Clear();
                    griddoldur();
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("İŞLEM HATASI = " + HATA.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from kiralama_yorum where yorum like'%" + textBox7.Text + "%'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            DialogResult durum;
            try
            {
                durum = MessageBox.Show("Yorumu silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    SqlCommand sil = new SqlCommand("delete from kiralama_yorum where id='" + textBox6.Text + "'", con);
                    sil.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("İŞLEM BAŞARILIDIR!");
                    textBox6.Clear();
                    griddoldur1();
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("İŞLEM HATASI = " + HATA.Message);
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
