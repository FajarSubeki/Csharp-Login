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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login(text_user.Text, text_pass.Text) == true)
            {
                MessageBox.Show("SELAMAT DATANG !!! Silahkan Masuk", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username dan Password tidak cocok");
            }
        }

        private Boolean Login(String username, String password)
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
            MySqlCommand dbcmd = koneksi.CreateCommand();
            string sql = "SELECT username, password from tb_login";
            dbcmd.CommandText = sql;
            MySqlDataReader reader = dbcmd.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString().ToUpper() == username) && (reader.GetString(1).ToString().ToUpper() == password))
                {
                    return true;
                }
            }
            koneksi.Close();
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_pass.Text = "";
            text_user.Text = "";
            text_user.Focus();
        }
    }
}
