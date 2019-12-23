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

        private void button2_Click(object sender, EventArgs e)
        {
            RickAndMorty rm = new RickAndMorty();
            this.Close();
            rm.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SerieBL sb = new SerieBL();
            cmbSeries.ValueMember = "serie_id";
            cmbSeries.DisplayMember = "serie_name";
            cmbSeries.DataSource = sb.FindSerie();


            using (tvSeriesDBEntities ctx = new tvSeriesDBEntities())
            {
                tbl_userlogin tbl = ctx.tbl_userlogin.Find(1051);
                  
            }



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
            }
            else
            {
                MessageBox.Show("Yoh");
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(visit_link);
        }
        public void btnChoose_Click(object sender, EventArgs e)
        {
            FindaSerie((int)cmbSeries.SelectedValue);
        }
    }
}
