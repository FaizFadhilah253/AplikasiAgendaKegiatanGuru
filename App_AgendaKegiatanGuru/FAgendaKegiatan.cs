using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace App_AgendaKegiatanGuru
{
    public partial class FAgendaKegiatan : Form
    {
        public string IDLogin;
        public string roleUser;

        public FAgendaKegiatan()
        {
            InitializeComponent();
        }

        private const string SQL_AGENDA = "SELECT a.id_agenda, a.tanggal, a.waktu_mulai, a.waktu_selesai, a.kegiatan, g.nama_guru, k.nama_kategori, l.nama_lokasi FROM agenda a LEFT JOIN guru g ON a.id_guru = g.id_guru LEFT JOIN kategori k ON a.id_kategori = k.id_kategori LEFT JOIN lokasi l ON a.id_lokasi = l.id_lokasi ";

        private string esc(string teks)
        {
            return teks.Replace("'", "''");
        }

        private string formatTanggal(object nilai)
        {
            if (nilai == null || nilai == DBNull.Value) return "";
            return Convert.ToDateTime(nilai).ToString("dd/MM/yyyy");
        }

        private void isiGrid(string pencarian = "")
        {
            try
            {
                string query = SQL_AGENDA;

                if (roleUser == "Admin")
                {
                    if (!string.IsNullOrWhiteSpace(pencarian))
                    {
                        query += " WHERE g.nama_guru LIKE '%" +
                                 esc(pencarian) + "%'";
                    }
                }
                else if (roleUser == "Pengguna")
                {
                    query += " INNER JOIN user u ON g.nama_guru = u.Nama_Lengkap " +
                     " WHERE u.ID = '" + esc(IDLogin) + "'";

                    if (!string.IsNullOrWhiteSpace(pencarian))
                    {
                        query += " AND DATE_FORMAT(a.tanggal, '%Y-%m-%d') LIKE '%" +
                          esc(pencarian) + "%'";
                    }
                }
                else
                {
                    MessageBox.Show("Role pengguna tidak dikenali!");
                    return;
                }

                query += " ORDER BY a.id_agenda";

                dataGridView1.Rows.Clear();

                DB.crud(query);

                int no = 1;

                foreach (DataRow baris in DB.ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(
                        no++,
                        baris["id_agenda"].ToString(),
                        formatTanggal(baris["tanggal"]),
                        baris["waktu_mulai"].ToString(),
                        baris["waktu_selesai"].ToString(),
                        baris["kegiatan"].ToString(),
                        baris["nama_guru"].ToString(),
                        baris["nama_kategori"].ToString(),
                        baris["nama_lokasi"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        public void tampildata()
        {
            isiGrid("");
        }

        public void bersih()
        {
            ID.Text = "";
            TXTwaksel.Text = "";
            TXTkegiatan.Text = "";
            CMBguru.SelectedIndex = -1;
            CMBkategori.Text = "";
            CMBlokasi.Text = "";
        }

        private void BTNsimpan_Click(object sender, EventArgs e)
        {
            if (TXTwaksel.Text != "" && TXTkegiatan.Text != "" && CMBguru.Text != "" && CMBkategori.Text != "" && CMBlokasi.Text != "")
            {
                string waksel = esc(TXTwaksel.Text);
                string kgt = esc(TXTkegiatan.Text);
                string gr = esc(CMBguru.Text);
                string kate = esc(CMBkategori.Text);
                string lok = esc(CMBlokasi.Text);

                DB.crud("SELECT id_guru FROM guru WHERE nama_guru = '" + gr + "'");
                if (DB.ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Guru tidak ditemukan, pilih dari daftar!");
                    return;
                }

                DB.crud("SELECT id_kategori FROM kategori WHERE nama_kategori = '" + kate + "'");
                if (DB.ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Kategori tidak ditemukan, pilih dari daftar!");
                    return;
                }

                DB.crud("SELECT id_lokasi FROM lokasi WHERE nama_lokasi = '" + lok + "'");
                if (DB.ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Lokasi tidak ditemukan, pilih dari daftar!");
                    return;
                }

                DB.crud("INSERT INTO agenda (tanggal, waktu_mulai, waktu_selesai, kegiatan, id_guru, id_kategori, id_lokasi) VALUES (" +
                        "CURDATE(), CURTIME(), '" + waksel + "', '" + kgt + "', " +
                        "(SELECT id_guru FROM guru WHERE nama_guru = '" + gr + "' LIMIT 1), " +
                        "(SELECT id_kategori FROM kategori WHERE nama_kategori = '" + kate + "' LIMIT 1), " +
                        "(SELECT id_lokasi FROM lokasi WHERE nama_lokasi = '" + lok + "' LIMIT 1))");
                tampildata();
                bersih();
            }
            else
            {
                MessageBox.Show("lengkapi data !");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diubah terlebih dahulu!");
                return;
            }

            string waksel = esc(TXTwaksel.Text);
            string kgt = esc(TXTkegiatan.Text);
            string gr = esc(CMBguru.Text);
            string kate = esc(CMBkategori.Text);
            string lok = esc(CMBlokasi.Text);

            DB.crud("UPDATE agenda SET " +
                    "waktu_selesai = '" + waksel + "', " +
                    "kegiatan = '" + kgt + "', " +
                    "id_guru = (SELECT id_guru FROM guru WHERE nama_guru = '" + gr + "' LIMIT 1), " +
                    "id_kategori = (SELECT id_kategori FROM kategori WHERE nama_kategori = '" + kate + "' LIMIT 1), " +
                    "id_lokasi = (SELECT id_lokasi FROM lokasi WHERE nama_lokasi = '" + lok + "' LIMIT 1) " +
                    "WHERE id_agenda = '" + ID.Text + "'");

            tampildata();
            bersih();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DB.crud("SELECT Nama_Lengkap FROM user WHERE ID = '" + esc(IDLogin) + "'");
            string nama = "(tidak ditemukan)";
            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                nama = DB.ds.Tables[0].Rows[0]["Nama_Lengkap"].ToString();
            }

            DB.crud("SELECT id_guru FROM guru WHERE nama_guru = '" + esc(nama) + "'");
            int jumlahGuru = DB.ds.Tables[0].Rows.Count;

            DB.crud("SELECT a.id_agenda FROM agenda a INNER JOIN guru g ON a.id_guru = g.id_guru WHERE g.nama_guru = '" + esc(nama) + "'");
            int jumlahAgenda = DB.ds.Tables[0].Rows.Count;

            MessageBox.Show("Nama_Lengkap user: [" + nama + "]" + Environment.NewLine +
                            "Jumlah guru dengan nama itu: " + jumlahGuru + Environment.NewLine +
                            "Jumlah agenda milik guru itu: " + jumlahAgenda);

            guna2TextBox1.Clear();
            tampildata();
            bersih();
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
            if (baris < 0 || dataGridView1.Rows[baris].Cells[0].Value == null) return;

            if (kolom == 9)
            {
                string idbar = dataGridView1.Rows[baris].Cells[1].Value.ToString();
                DB.crud(SQL_AGENDA + "WHERE a.id_agenda = '" + idbar + "'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    ID.Text = "" + brs["id_agenda"];
                    TXTwaksel.Text = "" + brs["waktu_selesai"];
                    TXTkegiatan.Text = "" + brs["kegiatan"];
                    CMBguru.Text = "" + brs["nama_guru"];
                    CMBkategori.Text = "" + brs["nama_kategori"];
                    CMBlokasi.Text = "" + brs["nama_lokasi"];
                }
            }

            if (kolom == 10)
            {
                string idbar = dataGridView1.Rows[baris].Cells[1].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus? " + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud("DELETE FROM agenda WHERE id_agenda = '" + idbar + "'");
                    tampildata();
                    bersih();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXTguru_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTlokasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTkategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTkegiatan_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTwaksel_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTwakmul_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTPtanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            isiGrid(guna2TextBox1.Text);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_DropDown(object sender, EventArgs e)
        {
            DB.crud("SELECT * FROM guru");
            CMBguru.Items.Clear();
            foreach (DataRow item in DB.ds.Tables[0].Rows)
            {
                CMBguru.Items.Add(item["nama_guru"].ToString());
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMBlokasi_DropDown(object sender, EventArgs e)
        {
            DB.crud("SELECT * FROM lokasi");
            CMBlokasi.Items.Clear();
            foreach (DataRow item in DB.ds.Tables[0].Rows)
            {
                CMBlokasi.Items.Add(item["nama_lokasi"].ToString());
            }
        }

        private void CMBkategori_DropDown(object sender, EventArgs e)
        {
            DB.crud("SELECT * FROM kategori");
            CMBkategori.Items.Clear();
            foreach (DataRow item in DB.ds.Tables[0].Rows)
            {
                CMBkategori.Items.Add(item["nama_kategori"].ToString());
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load("LAPORANAGENDAKEGIATAN.rpt");

            string pdfPath = Path.Combine(Path.GetTempPath(), "Laporan_Agenda_Kegiatan.pdf");
            rpt.ExportToDisk(ExportFormatType.PortableDocFormat, pdfPath);

            System.Diagnostics.Process.Start(pdfPath);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormCobaLaporan CBL = new FormCobaLaporan();
            CBL.ShowDialog();
        }

        private void FAgendaKegiatan_Load(object sender, EventArgs e)
        {
            if (roleUser == "Pengguna")
            {
                CMBguru.Visible = false;
                guna2ShadowPanel3.Visible = false;
            }
            else if (roleUser == "Admin")
            {
                CMBguru.Visible = true;
            }

            guna2Button4.Enabled = true;
            guna2Button4.Visible = true;
            guna2Button4.BringToFront();
            guna2Button4.Click -= guna2Button4_Click;
            guna2Button4.Click += guna2Button4_Click;

            tampildata();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            DB.crud("SELECT * FROM guru");
            CMBguru.Items.Clear();
            foreach (DataRow item in DB.ds.Tables[0].Rows)
            {
                CMBguru.Items.Add(item["nama_guru"].ToString());
            }
        }
    }
}