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
    public partial class FAgendaKegiatan : Form
    {
        public FAgendaKegiatan()
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

        public void bersih()
        {
            ID.Text = "";
            DTPtanggal.Text = "";
            TXTwakmul.Text = "";
            TXTwaksel.Text = "";
            TXTkegiatan.Text = "";
            TXTguru.Text = "";
            TXTkategori.Text = "";
            TXTlokasi.Text = "";
        }

        private void BTNsimpan_Click(object sender, EventArgs e)
        {
            if (DTPtanggal.Text != "" || TXTwakmul.Text != "" || TXTwaksel.Text != "" || TXTkegiatan.Text != "" || TXTguru.Text != "" || TXTkategori.Text != "" || TXTlokasi.Text != "")
            {
                string tgl = DTPtanggal.Value.ToString("yyyy-MM-dd");
                string wakmul = TXTwakmul.Text;
                string waksel = TXTwaksel.Text;
                string kgt = TXTkegiatan.Text;
                string gr = TXTguru.Text;
                string kate = TXTkategori.Text;
                string lok = TXTlokasi.Text;

                DB.crud($"INSERT INTO agenda values(null, '{tgl}', '{wakmul}', '{waksel}','{kgt}', '{gr}', '{kate}', '{lok}')");
                tampildata();

            }
            else
            {
                MessageBox.Show("lengkapi data !");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DB.crud($"UPDATE agenda set tanggal = '{DTPtanggal.Value.ToString("yyyy-MM-dd")}', waktu_mulai = '{TXTwakmul.Text}', waktu_selesai = '{TXTwaksel.Text}', kegiatan = '{TXTkegiatan.Text}', guru = '{TXTguru.Text}', kategori = '{TXTkategori.Text}', lokasi = '{TXTlokasi.Text}' where id_agenda = '{ID.Text}' ");

            tampildata();
            bersih();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (kolom == 8)
            {

                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"Select * FROM agenda where id_agenda = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string ida = "" + brs["id_agenda"];
                    string tgl = "" + brs["tanggal"];
                    string wakmul = "" + brs["waktu_mulai"];
                    string waksel = "" + brs["waktu_selesai"];
                    string kgt = "" + brs["kegiatan"];
                    string gr = "" + brs["guru"];
                    string kate = "" + brs["kategori"];
                    string lok = "" + brs["lokasi"];
                    ID.Text = ida;
                    DTPtanggal.Text = tgl.ToString();
                    TXTwakmul.Text = wakmul;
                    TXTwaksel.Text = waksel;
                    TXTkegiatan.Text = kgt;
                    TXTguru.Text = gr;
                    TXTkategori.Text = kate;
                    TXTlokasi.Text = lok;
                }

            }

            if (kolom == 9)
            {
                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM agenda WHERE id_agenda = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }
    }
}
