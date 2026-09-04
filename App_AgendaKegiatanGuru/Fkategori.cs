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
    public partial class Fkategori : Form
    {
        public Fkategori()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("select * from kategori");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_kategori"];
                string kt = "" + baris["nama_kategori"];
                dataGridView1.Rows.Add(id, kt);
            }
        }

        public void bersih()
        {
            ID.Text = "";
            TXTkt.Text = "";
        }

        private void BTNsimpan_Click(object sender, EventArgs e)
        {
            DB.crud($"INSERT INTO kategori values(null, '{TXTkt.Text}')");
            tampildata();
            bersih();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DB.crud($"UPDATE kategori set nama_kategori = '{TXTkt.Text}' where id_kategori = '{ID.Text}' ");

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
            string id = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 2)
            {
                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"Select * FROM kategori where id_kategori = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string idk = "" + brs["id_kategori"];
                    string namak = "" + brs["nama_kategori"];
                    ID.Text = idk;
                    TXTkt.Text = namak;
                }
            }

            if (kolom == 3)
            {
                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM kategori WHERE id_kategori = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }
    }
}
