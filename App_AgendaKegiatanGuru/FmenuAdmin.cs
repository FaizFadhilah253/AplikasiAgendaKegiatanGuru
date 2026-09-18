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
    public partial class FmenuAdmin : Form
    {
        public FmenuAdmin()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FRole FP = new FRole() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FUser FP = new FUser() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (PNLDataM.Visible == false)
            {
                PNLDataM.Visible = true;
            }
            else
            {
                PNLDataM.Visible = false;
            }
        }

        private void FDashboardAdmin_Load(object sender, EventArgs e)
        {
            PNLDataM.Visible = false;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Fguru FP = new Fguru() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Fkategori FP = new Fkategori() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Flokasi FP = new Flokasi() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FLogin Fr = new FLogin();
            Fr.Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            FAgendaKegiatan FP = new FAgendaKegiatan() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DashboardAdmin FP = new DashboardAdmin() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            DashboardAdmin FP = new DashboardAdmin() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            FLaporan FP = new FLaporan() { TopLevel = false, TopMost = true };
            KF.UntukForm(FP, PNLKONTEN);
        }
    }
}
