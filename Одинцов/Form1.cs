using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Одинцов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string conString = Properties.Settings.Default.EtoBazaConnectionString;

        private void btnOK_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand query = new SqlCommand($@"Select *
from Users
where [login] = '{tbxLogin.Text}' and pass = '{tbxPass.Text}'", con);
            SqlDataReader res = query.ExecuteReader();
            if (res.Read())
            {
                FormAvtoriza frm = new FormAvtoriza();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Неправильный логин/пароль");
            con.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            FormRegistr frm = new FormRegistr();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.usersTableAdapter.Fill(this.etoBazaDataSet.Users);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'etoBazaDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.etoBazaDataSet.Users);
        }
    }
}

