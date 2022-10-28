namespace QuanlidiemTHPT
{
    partial class fKhoi
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
            this.buttokList = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();
            this.Khoi_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKhoi_Ten = new System.Windows.Forms.TextBox();
            this.textKhoi_Ma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // buttokList
            // 
            this.buttokList.Location = new System.Drawing.Point(484, 303);
            this.buttokList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttokList.Name = "buttokList";
            this.buttokList.Size = new System.Drawing.Size(100, 28);
            this.buttokList.TabIndex = 28;
            this.buttokList.Text = "Tìm kiếm";
            this.buttokList.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(376, 303);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(100, 28);
            this.buttonXoa.TabIndex = 29;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(268, 303);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(100, 28);
            this.buttonSua.TabIndex = 30;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonThem.ImageKey = "(none)";
            this.buttonThem.Location = new System.Drawing.Point(173, 303);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonThem.Size = new System.Drawing.Size(87, 28);
            this.buttonThem.TabIndex = 31;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thông tin chi tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(661, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "DANH SÁCH KHỐI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Khoi_Ma,
            this.Khoi_Ten});
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(604, 127);
            this.dataGridViewMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(324, 218);
            this.dataGridViewMonHoc.TabIndex = 25;
            // 
            // Khoi_Ma
            // 
            this.Khoi_Ma.DataPropertyName = "Khoi_Ma";
            this.Khoi_Ma.HeaderText = "Mã Khối";
            this.Khoi_Ma.Name = "Khoi_Ma";
            // 
            // Khoi_Ten
            // 
            this.Khoi_Ten.DataPropertyName = "Khoi_Ten";
            this.Khoi_Ten.HeaderText = "Tên khối";
            this.Khoi_Ten.Name = "Khoi_Ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Khối:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Khối:";
            // 
            // textKhoi_Ten
            // 
            this.textKhoi_Ten.Location = new System.Drawing.Point(232, 220);
            this.textKhoi_Ten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textKhoi_Ten.Name = "textKhoi_Ten";
            this.textKhoi_Ten.Size = new System.Drawing.Size(315, 22);
            this.textKhoi_Ten.TabIndex = 22;
            // 
            // textKhoi_Ma
            // 
            this.textKhoi_Ma.Location = new System.Drawing.Point(232, 170);
            this.textKhoi_Ma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textKhoi_Ma.Name = "textKhoi_Ma";
            this.textKhoi_Ma.Size = new System.Drawing.Size(315, 22);
            this.textKhoi_Ma.TabIndex = 21;
            // 
            // fKhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttokList);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKhoi_Ten);
            this.Controls.Add(this.textKhoi_Ma);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fKhoi";
            this.Text = "Quản lý Khối Học";
            this.Load += new System.EventHandler(this.fKhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttokList;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKhoi_Ten;
        private System.Windows.Forms.TextBox textKhoi_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi_Ten;
    }
}