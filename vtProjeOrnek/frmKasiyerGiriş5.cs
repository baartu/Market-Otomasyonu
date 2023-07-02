using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtProjeOrnek
{
    public partial class frmKasiyerGiriş5 : Form
    {
        public frmKasiyerGiriş5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");
        bool durum;

        private void tckontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kasiyergiriş", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtKullanıcıAdı.Text == read["kullanıcıadı"].ToString() || txtKullanıcıAdı.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private string adminKullanıcıAdı = "bartu";
        private string adminŞifre = "123";
        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            string kullanıcıadı = txtKullanıcıAdı.Text;
            string şifre = txtŞifre.Text;
            if (txtKullanıcıAdı.Text == "" || txtŞifre.Text == "")
            {
                MessageBox.Show("Boş Bırakılan Yerleri doldurun.");
            }
            else if (kullanıcıadı == adminKullanıcıAdı && şifre == adminŞifre)
            {
                frmSatışlarıListeleme ekle = new frmSatışlarıListeleme();
                Visible = false;
                ekle.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Geçersiz !!!");
            }
            txtKullanıcıAdı.Text = "";
            txtŞifre.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtŞifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtŞifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }
    }
}
