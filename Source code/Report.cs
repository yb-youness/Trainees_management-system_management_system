using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_stagiaire_colaimo
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        
        private void Report_Load(object sender, EventArgs e)
        {
            

            if (Program.a.rap == 1)
            {
                CrystalReport1 CB = new CrystalReport1();

                crystalReportViewer1.ReportSource = CB;
                crystalReportViewer1.Refresh();
                

            }
            if (Program.a.rap == 2)
            {
                CRCRCRC cc = new CRCRCRC();

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.Refresh();

                crystalReportViewer1.ReportSource = cc;
                crystalReportViewer1.Refresh();

            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            badge mm = new badge();
            mm.Show();
           
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            badge mm = new badge();
            mm.Show();
        }

        private void zoneStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajoute at = new Ajoute();
            at.Show();
        }

        private void zoneServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SERVICE at = new SERVICE();
            at.Show();
        }

        private void zoneSpecialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            specialite at = new specialite();
            at.Show();
        }

        private void badgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            badge bd = new badge();
            bd.Show();
        }

        private void attestationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            attestation at = new attestation();
            at.Show();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profil at = new profil();
            at.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
