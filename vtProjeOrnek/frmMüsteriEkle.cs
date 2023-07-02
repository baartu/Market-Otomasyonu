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
namespace vtProjeOrnek
{
    public partial class frmMüsteriEkle : Form
    {
        public frmMüsteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");
        bool durum;
        private void tckontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Müşteri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtTc.Text == read["tc"].ToString() || txtTc.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void frmMüsteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tckontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into müşteri(tc,adsoyad,telefon,adres,email,kasiyer_no,şifre) values(@tc,@adsoyad,@telefon,@adres,@email,@kasiyer_no,@şifre)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@kasiyer_no", txtKasiyerNo.Text);
                komut.Parameters.AddWithValue("@şifre", txtKasiyerSifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kaydı Eklendi");
            }
            else
            {
                MessageBox.Show("Boş Bıraktığınız Yerler yada Aynı TC Kullanıyorsunuz .");
            }
           
            txtTc.Text =" ";
            txtAdSoyad.Text = " ";
            txtTelefon.Text = " ";
            txtAdres.Text = " ";
            txtEmail.Text = " ";
            txtKasiyerNo.Text = " ";
            txtKasiyerSifre.Text = " ";
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
