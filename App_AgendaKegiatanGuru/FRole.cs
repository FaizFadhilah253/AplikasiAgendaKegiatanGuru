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
    public partial class FRole : Form
    {
        public FRole()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("select * from role");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["ID"];
                string role = "" + baris["Nama_role"];
                dataGridView1.Rows.Add(id, role);
            }
        }

        public void bersih()
        {
            label4.Text = "";
            TXTrole.Text = "";
        }

        private void BTNsimpan_Click(object sender, EventArgs e)
        {
            DB.crud($"INSERT INTO role values(null, '{TXTrole.Text}')");
            tampildata();
            bersih();
        }

        private void CMBrole_DropDown(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string id = dataGridView1.Rows[baris].Cells[0].Value.ToString();
            if (kolom == 2)
            {
                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"Select * FROM role where ID = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string idr = "" + brs["ID"];
                    string nama = "" + brs["Nama_role"];
                    label4.Text = idr;
                    TXTrole.Text = nama;
                }
            }

                if (kolom == 3)
                {
                    string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                    DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (setuju == DialogResult.Yes)
                    {
                        DB.crud($"DELETE FROM role WHERE ID = '{idbar}' ");
                    }

                    tampildata();
                    bersih();
                }
            }
        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DB.crud($"UPDATE role set Nama_role = '{TXTrole.Text}' where ID = '{label4.Text}' ");

            tampildata();
            bersih();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMBrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


