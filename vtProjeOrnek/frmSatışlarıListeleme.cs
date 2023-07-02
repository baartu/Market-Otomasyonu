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
    public partial class frmSatışlarıListeleme : Form
    {
        public frmSatışlarıListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satış", baglanti);
            adtr.Fill(daset, "satış");
            dataGridView1.DataSource = daset.Tables["satış"];
            baglanti.Close();
        }
        private void frmSatışlarıListeleme_Load(object sender, EventArgs e)
        {
            satışlistele();
        }

        private void txtKasiyerNo_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satış where kasiyerno like'%" + txtKasiyerNo.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnSatışlarıTemizle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from satış ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satışlar Temizlendi.");
            daset.Tables["satış"].Clear();
        }
    }
}
