using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtProjeOrnek
{
    public partial class formSatis : Form
    {
        public formSatis()
        {
            InitializeComponent();

        }
        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş ekle =new frmKasiyerGiriş();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMüşteriListeleme_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş2 ekle = new frmKasiyerGiriş2();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }

        private void btnÜrünEkleme_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş3 ekle = new frmKasiyerGiriş3();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }

        private void btnÜrünListeleme_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş4 ekle = new frmKasiyerGiriş4();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }

        private void btnSatışlarıListeleme_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş5 ekle = new frmKasiyerGiriş5();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }
        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş7 ekle = new frmKasiyerGiriş7();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }
        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş6 ekle = new frmKasiyerGiriş6();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }
       
        private void btnAdminKaydı_Click(object sender, EventArgs e)
        {
            frmKasiyerGiriş ekle = new frmKasiyerGiriş();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }

        private void btnSatisSayfası_Click(object sender, EventArgs e)
        {
            frmAdminKasiyerGiris ekle = new frmAdminKasiyerGiris();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }
    }
}
