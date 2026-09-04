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
                    string roleUser = row["role"].ToString();

                    if (roleUser == "Admin")
                    {
                        FmenuAdmin Fa = new FmenuAdmin();
                        Fa.Show();
                    }
                    else
                    {
                        DataRow brs = DB.ds.Tables[0].Rows[0];
                        string id = "" + brs["ID"];

                        FmenuPetugas F1 = new FmenuPetugas();
                        F1.IDLogin = id;
                        F1.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("salah");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
