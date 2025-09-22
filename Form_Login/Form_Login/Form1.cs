namespace Form_Login
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkNho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtPass.Text;
            if (this.chkNho.Checked == true)
            { thongbao += "\n\rBạn ghi nhớ mật khẩu."; }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.txtUser.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
