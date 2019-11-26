using DAL;
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
using TvSeries.BLL;
using TvSeries.MODEL;

namespace TvSeriesApplication
{
    public partial class Form1 : Form
    {

        
        SqlConnection cn=null;
       
        public Form1()
        {
            InitializeComponent();
        }
        public void MainMethod()
        {
            DataAccess dataAcc = new DataAccess();
            SqlDataReader dr;
           
            //SQL Connection 
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

            
            SqlCommand cm = new SqlCommand();
            dataAcc.ConnAc();
            cn.Open();
            cm.Connection = cn;
            cm.CommandText = ("SELECT * FROM tbl_userlogin where tv_username='" + txtUsername.Text.Trim() + "' AND tv_userpass='" + txtPassword.Text.Trim());
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Succsesful");
            }
            else
            {
                MessageBox.Show("Accses Denied!");
            }
            dataAcc.ConnKapat();
            
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            MainMethod();
            //MemberBL mbl = new MemberBL();
            //Members user = new Members();


            //user.member_username = txtUsername.Text.Trim();
            //user.member_passwd = txtPassword.Text.Trim();


            //mbl.veriTabaniBakA(user.member_username,user.member_passwd);



            //SqlDataReader dr;
            //string userrrr = txtUsername.Text;
            //string password = txtPassword.Text;

            //cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);


            //SqlCommand cm = new SqlCommand();
            //cn.Open();
            //cm.Connection = cn;
            //cm.CommandText = ("SELECT * FROM tbl_userlogin where tv_username='" + txtUsername.Text + "' AND tv_userpass='" + txtPassword.Text);
            //dr = cm.ExecuteReader();
            //if (dr.Read())
            //{
            //    MessageBox.Show("Login Succsesful");
            //}
            //else
            //{
            //    MessageBox.Show("Accses Denied!");
            //}
            //cn.Close();
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
