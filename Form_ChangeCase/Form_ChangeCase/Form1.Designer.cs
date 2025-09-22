namespace Form_ChangeCase
{
    partial class Form1
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
            txtHoTen = new TextBox();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnKQ = new Button();
            txtKQ = new TextBox();
            btnStop = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(384, 98);
            txtHoTen.Margin = new Padding(4, 3, 4, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(410, 35);
            txtHoTen.TabIndex = 1;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(39, 63);
            rad1.Margin = new Padding(4, 3, 4, 3);
            rad1.Name = "rad1";
            rad1.Size = new Size(147, 31);
            rad1.TabIndex = 2;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            rad1.CheckedChanged += rad1_CheckedChanged;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(39, 126);
            rad2.Margin = new Padding(4, 3, 4, 3);
            rad2.Name = "rad2";
            rad2.Size = new Size(177, 31);
            rad2.TabIndex = 3;
            rad2.TabStop = true;
            rad2.Text = "CHỮ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            rad2.CheckedChanged += rad2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(178, 186);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(434, 186);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn kiểu chữ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(662, 200);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 172);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_click;
            // 
            // btnKQ
            // 
            btnKQ.Location = new Point(178, 429);
            btnKQ.Margin = new Padding(4, 3, 4, 3);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(161, 33);
            btnKQ.TabIndex = 6;
            btnKQ.Text = "Kết quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(384, 429);
            txtKQ.Margin = new Padding(4, 3, 4, 3);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(410, 35);
            txtKQ.TabIndex = 7;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(419, 529);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(134, 75);
            btnStop.TabIndex = 8;
            btnStop.Text = "Dừng";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 655);
            Controls.Add(btnStop);
            Controls.Add(txtKQ);
            Controls.Add(btnKQ);
            Controls.Add(btnXoa);
            Controls.Add(groupBox1);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Đổi kiểu chữ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private RadioButton rad1;
        private RadioButton rad2;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnKQ;
        private TextBox txtKQ;
        private Button btnStop;
    }
}
