using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtProjeOrnek
{
    public partial class frmAdminKasiyerGiris : Form
    {
        public frmAdminKasiyerGiris()
        {
            InitializeComponent();
        }

        private void btnKasiyerGiris_Click(object sender, EventArgs e)
        {
            frmKasiyerGiris8 ekle = new frmKasiyerGiris8();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }

        private void btnAdminGiriş_Click(object sender, EventArgs e)
        {
            frmKasiyerGiris9 ekle = new frmKasiyerGiris9();
            Visible = false;
            ekle.ShowDialog();
            this.Show();
        }
    }
}
