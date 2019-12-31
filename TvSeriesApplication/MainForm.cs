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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)   //catch me if u can 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string deger { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SerieBL sb = new SerieBL();
            cmbSeries.ValueMember = "serie_id";
            cmbSeries.DisplayMember = "serie_name";
            cmbSeries.DataSource = sb.FindSerie();

            label1.Text ="User :"+ LoginScreen.tester;
            label1.Visible = true;


            //using (tvSeriesDBEntities ctx = new tvSeriesDBEntities())
            //{
            //    tbl_userlogin tbl = ctx.tbl_userlogin.Find(1051);
            //}
        }
        string visit_link = "";

        public void FindaSerie(int iid)
        {

            SerieBL sbl = new SerieBL();
            Serie serie = new Serie();
            serie = sbl.tv_SerieFinder(iid);
            if (serie != null)
            {
                txtDegistir.Text = serie.serie_name;
                lblRating.Text = "Rating :" + serie.serie_rating;
                linkLabel1.Text = serie.serie_name;
                visit_link = serie.serie_link;
                this.pictureBox2.ImageLocation = serie.serie_image;
                this.pictureBox2.Visible = true;
            }
            else
            {
                MessageBox.Show("Dizi Bulunamadı");
            }
        }


        public void CommentArea(int id)
        {
            Comment comment = new Comment();
            SerieBL sbl = new SerieBL();
            comment = sbl.tv_Comment(id);
            if (comment !=null)
            {
                //txtArea.Text = "User ID : "+comment.user_id.ToString()+"\n";
    
              //  txtArea.Text = $"User ID :{comment.user_id}\t "+comment.comment.ToString();
                label1.Text = "User ID : "+comment.user_id;
            }
            else
            {
                MessageBox.Show("Yorum Bulunamadı");
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(visit_link);
        }

        CheckBox checkBox = null;
        public void btnChoose_Click(object sender, EventArgs e)
        {
             
            FindaSerie((int)cmbSeries.SelectedValue);

            using (tvSeriesDBEntities ctx =new tvSeriesDBEntities())
            {
                tbl_Series s = ctx.tbl_Series.Find((int)cmbSeries.SelectedValue);
                int episode_number;
                episode_number = (int)s.serie_episode;
               // MessageBox.Show(episode_number.ToString());
                if (Convert.ToInt32(episode_number).ToString() !=null)
                {
                    for (int i = 1; i <= episode_number; i++)
                    {
                        checkBox = new CheckBox();
                        checkBox.Text = i.ToString() + ". Episode";
                        checkBox.Name = "cb" + i.ToString();
                        flowLayoutPanel1.Controls.Add(checkBox);
                    }
                }
                else
                {
                    MessageBox.Show("Dizinin Bölümü bulunamadı");
                }

                CommentArea((int)cmbSeries.SelectedValue);
                //SerieBL sbl = new SerieBL();
                //Comment comment = new Comment();
                //comment=sbl.tv_Comment((int)cmbSeries.SelectedValue);
                //txtArea.Text = comment.comment.ToString();
                SerieBL sbl = new SerieBL();
                List<Comment> lst = sbl.GetComments((int)cmbSeries.SelectedValue);
                for (int i = 0; i < lst.Count; i++)
                {
                    lvComment.Items.Add(lst[i].serie_id);
                    lvComment.Items[i].SubItems.Add(lst[i].user_id.ToString());
                    lvComment.Items[i].SubItems.Add(lst[i].UserName.ToString());
                    lvComment.Items[i].SubItems.Add(lst[i].comment.ToString());
                }


            }

            //using (tvSeriesDBEntities ctx= new tvSeriesDBEntities())
            //{
                
            //    string yorum;
            //    tbl_SerieComment tx = ctx.tbl_SerieComment.Find((int)cmbSeries.SelectedValue);
            //    yorum = tx.comment;
            //    yorum = txtArea.Text.Trim();
            //}

            //RickAndMorty rickAndMorty = new RickAndMorty();
            //rickAndMorty.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            txtDegistir.Text = "";
            cmbSeries.SelectedValue = 0;
            lblRating.Text = "";
            linkLabel1.Text = "";

            //SerieBL sbl = new SerieBL();
            //List<Comment> lst = sbl.GetComments((int)cmbSeries.SelectedValue);
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    lvComment.Items.Add(lst[i].serie_id);
            //    lvComment.Items[i].SubItems.Add(lst[i].user_id.ToString());
            //    lvComment.Items[i].SubItems.Add(lst[i].UserName.ToString());
            //    lvComment.Items[i].SubItems.Add(lst[i].comment.ToString());
            //}

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (tvSeriesDBEntities ctx = new tvSeriesDBEntities())
            {
        
            }
        }
    }
}
