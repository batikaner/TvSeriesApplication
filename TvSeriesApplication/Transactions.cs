using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        public void resimbul(int iid)
        {
            MemberBL mbl = new MemberBL();
            Members mem = new Members();
            mem = mbl.ImageTest(iid);
            if (mem != null)
            {
                cmText.Text = mem.member_passwd.ToString();
                this.pictureBox1.ImageLocation = mem.member_image;
                this.pictureBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Üzgünüm");
            }

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
            
            using (tvSeriesDBEntities ctx = new tvSeriesDBEntities())
            {
                try
                {
                    int y;
                    y = (int)BoxBox.SelectedValue;
                    tbl_userlogin s = ctx.tbl_userlogin.Find(y);
                    s.tv_userpass = cmText.Text.Trim();
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            using (tvSeriesDBEntities ctx=new tvSeriesDBEntities())
            {
                try 
                {   
                    int x;  // not so clean 
                    x = (int)BoxBox.SelectedValue;

                    if (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tbl_userlogin lgn = ctx.tbl_userlogin.Find(x);
                        lgn.tv_userpass = cmText.Text.Trim();
                        
                        ctx.SaveChanges();
                        this.Hide();
                        LoginScreen loginScreen = new LoginScreen();
                        loginScreen.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error ! ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public string imagePath;
        public void btnImage_Click(object sender, EventArgs e)
        { 
       
            
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Choose an Image";
            fd.Filter = "JPEG (*.jpg)|*.jpg|Png (*.png)|*.png";
            if (fd.ShowDialog()==DialogResult.OK)
            {
                string pathhh = fd.FileName;
            //    MessageBox.Show(pathhh);

                //pictureBox1.Image = Image.FromFile(fd.FileName);
                //imagePath = fd.FileName.ToString();
                ////its OK

                //FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Write);
                //BinaryReader br = new BinaryReader(fs);
                //byte[] img = br.ReadBytes((int)fs.Length);
                //br.Close();
                //fs.Close();

                using (tvSeriesDBEntities tx = new tvSeriesDBEntities())
                {
                    int x;
                    x = (int)BoxBox.SelectedValue;
                    
                    tbl_userlogin tbl = tx.tbl_userlogin.Find(x);
                    tbl.tv_userpass = cmText.Text.Trim();
                    tbl.tv_image = pathhh;
                    tx.SaveChanges();

                    //var query = "update tbl_userlogin SET tv_image=img where boxbox=selected";
                    //tx.Database.ExecuteSqlCommand(query  or "query");
                }

            }
        }

        private void btnResimGöster_Click(object sender, EventArgs e)
        {
            resimbul((int)BoxBox.SelectedValue);
        }
    }
}
