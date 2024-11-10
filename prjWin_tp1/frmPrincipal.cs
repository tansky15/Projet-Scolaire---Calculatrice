using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWin_tp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStandard_2 fs2 = new frmStandard_2();
            fs2.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void versionStandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStandard_2 fs2 = new frmStandard_2();
            fs2.Show();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScientific fsc = new frmScientific();
            fsc.MdiParent = this;
            fsc.Show();
        }

        private void versionScientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScientific fsc = new frmScientific();
            fsc.MdiParent = this;
            fsc.Show();
        }

        private void quitterProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titre = "Fermeture de l'Application";
            string msg = "Etes vous sure de vouloir quitter le programme ?";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void toolbarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mnuToolbar.Checked == false)
            {
                toolBar.Visible = false;

            }
            else
            {
                toolBar.Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmStandard_2 fs2 = new frmStandard_2();
            fs2.Show();
        }

        private void toolScientific_Click(object sender, EventArgs e)
        {
            frmScientific fsc = new frmScientific();
            fsc.MdiParent = this;
            fsc.Show();
        }

        private void mnuToolbar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void mnuStatusBar_Click(object sender, EventArgs e)
        {
            if (mnuStatusBar.Checked == true)
            {
                toolStatus.Visible = true;
            }
            else
            {
                toolStatus.Visible = false;
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout apropos = new frmAbout();
            apropos.Show();
        }

        private void manuelDutilisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserMan fum = new frmUserMan();
            fum.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
