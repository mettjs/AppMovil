using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AppMovil
{
    public partial class frmPresentacion : Form
    {
        public frmPresentacion()
        {
            InitializeComponent();
        }

        private void frmPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Hide();
            frmInicio x = new frmInicio();
            x.Show();
        }

    }
}
