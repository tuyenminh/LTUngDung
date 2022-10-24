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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKhoi_Ten = new System.Windows.Forms.TextBox();
            this.textKhoi_Ma = new System.Windows.Forms.TextBox();
            this.Khoi_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // buttokList
            // 
            this.buttokList.Location = new System.Drawing.Point(363, 246);
            this.buttokList.Name = "buttokList";
            this.buttokList.Size = new System.Drawing.Size(75, 23);
            this.buttokList.TabIndex = 28;
            this.buttokList.Text = "Tìm kiếm";
            this.buttokList.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(282, 246);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 29;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(201, 246);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 30;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonThem.ImageKey = "(none)";
            this.buttonThem.Location = new System.Drawing.Point(130, 246);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonThem.Size = new System.Drawing.Size(65, 23);
            this.buttonThem.TabIndex = 31;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thông tin chi tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(496, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
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
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(453, 103);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(243, 177);
            this.dataGridViewMonHoc.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Khối:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Khối:";
            // 
            // textKhoi_Ten
            // 
            this.textKhoi_Ten.Location = new System.Drawing.Point(174, 179);
            this.textKhoi_Ten.Name = "textKhoi_Ten";
            this.textKhoi_Ten.Size = new System.Drawing.Size(237, 20);
            this.textKhoi_Ten.TabIndex = 22;
            // 
            // textKhoi_Ma
            // 
            this.textKhoi_Ma.Location = new System.Drawing.Point(174, 138);
            this.textKhoi_Ma.Name = "textKhoi_Ma";
            this.textKhoi_Ma.Size = new System.Drawing.Size(237, 20);
            this.textKhoi_Ma.TabIndex = 21;
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
            // fKhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "fKhoi";
            this.Text = "Quản lý Khối Học";
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