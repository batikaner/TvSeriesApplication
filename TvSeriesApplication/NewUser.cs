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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        int Exchange = 0;
        SqlConnection sqlcn = null;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to register?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNewUser.Text = txtNewUser.Text.ToLower();
                SqlCommand sqlcm = null;
                if (txtNewUserPass.Text.Trim() == txtNewUserPass2.Text.Trim())
                {

                    sqlcn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
                    sqlcm = new SqlCommand($"Insert into tbl_userlogin values('{txtNewUser.Text.Trim()}','{txtNewUserPass.Text.Trim()}','{""}')", sqlcn);
                    sqlcn.Open();
                    
                    sqlcm.ExecuteNonQuery();
                    Exchange = sqlcm.ExecuteNonQuery();
                    if (Exchange>0)
                    {
                        MessageBox.Show("Approved !");
                    }
                    sqlcn.Close();
                }

                else { MessageBox.Show("Şifreler Uyuşmuyor"); }
            }
        }
    }
}
