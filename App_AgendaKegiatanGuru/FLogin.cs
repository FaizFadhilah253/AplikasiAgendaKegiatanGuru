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

    public partial class FLogin : Form
    {
        public string IDLogin;
        public FLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            {
                DB.crud($"SELECT * FROM user WHERE Username = '{txtnama.Text}' AND Password = '{txtpass.Text}'");

                int baris = DB.ds.Tables[0].Rows.Count;

                if (baris == 1)
                {
                    DataRow row = DB.ds.Tables[0].Rows[0];

                    string id = row["ID"].ToString();
                    string role = row["role"].ToString();

                    if (role == "Admin")
                    {
                        FmenuAdmin Fa = new FmenuAdmin();
                        Fa.IDLogin = id;
                        Fa.Show();
                    }
                    else if (role == "Pengguna")
                    {
                        FmenuPengguna Fa = new FmenuPengguna();
                        Fa.IDLogin = id;
                        Fa.Show();
                    }

                    this.Hide();
                }
            }

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
