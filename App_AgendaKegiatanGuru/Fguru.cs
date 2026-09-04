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
    public partial class Fguru : Form
    {
        public Fguru()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("select * from guru");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_guru"];
                string nip = "" + baris["nip"];
                string nmgr = "" + baris["nama_guru"];
                string jk = "" + baris["jenis_kelamin"];
                string notelp = "" + baris["no_telepon"];
                dataGridView1.Rows.Add(id, nip, nmgr, jk, notelp);

            }
        }

        public void bersih()
        {
            ID.Text = "";
            TXTnip.Text = "";
            TXTguru.Text = "";
            CMBjk.Text = "";
            TXTnotelp.Text = "";
        }

        private void BTNsimpan_Click(object sender, EventArgs e)
        {
            if (TXTnip.Text != "" || TXTguru.Text != "" || CMBjk.Text != "" || TXTnotelp.Text != "")
            {
                string nip = TXTnip.Text;
                string nmgr = TXTguru.Text;
                string jk = CMBjk.Text;
                string notelp = TXTnotelp.Text;

                DB.crud($"INSERT INTO guru values(null, '{nip}', '{nmgr}', '{jk}', '{notelp}')");
                tampildata();

            }
            else
            {
                MessageBox.Show("lengkapi data !");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DB.crud($"UPDATE guru set nip = '{TXTnip.Text}', nama_guru = '{TXTguru.Text}', jenis_kelamin = '{CMBjk.Text}', no_telepon = '{TXTnotelp.Text}' where id_guru = '{ID.Text}' ");

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
            if (kolom == 5)
            {

                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"Select * FROM guru where id_guru = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string id = "" + brs["id_guru"];
                    string nip = "" + brs["nip"];
                    string nmgr = "" + brs["nama_guru"];
                    string jk = "" + brs["jenis_kelamin"];
                    string notelp = "" + brs["no_telepon"]; ;

                    ID.Text = id ;
                    TXTnip.Text = nip;
                    TXTguru.Text = nmgr;
                    CMBjk.Text = jk;
                    TXTnotelp.Text = notelp;
                }

            }

            if (kolom == 6)
            {
                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM guru WHERE id_guru = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }

        private void CMBstatus_DropDown(object sender, EventArgs e)
        {
           
        }

        private void CMBjk_DropDown(object sender, EventArgs e)
        {
            CMBjk.Items.Clear();
            CMBjk.Items.Add("Laki-laki");
            CMBjk.Items.Add("Perempuan");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTnotelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTguru_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTnip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CMBjk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}



