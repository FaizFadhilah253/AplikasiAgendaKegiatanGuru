using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_AgendaKegiatanGuru
{
    public partial class FmenuPengguna : Form
    {
        public string IDLogin;

        public FmenuPengguna()
        {
            InitializeComponent();
        }

        private void FmenuPengguna_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            FAgendaKegiatan FA = new FAgendaKegiatan() { TopLevel = false, TopMost = true };
            FA.IDLogin = this.IDLogin;
            FA.roleUser = "Pengguna";
            KF.UntukForm(FA, PNLKONTEN);

            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FLogin Fr = new FLogin();
            Fr.Show();
            this.Hide();
        }
    }
}
