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
    public partial class FLaporan : Form
    {
        public FLaporan()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("select * from agenda");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string ida = "" + baris["id_agenda"];
                string tgl = "" + baris["tanggal"];
                string wakmul = "" + baris["waktu_mulai"];
                string waksel = "" + baris["waktu_selesai"];
                string kgt = "" + baris["kegiatan"];
                string gr = "" + baris["guru"];
                string kate = "" + baris["kategori"];
                string lok = "" + baris["lokasi"];
                dataGridView1.Rows.Add(ida, tgl, wakmul, waksel, kgt, gr, kate, lok);

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
