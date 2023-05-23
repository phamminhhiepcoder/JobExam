namespace GUI
{
    partial class frmPhanLopSV
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
            this.dgvThongTinLopTheoKiNam = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboHocKi = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPhanLop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboKiFilter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboNamFilter = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHocSinhChuaPhanLop = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.btnDanhSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinLopTheoKiNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhChuaPhanLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinLopTheoKiNam
            // 
            this.dgvThongTinLopTheoKiNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinLopTheoKiNam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.dgvThongTinLopTheoKiNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinLopTheoKiNam.GridColor = System.Drawing.SystemColors.Control;
            this.dgvThongTinLopTheoKiNam.Location = new System.Drawing.Point(793, 396);
            this.dgvThongTinLopTheoKiNam.Name = "dgvThongTinLopTheoKiNam";
            this.dgvThongTinLopTheoKiNam.Size = new System.Drawing.Size(618, 394);
            this.dgvThongTinLopTheoKiNam.TabIndex = 1;
            this.dgvThongTinLopTheoKiNam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinLopTheoKiNam_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1149, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filter: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(334, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tên sinh viên: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(334, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã sinh viên: ";
            // 
            // txtTenHS
            // 
            this.txtTenHS.Enabled = false;
            this.txtTenHS.Location = new System.Drawing.Point(497, 154);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(283, 20);
            this.txtTenHS.TabIndex = 43;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Enabled = false;
            this.txtMaHS.Location = new System.Drawing.Point(497, 82);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(155, 20);
            this.txtMaHS.TabIndex = 42;
            // 
            // cboLop
            // 
            this.cboLop.Enabled = false;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(955, 200);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(283, 21);
            this.cboLop.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(829, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(823, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Năm học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(823, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Học kì:";
            // 
            // cboHocKi
            // 
            this.cboHocKi.FormattingEnabled = true;
            this.cboHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboHocKi.Location = new System.Drawing.Point(955, 125);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(92, 21);
            this.cboHocKi.TabIndex = 56;
            this.cboHocKi.SelectedValueChanged += new System.EventHandler(this.cboHocKi_SelectedValueChanged);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnReset.Location = new System.Drawing.Point(833, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 42);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btnPhanLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanLop.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btnPhanLop.Location = new System.Drawing.Point(548, 269);
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.Size = new System.Drawing.Size(154, 42);
            this.btnPhanLop.TabIndex = 60;
            this.btnPhanLop.Text = "Phân lớp";
            this.btnPhanLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhanLop.UseVisualStyleBackColor = false;
            this.btnPhanLop.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(789, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "Các lớp trong hệ thống:";
            // 
            // cboKiFilter
            // 
            this.cboKiFilter.FormattingEnabled = true;
            this.cboKiFilter.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboKiFilter.Location = new System.Drawing.Point(1201, 345);
            this.cboKiFilter.Name = "cboKiFilter";
            this.cboKiFilter.Size = new System.Drawing.Size(92, 21);
            this.cboKiFilter.TabIndex = 65;
            this.cboKiFilter.SelectedValueChanged += new System.EventHandler(this.cboKiFilter_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1054, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Năm học:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1054, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Học kì:";
            // 
            // cboNamFilter
            // 
            this.cboNamFilter.FormattingEnabled = true;
            this.cboNamFilter.Location = new System.Drawing.Point(1201, 282);
            this.cboNamFilter.Name = "cboNamFilter";
            this.cboNamFilter.Size = new System.Drawing.Size(213, 21);
            this.cboNamFilter.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "Chưa phân lớp:";
            // 
            // dgvHocSinhChuaPhanLop
            // 
            this.dgvHocSinhChuaPhanLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinhChuaPhanLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.dgvHocSinhChuaPhanLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinhChuaPhanLop.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHocSinhChuaPhanLop.Location = new System.Drawing.Point(29, 396);
            this.dgvHocSinhChuaPhanLop.Name = "dgvHocSinhChuaPhanLop";
            this.dgvHocSinhChuaPhanLop.Size = new System.Drawing.Size(714, 394);
            this.dgvHocSinhChuaPhanLop.TabIndex = 68;
            this.dgvHocSinhChuaPhanLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinhChuaPhanLop_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(619, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 25);
            this.label12.TabIndex = 69;
            this.label12.Text = "PHÂN LỚP SINH VIÊN";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(955, 51);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(213, 21);
            this.cboNamHoc.TabIndex = 70;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSach.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnDanhSach.Location = new System.Drawing.Point(55, 98);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(186, 62);
            this.btnDanhSach.TabIndex = 71;
            this.btnDanhSach.Text = "Danh sách sinh viên hiện tại đã được phân lớp ";
            this.btnDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // frmPhanLopSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1423, 802);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvHocSinhChuaPhanLop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboNamFilter);
            this.Controls.Add(this.cboKiFilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPhanLop);
            this.Controls.Add(this.cboHocKi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongTinLopTheoKiNam);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmPhanLopSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanLopHS";
            this.Load += new System.EventHandler(this.frmPhanLopHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinLopTheoKiNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhChuaPhanLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinLopTheoKiNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboHocKi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPhanLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboKiFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboNamFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvHocSinhChuaPhanLop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Button btnDanhSach;
    }
}