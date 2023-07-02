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
using System.Data.SqlClient;

namespace vtProjeOrnek
{
    public partial class frmMüsteriListele : Form
    {
        public frmMüsteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");
        DataSet daset=new DataSet();
        private void frmMüsteriListele_Load(object sender, EventArgs e)
        {
            kayit_goster();
        }

        private void kayit_goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from müşteri", baglanti);
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            txtKasiyerNo.Text = dataGridView1.CurrentRow.Cells["kasiyer_no"].Value.ToString();
            txtKasiyerSifre.Text = dataGridView1.CurrentRow.Cells["şifre"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email,kasiyer_no=@kasiyer_no,şifre=@şifre where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@kasiyer_no", txtKasiyerNo.Text);
            komut.Parameters.AddWithValue("@şifre", txtKasiyerSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            kayit_goster();
            MessageBox.Show("Müşteri Kaydı Güncellendi");
            txtTc.Text = " ";
            txtAdSoyad.Text = " ";
            txtTelefon.Text = " ";
            txtAdres.Text = " ";
            txtEmail.Text = " ";
            txtKasiyerNo.Text = " ";
            txtKasiyerSifre.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='"+dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            kayit_goster();
            MessageBox.Show("Kayıt Silindi");
            txtTc.Text = " ";
            txtAdSoyad.Text = " ";
            txtTelefon.Text = " ";
            txtAdres.Text = " ";
            txtEmail.Text = " ";
            txtKasiyerNo.Text= " ";
            txtKasiyerSifre.Text= " ";
        }

        private void txtTCara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo= new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri where tc like'%"+txtTCara.Text +"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
