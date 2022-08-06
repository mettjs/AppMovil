namespace AppMovil
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmSchollar xd = new frmSchollar();
            xd.Show();
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmSchollar xd = new frmSchollar();
            xd.Show();
            this.Close();
        }
    }
}