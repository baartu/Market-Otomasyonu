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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vtProjeOrnek
{
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Ürün", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString() || txtBarkodNo.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void kategori_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategori_getir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='"+comboKategori.SelectedItem+"' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Ürün(barkodno,kategori,marka,ürünadı,miktarı,alışfiyatı,satışfiyatı,tarih,yerli_ithal,kdv,kdvli_fiyat,kar_oranı) values(@barkodno,@kategori,@marka,@ürünadı,@miktarı,@alışfiyatı,@satışfiyatı,@tarih,@yerli_ithal,@kdv,@kdvli_fiyat,@kar_oranı)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@ürünadı", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktarı", int.Parse(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@alışfiyatı", double.Parse(txtAlışFiyatı.Text));
                komut.Parameters.AddWithValue("@satışfiyatı", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@yerli_ithal", comboYerliİthal.Text);
                komut.Parameters.AddWithValue("@kdv", textKDV.Text);
                komut.Parameters.AddWithValue("@kdvli_fiyat", double.Parse(txtKDVliSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@kar_oranı", txtKarOranı.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Aynı BarkodNo Kullanıyorsunuz veya Boş Bırakılan Yerler Var.");
            }
            
            txtBarkodNo.Text = "";
            comboKategori.Text = "";
            comboMarka.Text = "";
            txtÜrünAdı.Text = "";
            txtMiktarı.Text = "";
            txtAlışFiyatı.Text = "";
            txtSatışFiyatı.Text = "";
            comboYerliİthal.Text = "";
            textKDV.Text ="";
            txtKDVliSatışFiyatı.Text = "";
            txtKarOranı.Text = "25";
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text=="")
            {
                lblMiktarı.Text = "";
                Kategoritxt.Text = "";
                Markatxt.Text = "";
                ÜrünAdıtxt.Text = "";
                MiktarıTxt.Text = "";
                AlışFiyatıtxt.Text = "";
                SatışFiyatıtxt.Text = "";
                Yerli_İthalCombo.Text = "";
                KDVTxt.Text = "";
                KDVliFiyatTxt.Text = "";
                KarOranıTxt.Text = "";
                
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from Ürün where barkodno like '"+BarkodNotxt.Text+"'", baglanti);
       SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                ÜrünAdıtxt.Text = read["ürünadı"].ToString();
                lblMiktarı.Text = read["miktarı"].ToString();
                AlışFiyatıtxt.Text = read["alışfiyatı"].ToString();
                SatışFiyatıtxt.Text = read["satışfiyatı"].ToString();
                Yerli_İthalCombo.Text = read["yerli_ithal"].ToString();
                KDVTxt.Text = read["kdv"].ToString();
                KDVliFiyatTxt.Text = read["kdvli_fiyat"].ToString();
                KarOranıTxt.Text = read["kar_oranı"].ToString();
            }
            baglanti.Close ();
        }

        private void btnVarOlan_Click(object sender, EventArgs e)
        {
            baglanti.Open ();
            SqlCommand komut = new SqlCommand("update Ürün set miktarı=miktarı+'"+int.Parse(MiktarıTxt.Text)+"' where barkodno='"+BarkodNotxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            BarkodNotxt.Text = "";
            Kategoritxt.Text = "";
            Markatxt.Text = "";
            ÜrünAdıtxt.Text = "";
            MiktarıTxt.Text = "";
            AlışFiyatıtxt.Text = "";
            SatışFiyatıtxt.Text = "";
            Yerli_İthalCombo.Text = "";
            KDVTxt.Text = "";
            KDVliFiyatTxt.Text = "";
            KarOranıTxt.Text = "";
            
            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ürün set miktarı=miktarı-'" + int.Parse(MiktarıTxt.Text) + "' where barkodno='" + BarkodNotxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            BarkodNotxt.Text = "";
            Kategoritxt.Text = "";
            Markatxt.Text = "";
            ÜrünAdıtxt.Text = "";
            MiktarıTxt.Text = "";
            AlışFiyatıtxt.Text = "";
            SatışFiyatıtxt.Text = ""; 
            Yerli_İthalCombo.Text = "";
            KDVTxt.Text = "";
            KDVliFiyatTxt.Text = "";
            KarOranıTxt.Text = "";
            MessageBox.Show("Var Olan Üründen Azaltma Yapıldı.");
        }

        private void txtAlışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSatışFiyatı.Text = ((((((double.Parse(textKDV.Text) * double.Parse(txtAlışFiyatı.Text)) / 100) + double.Parse(txtAlışFiyatı.Text)) * double.Parse(txtKarOranı.Text)) / 100) + double.Parse(txtAlışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void textKDV_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                txtSatışFiyatı.Text = ((((((double.Parse(textKDV.Text) * double.Parse(txtAlışFiyatı.Text)) / 100) + double.Parse(txtAlışFiyatı.Text))*double.Parse(txtKarOranı.Text))/100)+double.Parse(txtAlışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
            try
            {
                txtKDVliSatışFiyatı.Text = (((double.Parse(textKDV.Text) * double.Parse(txtAlışFiyatı.Text)) / 100) + double.Parse(txtAlışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }

        }

        private void txtKDVliSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtKDVliSatışFiyatı.Text = (((double.Parse(textKDV.Text) * double.Parse(txtAlışFiyatı.Text)) / 100) + double.Parse(txtAlışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
            try
            {
                txtSatışFiyatı.Text = ((((((double.Parse(textKDV.Text) * double.Parse(txtAlışFiyatı.Text)) / 100) + double.Parse(txtAlışFiyatı.Text)) * double.Parse(txtKarOranı.Text)) / 100) + double.Parse(txtKDVliSatışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }

        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSatışFiyatı.Text = ((((((double.Parse(textKDV.Text) * double.Parse(txtAlışFiyatı.Text)) / 100) + double.Parse(txtAlışFiyatı.Text)) * double.Parse(txtKarOranı.Text)) / 100) + double.Parse(txtKDVliSatışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtKarOranı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSatışFiyatı.Text = ((((((double.Parse(textKDV.Text) * double.Parse(txtAlışFiyatı.Text)) / 100) + double.Parse(txtKDVliSatışFiyatı.Text)) * double.Parse(txtKarOranı.Text)) / 100) + double.Parse(txtKDVliSatışFiyatı.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Ürün where yerli_ithal='" + comboYerliİthal.SelectedItem + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboYerliİthal.Items.Add(read["yerli_ithal"].ToString());
            }
            baglanti.Close();
            comboYerliİthal.Text = "";
        }
    }
}
