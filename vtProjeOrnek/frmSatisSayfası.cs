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
    public partial class frmSatisSayfası : Form
    {
        public frmSatisSayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet ", baglanti);
                label10.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void frmSatisSayfası_Load(object sender, EventArgs e)
        {
            sepetlistele();
            
        }

        private void txtKasiyerNo_TextChanged(object sender, EventArgs e)
        {
                
                if (TxtKasiyerNo.Text == "")
                {
                    txtAdSoyad.Text = "";
                }
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Müşteri where kasiyer_no like '" + TxtKasiyerNo.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtAdSoyad.Text = read["adsoyad"].ToString();

                }
                baglanti.Close();
        }
        private void Temizle()
        {
            if (txtBarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Ürün where barkodno like '" + txtBarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUrunAdi.Text = read["ürünadı"].ToString();
                txtSatisFiyat.Text = read["satışfiyatı"].ToString();
            }
            baglanti.Close();
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkod.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (TxtKasiyerNo.Text == "")
            {
                MessageBox.Show("Lütfen Kasiyer Numaranızı Giriniz.");
            }
            else
            {
                if (txtBarkod.Text == "")
                {
                    MessageBox.Show("Seçili Ürün Yok .");
                }
                else
                {
                    barkodkontrol();
                    if (durum == true)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into sepet(adsoyad,telefon,barkodno,ürünadı,miktarı,satışfiyatı,toplamfiyat,tarih,kasiyer_no) values(@adsoyad,@telefon,@barkodno,@ürünadı,@miktarı,@satışfiyatı,@toplamfiyat,@tarih,@kasiyer_no)", baglanti);
                        komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@telefon", "1");
                        komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                        komut.Parameters.AddWithValue("@ürünadı", txtUrunAdi.Text);
                        komut.Parameters.AddWithValue("@miktarı", int.Parse(txtMiktari.Text));
                        komut.Parameters.AddWithValue("@satışfiyatı", double.Parse(txtSatisFiyat.Text));
                        komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txtToplamFiyat.Text));
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                        komut.Parameters.AddWithValue("@kasiyer_no", TxtKasiyerNo.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("update sepet set miktarı=miktarı+'" + int.Parse(txtMiktari.Text) + "'where barkodno='" + txtBarkod.Text + "'", baglanti);
                        komut2.ExecuteNonQuery();
                        SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyat=miktarı*satışfiyatı where barkodno='" + txtBarkod.Text + "'", baglanti);
                        komut3.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    txtMiktari.Text = "1";
                    daset.Tables["sepet"].Clear();
                    sepetlistele();
                    hesapla();
                    foreach (Control item in groupBox2.Controls)
                    {
                        if (item is TextBox)
                        {
                            if (item != txtMiktari)
                            {
                                item.Text = "";
                            }
                        }

                    }
                }
            }
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatisFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (dataGridView1.Rows[i].Selected)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Sepetten Çıkarıldı.");
                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();
            }
            else
            {
                MessageBox.Show("Silinecek Ürünü Seçmelisiniz. ");
            }
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı.");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            if (TxtKasiyerNo.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into satış(adsoyad,kasiyerno,barkodno,ürünadı,miktarı,satışfiyatı,toplamfiyat,tarih) values(@adsoyad,@kasiyerno,@barkodno,@ürünadı,@miktarı,@satışfiyatı,@toplamfiyat,@tarih)", baglanti);
                    komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@kasiyerno", TxtKasiyerNo.Text);
                    komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                    komut.Parameters.AddWithValue("@ürünadı", dataGridView1.Rows[i].Cells["ürünadı"].Value.ToString());
                    komut.Parameters.AddWithValue("@miktarı", int.Parse(dataGridView1.Rows[i].Cells["miktarı"].Value.ToString()));
                    komut.Parameters.AddWithValue("@satışfiyatı", double.Parse(dataGridView1.Rows[i].Cells["satışfiyatı"].Value.ToString()));
                    komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    SqlCommand komut2 = new SqlCommand("update Ürün set miktarı=miktarı-'" + int.Parse((dataGridView1.Rows[i].Cells["miktarı"].Value.ToString())) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                }
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();
            }
            else
            {
                MessageBox.Show("Kasiyer Numaranızı Girmeyi Unuttunuz.");
            }
        }
    }
}
