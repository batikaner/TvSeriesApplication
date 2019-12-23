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
    public partial class LoginScreen : Form
    {
        


        public LoginScreen()
        {
           
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        MainForm frr = new MainForm();


        public void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBtn();
        }


        public void btnRegister_Click(object sender, EventArgs e)
        {
         
            NewUser nw = new NewUser(); 
            nw.Show();
        }
        public string loginer_username;
        public void LoginBtn()
        {
            try
            {
                MemberBL membl = new MemberBL();
                Members mb = membl.MemberLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (mb == null)
                {
                    MessageBox.Show("Access Denied ! ");
                }
                else
                {
                    MessageBox.Show("Access Successful\nUser : " + mb.member_username.ToUpper());
                    loginer_username = mb.member_username;
                    this.Hide();
                    frr.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CleanPanel();
            }
        }

        public void CleanPanel()
        {
            foreach (Control item in this.Controls["pnlTxt"].Controls)
            {
                item.Text = string.Empty;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            MemberBL sb = new MemberBL();
            cmBox.Enabled = true;
            cmBox.ValueMember = "tv_userID";
            cmBox.DisplayMember = "member_username";
            cmBox.DataSource = sb.memberList();
            cmBox.Visible = false;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions tr = new Transactions();
            tr.Show();
        }
    }
}
