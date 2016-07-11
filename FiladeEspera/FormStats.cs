using System;
using System.Windows.Forms;

namespace FiladeEspera
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClientDAL.GetAllClient();
        }
    }
}
