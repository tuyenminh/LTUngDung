namespace QuanlidiemTHPT
{
    partial class fMonHoc
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
            this.components = new System.ComponentModel.Container();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.textMH_Ma = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textMH_Ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();
            this.MH_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttokList = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // textMH_Ma
            // 
            this.textMH_Ma.Location = new System.Drawing.Point(210, 107);
            this.textMH_Ma.Name = "textMH_Ma";
            this.textMH_Ma.Size = new System.Drawing.Size(237, 20);
            this.textMH_Ma.TabIndex = 0;
            this.textMH_Ma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textMH_Ten
            // 
            this.textMH_Ten.Location = new System.Drawing.Point(210, 148);
            this.textMH_Ten.Name = "textMH_Ten";
            this.textMH_Ten.Size = new System.Drawing.Size(237, 20);
            this.textMH_Ten.TabIndex = 3;
            this.textMH_Ten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã môn học:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên môn học:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MH_Ma,
            this.MH_Ten});
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(465, 76);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(243, 177);
            this.dataGridViewMonHoc.TabIndex = 6;
            this.dataGridViewMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonHoc_CellClick);
            // 
            // MH_Ma
            // 
            this.MH_Ma.DataPropertyName = "MH_Ma";
            this.MH_Ma.HeaderText = "Mã Môn Học";
            this.MH_Ma.Name = "MH_Ma";
            // 
            // MH_Ten
            // 
            this.MH_Ten.DataPropertyName = "MH_Ten";
            this.MH_Ten.HeaderText = "Tên Môn Học";
            this.MH_Ten.Name = "MH_Ten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(483, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "DANH SÁCH MÔN HỌC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thông tin chi tiết";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(213, 219);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 9;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(294, 219);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttokList
            // 
            this.buttokList.Location = new System.Drawing.Point(375, 219);
            this.buttokList.Name = "buttokList";
            this.buttokList.Size = new System.Drawing.Size(75, 23);
            this.buttokList.TabIndex = 9;
            this.buttokList.Text = "Tìm kiếm";
            this.buttokList.UseVisualStyleBackColor = true;
            this.buttokList.Click += new System.EventHandler(this.buttokList_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonThem.ImageKey = "(none)";
            this.buttonThem.Location = new System.Drawing.Point(142, 219);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonThem.Size = new System.Drawing.Size(65, 23);
            this.buttonThem.TabIndex = 9;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // fMonHoc
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMH_Ten);
            this.Controls.Add(this.textMH_Ma);
            this.Name = "fMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.fMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox textMH_Ma;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textMH_Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttokList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH_Ten;
    }
}