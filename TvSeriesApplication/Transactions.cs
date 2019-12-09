using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvSeries.BLL;
using TvSeries.MODEL;

namespace TvSeriesApplication
{
    public partial class Transactions : Form
    {
        public int ogrenciid = 0;
       
        public Transactions()
        {
            InitializeComponent();

        }


        MemberBL sb = new MemberBL();
        public void Transactions_Load(object sender, EventArgs e)
        {

            BoxBox.Enabled = true;
            BoxBox.ValueMember = "tv_userID";
            BoxBox.DisplayMember = "member_username";
            BoxBox.DataSource = sb.memberList();
            
        }
        public void Delete()
        {
            try
            {

                MemberBL mbl = new MemberBL();
                Members mem = new Members();
                mem.tv_userID = (int)BoxBox.SelectedValue;

                DialogResult cvp = MessageBox.Show("Emin Miyiz?", "Silme Onayı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.No)
                {
                    return;
                }

                if (mbl.MemberDelete((int)BoxBox.SelectedValue))
                {
                    MessageBox.Show("Silindi");
                }
                else
                {
                    MessageBox.Show("Silinmedi");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmText.Text = BoxBox.Text;
            Delete();
        }







        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemberBL mbl = new MemberBL();
            Members mb = new Members();
            mb.member_username = cmText.Text.Trim();
            mb.member_passwd = mb.member_passwd;
            mbl.MemberUpdate(mb);


        }
    }
}
