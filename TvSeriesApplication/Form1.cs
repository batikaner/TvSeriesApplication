using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvSeriesApplication
{
    public partial class Form1 : Form
    {
        SqlConnection cn = null;
        public Form1()
        {
            InitializeComponent();
        }
        public void MainMethod()
        {
            SqlDataReader dr;
            string user = txtUsername.Text;
            string password = txtPassword.Text;
            //SQL Connection 
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            SqlCommand cm = new SqlCommand();
            cn.Open();
            cm.Connection = cn;
            cm.CommandText = "SELECT * FROM tbl_userlogin where tv_username='" + txtUsername.Text + "' AND tv_userpass='" + txtPassword.Text + "'";
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Succsesful");
            }
            else
            {
                MessageBox.Show("Accses Denied!");
            }

            cn.Close();
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainMethod();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            NewUser nw = new NewUser();
            nw.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
