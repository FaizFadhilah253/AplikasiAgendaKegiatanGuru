using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_AgendaKegiatanGuru
{
    class KF
    {
        public static void UntukForm(Form FormApa, Panel PanelApa)
        {
            PanelApa.Controls.Clear();
            PanelApa.Controls.Add(FormApa);
            FormApa.TopLevel = false;
            FormApa.TopMost = true;
            FormApa.FormBorderStyle = FormBorderStyle.None;
            FormApa.Dock = DockStyle.Fill;
            FormApa.Show();
        }
    }
}
