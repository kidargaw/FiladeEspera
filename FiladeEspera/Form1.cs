using System;
using System.Windows.Forms;

namespace FiladeEspera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonOperator_Click(object sender, EventArgs e)
        {
            FormOperator frmOp = new FormOperator();
            frmOp.MdiParent = this;
            frmOp.Show();
        }

        private void toolStripButtonClients_Click(object sender, EventArgs e)
        {

            FormClient frmCli = new FormClient();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void toolStripButtonDisplay_Click(object sender, EventArgs e)
        {
            Display frmDisp = new Display();
            frmDisp.MdiParent = this;
            frmDisp.Show();
        }

        private void toolStripButtonStats_Click(object sender, EventArgs e)
        {
            FormStats frms = new FormStats();
            frms.MdiParent = this;
            frms.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emanuel Mateus - Akuetu@gmail.com");
        }
    }
}
