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
    public partial class frmÜrünListeleme : Form
    {
        public frmÜrünListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");
        DataSet daset = new DataSet() ;
        private void kategori_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünListeleme_Load(object sender, EventArgs e)
        {
            ürünListele();
            kategori_getir();
        }

        private void ürünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Ürün", baglanti);
            adtr.Fill(daset, "Ürün");
            dataGridView1.DataSource = daset.Tables["Ürün"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["ürünadı"].Value.ToString();
            MiktarıTxt.Text = dataGridView1.CurrentRow.Cells["miktarı"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alışfiyatı"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satışfiyatı"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ürün set ürünadı=@ürünadı,miktarı=@miktarı,alışfiyatı=@alışfiyatı,satışfiyatı=@satışfiyatı where barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@barkodno",BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@ürünadı", ÜrünAdıtxt.Text);
            komut.Parameters.AddWithValue("@miktarı", int.Parse(MiktarıTxt.Text));
            komut.Parameters.AddWithValue("@alışfiyatı",double.Parse (AlışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("@satışfiyatı", double.Parse(SatışFiyatıtxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Ürün"].Clear();
            ürünListele();
            MessageBox.Show("Güncelleme Tamamlandı.");
            BarkodNotxt.Text = "";
            ÜrünAdıtxt.Text = "";
            MiktarıTxt.Text = "";
            AlışFiyatıtxt.Text = "";
            SatışFiyatıtxt.Text = "";
        }

        private void btnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Ürün set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@marka", comboBox2.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Tamamlandı.");
                daset.Tables["Ürün"].Clear();
                ürünListele();
            }
            else
            {
                MessageBox.Show("BarkodNo Seçili Değil.");
            }
            BarkodNotxt.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboBox1.SelectedItem + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ürün where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Ürün"].Clear();
            ürünListele();
            MessageBox.Show("Kayıt Silindi");
            BarkodNotxt.Text = "";
            ÜrünAdıtxt.Text = "";
            MiktarıTxt.Text = "";
            AlışFiyatıtxt.Text = "";
            SatışFiyatıtxt.Text = "";
            Kategoritxt.Text = "";
            Markatxt.Text = "";
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Ürün where barkodno like'%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
