namespace GUI
{
    partial class frmQuanLyDiemSo
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
            this.dgvThongTinDiemSo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.txtDiemMieng = new System.Windows.Forms.TextBox();
            this.cboMonFilter = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiem15Phut = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiem45Phut = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiemGiuaKi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiemCuoiKi = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDiemTongKet = new System.Windows.Forms.TextBox();
            this.cboTenSVFilter = new System.Windows.Forms.ComboBox();
            this.cboMaSVFilter = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboLopFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLayDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDiemSo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinDiemSo
            // 
            this.dgvThongTinDiemSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinDiemSo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.dgvThongTinDiemSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDiemSo.Location = new System.Drawing.Point(12, 521);
            this.dgvThongTinDiemSo.Name = "dgvThongTinDiemSo";
            this.dgvThongTinDiemSo.Size = new System.Drawing.Size(1449, 314);
            this.dgvThongTinDiemSo.TabIndex = 0;
            this.dgvThongTinDiemSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinDiemSo_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1204, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1127, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(641, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "QUẢN LÝ ĐIỂM SỐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã sinh viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(488, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên môn: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(806, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Điểm miệng: ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(158, 44);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(94, 20);
            this.txtMaSV.TabIndex = 10;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaHS_TextChanged);
            // 
            // cboTenMon
            // 
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Location = new System.Drawing.Point(583, 112);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(152, 21);
            this.cboTenMon.TabIndex = 12;
            // 
            // txtDiemMieng
            // 
            this.txtDiemMieng.Location = new System.Drawing.Point(936, 47);
            this.txtDiemMieng.Name = "txtDiemMieng";
            this.txtDiemMieng.Size = new System.Drawing.Size(100, 20);
            this.txtDiemMieng.TabIndex = 16;
            // 
            // cboMonFilter
            // 
            this.cboMonFilter.Enabled = false;
            this.cboMonFilter.FormattingEnabled = true;
            this.cboMonFilter.Location = new System.Drawing.Point(1199, 455);
            this.cboMonFilter.Name = "cboMonFilter";
            this.cboMonFilter.Size = new System.Drawing.Size(155, 21);
            this.cboMonFilter.TabIndex = 18;
            this.cboMonFilter.SelectedValueChanged += new System.EventHandler(this.cboMonFilter_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(34, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tên sinh viên:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Enabled = false;
            this.txtTenSV.Location = new System.Drawing.Point(158, 112);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(257, 20);
            this.txtTenSV.TabIndex = 27;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnReset.Location = new System.Drawing.Point(772, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 42);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnSua.Location = new System.Drawing.Point(303, 333);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 42);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnXoa.Location = new System.Drawing.Point(539, 336);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 42);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(42, 333);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 42);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiem15Phut
            // 
            this.txtDiem15Phut.Location = new System.Drawing.Point(936, 111);
            this.txtDiem15Phut.Name = "txtDiem15Phut";
            this.txtDiem15Phut.Size = new System.Drawing.Size(100, 20);
            this.txtDiem15Phut.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(806, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Điểm 15 phút: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(806, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 16);
            this.label16.TabIndex = 39;
            this.label16.Text = "Điểm 45 phút: ";
            // 
            // txtDiem45Phut
            // 
            this.txtDiem45Phut.Location = new System.Drawing.Point(936, 162);
            this.txtDiem45Phut.Name = "txtDiem45Phut";
            this.txtDiem45Phut.Size = new System.Drawing.Size(100, 20);
            this.txtDiem45Phut.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(806, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "Điểm giữa kì: ";
            // 
            // txtDiemGiuaKi
            // 
            this.txtDiemGiuaKi.Location = new System.Drawing.Point(936, 224);
            this.txtDiemGiuaKi.Name = "txtDiemGiuaKi";
            this.txtDiemGiuaKi.Size = new System.Drawing.Size(100, 20);
            this.txtDiemGiuaKi.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(806, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "Điểm cuối kì: ";
            // 
            // txtDiemCuoiKi
            // 
            this.txtDiemCuoiKi.Location = new System.Drawing.Point(936, 284);
            this.txtDiemCuoiKi.Name = "txtDiemCuoiKi";
            this.txtDiemCuoiKi.Size = new System.Drawing.Size(100, 20);
            this.txtDiemCuoiKi.TabIndex = 42;
            // 
            // btnTinh
            // 
            this.btnTinh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnTinh.Location = new System.Drawing.Point(1096, 68);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(119, 42);
            this.btnTinh.TabIndex = 44;
            this.btnTinh.Text = "Tính";
            this.btnTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1136, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 16);
            this.label19.TabIndex = 46;
            this.label19.Text = "Điểm tổng kết: ";
            // 
            // txtDiemTongKet
            // 
            this.txtDiemTongKet.Location = new System.Drawing.Point(1268, 157);
            this.txtDiemTongKet.Name = "txtDiemTongKet";
            this.txtDiemTongKet.Size = new System.Drawing.Size(100, 20);
            this.txtDiemTongKet.TabIndex = 45;
            // 
            // cboTenSVFilter
            // 
            this.cboTenSVFilter.Enabled = false;
            this.cboTenSVFilter.FormattingEnabled = true;
            this.cboTenSVFilter.Location = new System.Drawing.Point(1051, 392);
            this.cboTenSVFilter.Name = "cboTenSVFilter";
            this.cboTenSVFilter.Size = new System.Drawing.Size(155, 21);
            this.cboTenSVFilter.TabIndex = 50;
            this.cboTenSVFilter.SelectedValueChanged += new System.EventHandler(this.cboTenSVFilter_SelectedValueChanged);
            // 
            // cboMaSVFilter
            // 
            this.cboMaSVFilter.Enabled = false;
            this.cboMaSVFilter.FormattingEnabled = true;
            this.cboMaSVFilter.Location = new System.Drawing.Point(1325, 391);
            this.cboMaSVFilter.Name = "cboMaSVFilter";
            this.cboMaSVFilter.Size = new System.Drawing.Size(127, 21);
            this.cboMaSVFilter.TabIndex = 49;
            this.cboMaSVFilter.SelectedValueChanged += new System.EventHandler(this.cboMaHSFilter_SelectedValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(950, 393);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 16);
            this.label20.TabIndex = 48;
            this.label20.Text = "Tên sinh viên:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(1229, 392);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 16);
            this.label21.TabIndex = 47;
            this.label21.Text = "Mã sinh viên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(981, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(480, 24);
            this.textBox1.TabIndex = 51;
            this.textBox1.Text = "Công thức: ĐTK = ((Điểm miệng + Điểm 15p) + (Điểm45 * 2) + (Điểm giữa kì + Điểm c" +
    "uối kì) * 3)/10";
            // 
            // cboLopFilter
            // 
            this.cboLopFilter.Enabled = false;
            this.cboLopFilter.FormattingEnabled = true;
            this.cboLopFilter.Location = new System.Drawing.Point(1178, 333);
            this.cboLopFilter.Name = "cboLopFilter";
            this.cboLopFilter.Size = new System.Drawing.Size(155, 21);
            this.cboLopFilter.TabIndex = 58;
            this.cboLopFilter.SelectedValueChanged += new System.EventHandler(this.cboLopFilter_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1077, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.Enabled = false;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(137, 187);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(155, 21);
            this.cboLop.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Lớp:";
            // 
            // btnLayDS
            // 
            this.btnLayDS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnLayDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLayDS.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayDS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnLayDS.Location = new System.Drawing.Point(37, 443);
            this.btnLayDS.Name = "btnLayDS";
            this.btnLayDS.Size = new System.Drawing.Size(154, 60);
            this.btnLayDS.TabIndex = 61;
            this.btnLayDS.Text = "LẤY DANH SÁCH SINH VIÊN";
            this.btnLayDS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLayDS.UseVisualStyleBackColor = false;
            this.btnLayDS.Click += new System.EventHandler(this.btnLayDS_Click);
            // 
            // frmQuanLyDiemSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1473, 847);
            this.Controls.Add(this.btnLayDS);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboLopFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboTenSVFilter);
            this.Controls.Add(this.cboMaSVFilter);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDiemTongKet);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDiemCuoiKi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDiemGiuaKi);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDiem45Phut);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDiem15Phut);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboMonFilter);
            this.Controls.Add(this.txtDiemMieng);
            this.Controls.Add(this.cboTenMon);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongTinDiemSo);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "frmQuanLyDiemSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyDiemSo";
            this.Load += new System.EventHandler(this.frmQuanLyDiemSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDiemSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinDiemSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.TextBox txtDiemMieng;
        private System.Windows.Forms.ComboBox cboMonFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiem15Phut;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDiem45Phut;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiemGiuaKi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDiemCuoiKi;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDiemTongKet;
        private System.Windows.Forms.ComboBox cboTenSVFilter;
        private System.Windows.Forms.ComboBox cboMaSVFilter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboLopFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLayDS;
    }
}