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
    public partial class Flokasi : Form
    {
        public Flokasi()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("select * from lokasi");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_lokasi"];
                string namlok = "" + baris["nama_lokasi"];
                string gdg = "" + baris["gedung"];
                dataGridView1.Rows.Add(id, namlok, gdg);

            }
        }

        public void bersih()
        {
            label4.Text = "";
            TXTlok.Text = "";
            TXTgedung.Text = "";
        }
        private void BTNsimpan_Click(object sender, EventArgs e)
        {
            if (TXTlok.Text != "" || TXTgedung.Text != "")
            {
                string namlok = TXTlok.Text;
                string gdg = TXTgedung.Text;

                DB.crud($"INSERT INTO lokasi values(null, '{namlok}', '{gdg}')");
                tampildata();

            }
            else
            {
                MessageBox.Show("lengkapi data !");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DB.crud($"UPDATE lokasi set nama_lokasi = '{TXTlok.Text}', gedung = '{TXTgedung.Text}' where id_lokasi = '{label4.Text}' ");

            tampildata();
            bersih();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (kolom == 3)
            {

                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"Select * FROM lokasi where id_lokasi = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string id = "" + brs["id_lokasi"];
                    string namlok = "" + brs["nama_lokasi"];
                    string gdg = "" + brs["gedung"];

                    label4.Text = id;
                    TXTlok.Text = namlok;
                    TXTgedung.Text = gdg;
                }

            }

            if (kolom == 4)
            {
                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM lokasi WHERE id_lokasi = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }
    }
}
