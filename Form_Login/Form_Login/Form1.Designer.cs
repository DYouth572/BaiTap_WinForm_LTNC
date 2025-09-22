namespace Form_Login
{
    partial class FrmBai1_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            chkNho = new CheckBox();
            btnLogin = new Button();
            btnDelete = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(374, 108);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(208, 37);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(374, 190);
            txtPass.Margin = new Padding(4, 3, 4, 3);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(208, 37);
            txtPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 29);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(158, 264);
            chkNho.Margin = new Padding(4, 3, 4, 3);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(122, 33);
            chkNho.TabIndex = 4;
            chkNho.Text = "Ghi nhớ\r\n";
            chkNho.UseVisualStyleBackColor = true;
            chkNho.CheckedChanged += chkNho_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(157, 347);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(372, 347);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(585, 347);
            btnStop.Margin = new Padding(4, 3, 4, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(157, 39);
            btnStop.TabIndex = 8;
            btnStop.Text = "Dừng";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // FrmBai1_1
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(917, 471);
            Controls.Add(btnStop);
            Controls.Add(btnDelete);
            Controls.Add(btnLogin);
            Controls.Add(chkNho);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBai1_1";
            Text = "Form Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label2;
        private CheckBox chkNho;
        private Button btnLogin;
        private Button btnDelete;
        private Button btnStop;
    }
}
