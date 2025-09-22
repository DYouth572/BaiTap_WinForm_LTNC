namespace Form_ChangeCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKQ_click(object sender, EventArgs e)
        {
            string hoten = this.txtHoTen.Text.Trim();
            if (this.rad1.Checked == true)
                txtKQ.Text = hoten.ToLower();
            if (this.rad2.Checked == true)
                txtKQ.Text = hoten.ToUpper();
        }

        private void btnXoa_click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.rad1.Checked = true;
            this.txtHoTen.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
