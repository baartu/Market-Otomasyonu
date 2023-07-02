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
    public partial class frmKasiyerGiris8 : Form
    {
        public frmKasiyerGiris8()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=vtProject;Integrated Security=True");
        private void btnGirişYap_Click(object sender, EventArgs e)
        {
           
            if (txtKasiyerNo.Text == "" || txtSifre.Text=="")
            {
                MessageBox.Show("Boş Bırakılan Yerleri doldurun.");
            }
            else if (true)
            {
                frmSatisSayfası ekle = new frmSatisSayfası();
                Visible = false;
                ekle.ShowDialog();
                this.Show();
            }
            txtKasiyerNo.Text = "";
            txtSifre.Text = "";
        }
        
        private void txtKasiyerNo_TextChanged(object sender, EventArgs e)
        {
            
            if (txtKasiyerNo.Text == "" || txtSifre.Text=="")
            {
                txtAdSoyad.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Müşteri where kasiyer_no like '" + txtKasiyerNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtSifre.Text = read["şifre"].ToString();
            }
            baglanti.Close();
        }
    }
}
