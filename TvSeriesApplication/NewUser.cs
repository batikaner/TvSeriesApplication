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
    public partial class NewUser : Form
    {
        private LoginScreen form1;


        public NewUser(LoginScreen form1)
        {
            this.form1 = form1;          
            InitializeComponent();
        }
        public NewUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }        
        public void NewRegister(string usernam)
        {
            try
            {
                Members mb = new Members();
                MemberBL mbld = new MemberBL();

                mb.member_username = txtNewUser.Text.Trim();
                mb.member_passwd = txtNewUserPass.Text.Trim();
                string imgPatg = "C:\\Users\\Batı\\Desktop\\root@kali.7z\\Dersler\\fcs6\\pewds.gif  ";
                mb.member_image = imgPatg;

                if (MessageBox.Show("Do you want to register?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtNewUser.Text = txtNewUser.Text.ToLower();
                    if (txtNewUserPass.Text.Trim() == txtNewUserPass2.Text.Trim())
                    {
                        MessageBox.Show(mbld.AddaMember(mb) ? "Request Approved" : "Request Denied!");

                    }
                    else
                    {
                        MessageBox.Show("Password Does Not Match");
                    }
                }
                else
                {
                    MessageBox.Show("Password Does Not Match");
                }
            }
            catch (Exception)
            {                
                throw;
            }
            finally
            {
                txtNewUser.Clear();
                txtNewUserPass.Clear();
                txtNewUserPass2.Clear();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            NewRegister(txtNewUser.Text.Trim());
        }
    }
    }
