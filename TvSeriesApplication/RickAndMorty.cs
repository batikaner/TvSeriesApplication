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

namespace TvSeriesApplication
{
    public partial class RickAndMorty : Form
    {
        public RickAndMorty()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void showSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Geri Dön?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                MainForm mf = new MainForm();
                mf.Show();
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

     
    }
}
