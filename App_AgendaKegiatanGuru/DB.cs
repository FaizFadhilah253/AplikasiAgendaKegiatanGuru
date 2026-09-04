using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace App_AgendaKegiatanGuru
{
    class DB
    {
        public static MySqlConnection koneksi = new MySqlConnection
            ("server = 127.0.0.1; username = root; password = ; database = db_agenda");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;



        public static void crud(string querry)
        {
            Console.WriteLine(querry);
            ds.Tables.Clear();
            perintah = new MySqlCommand(querry, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
    }
}

