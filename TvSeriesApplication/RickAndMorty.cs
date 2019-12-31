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
    public partial class RickAndMorty : Form
    {
            int deneme;
       
        public RickAndMorty()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
           
           //  deneme = (int)MainForm.cmbSeries.SelectedValue;
        }

        private MainForm MainForm;
        public RickAndMorty(MainForm MainForm)
        {
            this.MainForm = MainForm;

        }

        public void testest()
        {
            using (tvSeriesDBEntities ctx=new tvSeriesDBEntities())
            {
                tbl_Series s = ctx.tbl_Series.Find(deneme);
                s.serie_name = label1.Text;
            }
        }

        private void showSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Geri Dön?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                MainForm mf = new MainForm();
            }
            else
            {
                return;
            }
        }

        private void ItemSource_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Database Görüntülensin Mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MemberBL bl = new MemberBL();
                dataGridView1.Visible = true;
                dataGridView1.DataSource = bl.MemberList();
            }
            else
            {
                return;
            }
        }

        private void RickAndMorty_Load(object sender, EventArgs e)
        {


        }
    }
}
