namespace GUI
{
    partial class frmBaoCaoThongKe
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
            this.btnThucHien = new System.Windows.Forms.Button();
            this.cboLuaChon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDiem = new System.Windows.Forms.GroupBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKyHoc = new System.Windows.Forms.ComboBox();
            this.grbHocBa = new System.Windows.Forms.GroupBox();
            this.cboHocSinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.grbDiem.SuspendLayout();
            this.grbHocBa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThucHien
            // 
            this.btnThucHien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnThucHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHien.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnThucHien.Location = new System.Drawing.Point(426, 583);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(154, 42);
            this.btnThucHien.TabIndex = 35;
            this.btnThucHien.Text = "Lấy báo cáo thống kê";
            this.btnThucHien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThucHien.UseVisualStyleBackColor = false;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // cboLuaChon
            // 
            this.cboLuaChon.ForeColor = System.Drawing.Color.Black;
            this.cboLuaChon.FormattingEnabled = true;
            this.cboLuaChon.Items.AddRange(new object[] {
            "Lịch sử hoạt động trên hệ thống của giáo viên",
            "Thống kê học bạ",
            "Thống kê điểm",
            "Thống kê vi phạm"});
            this.cboLuaChon.Location = new System.Drawing.Point(455, 66);
            this.cboLuaChon.Margin = new System.Windows.Forms.Padding(2);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Size = new System.Drawing.Size(396, 21);
            this.cboLuaChon.TabIndex = 36;
            this.cboLuaChon.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(196, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "Chọn loại báo cáo thống kê:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "BÁO CÁO THỐNG KÊ HỆ THỐNG";
            // 
            // grbDiem
            // 
            this.grbDiem.Controls.Add(this.cboNamHoc);
            this.grbDiem.Controls.Add(this.label5);
            this.grbDiem.Controls.Add(this.label4);
            this.grbDiem.Controls.Add(this.cboKyHoc);
            this.grbDiem.Enabled = false;
            this.grbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.grbDiem.ForeColor = System.Drawing.Color.Firebrick;
            this.grbDiem.Location = new System.Drawing.Point(48, 129);
            this.grbDiem.Margin = new System.Windows.Forms.Padding(2);
            this.grbDiem.Name = "grbDiem";
            this.grbDiem.Padding = new System.Windows.Forms.Padding(2);
            this.grbDiem.Size = new System.Drawing.Size(382, 329);
            this.grbDiem.TabIndex = 41;
            this.grbDiem.TabStop = false;
            this.grbDiem.Text = "Thống kê điểm:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(137, 183);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(173, 28);
            this.cboNamHoc.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(46, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Năm học: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(46, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Kỳ học: ";
            // 
            // cboKyHoc
            // 
            this.cboKyHoc.FormattingEnabled = true;
            this.cboKyHoc.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboKyHoc.Location = new System.Drawing.Point(137, 113);
            this.cboKyHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboKyHoc.Name = "cboKyHoc";
            this.cboKyHoc.Size = new System.Drawing.Size(173, 28);
            this.cboKyHoc.TabIndex = 41;
            // 
            // grbHocBa
            // 
            this.grbHocBa.Controls.Add(this.cboHocSinh);
            this.grbHocBa.Controls.Add(this.label7);
            this.grbHocBa.Controls.Add(this.label9);
            this.grbHocBa.Controls.Add(this.cboNienKhoa);
            this.grbHocBa.Controls.Add(this.label11);
            this.grbHocBa.Controls.Add(this.cboLop);
            this.grbHocBa.Enabled = false;
            this.grbHocBa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.grbHocBa.ForeColor = System.Drawing.Color.Firebrick;
            this.grbHocBa.Location = new System.Drawing.Point(557, 129);
            this.grbHocBa.Margin = new System.Windows.Forms.Padding(2);
            this.grbHocBa.Name = "grbHocBa";
            this.grbHocBa.Padding = new System.Windows.Forms.Padding(2);
            this.grbHocBa.Size = new System.Drawing.Size(382, 329);
            this.grbHocBa.TabIndex = 46;
            this.grbHocBa.TabStop = false;
            this.grbHocBa.Text = "Thống kê học bạ:";
            // 
            // cboHocSinh
            // 
            this.cboHocSinh.FormattingEnabled = true;
            this.cboHocSinh.Location = new System.Drawing.Point(127, 211);
            this.cboHocSinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboHocSinh.Name = "cboHocSinh";
            this.cboHocSinh.Size = new System.Drawing.Size(246, 28);
            this.cboHocSinh.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(19, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Học sinh: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(19, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "Niên khoá:";
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Location = new System.Drawing.Point(127, 37);
            this.cboNienKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(173, 28);
            this.cboNienKhoa.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(19, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 40;
            this.label11.Text = "Lớp: ";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(127, 119);
            this.cboLop.Margin = new System.Windows.Forms.Padding(2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(173, 28);
            this.cboLop.TabIndex = 39;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1010, 644);
            this.Controls.Add(this.grbHocBa);
            this.Controls.Add(this.grbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboLuaChon);
            this.Controls.Add(this.btnThucHien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);
            this.grbDiem.ResumeLayout(false);
            this.grbDiem.PerformLayout();
            this.grbHocBa.ResumeLayout(false);
            this.grbHocBa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.ComboBox cboLuaChon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDiem;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKyHoc;
        private System.Windows.Forms.GroupBox grbHocBa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboHocSinh;
        private System.Windows.Forms.Label label7;
    }
}