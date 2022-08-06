using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMovil
{
    public partial class frmSchollar : Form
    {
        public frmSchollar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInicio xd = new frmInicio();
            xd.Show();
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function on process");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function on process");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function on process");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function on process");
        }
    }
}
