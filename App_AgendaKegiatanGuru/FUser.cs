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
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("select * from user");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id = "" + baris["ID"];
                string nm = "" + baris["Nama_Lengkap"];
                string user = "" + baris["username"];
                string pass = "" + baris["password"];
                string role = "" + baris["role"];
                dataGridView1.Rows.Add(id, nm, user, pass, role);
            }
        }

        public void bersih()
        {
            ID.Text = "";
            TXTnama.Text = "";
            TXTuser.Text = "";
            TXTpass.Text = "";
            CMBrole.Text = "";
        }

        private void TXTnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (kolom == 5)
            {

                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"Select * FROM user where ID = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string idr = "" + brs["ID"];
                    string nama = "" + brs["Nama_Lengkap"];
                    string user = "" + brs["Username"];
                    string pass = "" + brs["Password"];
                    string role = "" + brs["Role"];
                    ID.Text = idr;
                    TXTnama.Text = nama;
                    TXTuser.Text = user;
                    TXTpass.Text = pass;
                    CMBrole.Text = role;
                }

            }

            if (kolom == 6)
            {
                string idbar = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM user WHERE ID = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }

        private void BTNsimpan_Click(object sender, EventArgs e)
        {
            if (TXTuser.Text != "" || TXTnama.Text != "" || TXTpass.Text != "" || CMBrole.Text != "")
            {
                string nm = TXTnama.Text;
                string user = TXTuser.Text;
                string pass = TXTpass.Text;
                string role = CMBrole.Text;

                DB.crud($"INSERT INTO user values(null, '{nm}', '{user}', '{pass}', '{role}')");
                tampildata();

            }
            else
            {
                MessageBox.Show("lengkapi data !");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DB.crud($"UPDATE user set Nama_Lengkap = '{TXTnama.Text}', username = '{TXTuser.Text}', password = '{TXTpass.Text}', role = '{CMBrole.Text}' where id = '{ID.Text}' ");

            tampildata();
            bersih();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void CMBrole_DropDown(object sender, EventArgs e)
        {
            CMBrole.Items.Clear();
            CMBrole.Items.Add("Admin");
            CMBrole.Items.Add("Petugas");
            CMBrole.Items.Add("Pengguna");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CMBrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
