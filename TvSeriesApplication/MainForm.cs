using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvSeriesApplication
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent(); 

        }
        private void VisitLink()
        {
         
            linkLabel1.LinkVisited = true;
      
            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt2861424/");
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
