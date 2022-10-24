namespace QuanlidiemTHPT
{
    partial class fDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.textBox_tentaikhoan = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.linkLabel_dangky = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_tentaikhoan
            // 
            this.textBox_tentaikhoan.Location = new System.Drawing.Point(103, 220);
            this.textBox_tentaikhoan.Multiline = true;
            this.textBox_tentaikhoan.Name = "textBox_tentaikhoan";
            this.textBox_tentaikhoan.Size = new System.Drawing.Size(208, 35);
            this.textBox_tentaikhoan.TabIndex = 2;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Location = new System.Drawing.Point(103, 278);
            this.textBox_matkhau.Multiline = true;
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.PasswordChar = '*';
            this.textBox_matkhau.Size = new System.Drawing.Size(208, 35);
            this.textBox_matkhau.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // linkLabel_quenmatkhau
            // 
            this.linkLabel_quenmatkhau.AutoSize = true;
            this.linkLabel_quenmatkhau.Font = new System.Drawing.Font("Malgun Gothic Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_quenmatkhau.Location = new System.Drawing.Point(63, 332);
            this.linkLabel_quenmatkhau.Name = "linkLabel_quenmatkhau";
            this.linkLabel_quenmatkhau.Size = new System.Drawing.Size(116, 19);
            this.linkLabel_quenmatkhau.TabIndex = 6;
            this.linkLabel_quenmatkhau.TabStop = true;
            this.linkLabel_quenmatkhau.Text = "Quên mật khẩu ?";
            this.linkLabel_quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quenmatkhau_LinkClicked);
            // 
            // linkLabel_dangky
            // 
            this.linkLabel_dangky.AutoSize = true;
            this.linkLabel_dangky.Font = new System.Drawing.Font("Malgun Gothic Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_dangky.Location = new System.Drawing.Point(241, 332);
            this.linkLabel_dangky.Name = "linkLabel_dangky";
            this.linkLabel_dangky.Size = new System.Drawing.Size(61, 19);
            this.linkLabel_dangky.TabIndex = 7;
            this.linkLabel_dangky.TabStop = true;
            this.linkLabel_dangky.Text = "Đăng ký";
            this.linkLabel_dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dangky_LinkClicked);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(132, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanlidiemTHPT.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(67, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanlidiemTHPT.Properties.Resources.individual;
            this.pictureBox2.Location = new System.Drawing.Point(67, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanlidiemTHPT.Properties.Resources.anh_gif_1_min;
            this.pictureBox1.Location = new System.Drawing.Point(67, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel_dangky);
            this.Controls.Add(this.linkLabel_quenmatkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox_tentaikhoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_tentaikhoan;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_quenmatkhau;
        private System.Windows.Forms.LinkLabel linkLabel_dangky;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

