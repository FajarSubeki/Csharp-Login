using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginDatabase
{
    public partial class F_Register : Form
    {
        public F_Register()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void daftar_Click(String username, String password)
        {
            string host = "localhost";
            string pass = "";
            string user = "root";
            string db = "db_user";
            string con = "server= " + host + ";database=" + db + ";user=" + user + ";password=" + pass + ";";

            username = username.ToUpper();
            password = password.ToUpper();

            MySqlConnection koneksi = new MySqlConnection(con);

            koneksi.Open();
        }
    }
}
