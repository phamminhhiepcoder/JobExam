namespace GUI
{
    partial class frmThongTinMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMonThem = new System.Windows.Forms.TextBox();
            this.txtTenMonCapNhat = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvThongTinMonHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN CÁC MÔN HỌC";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(297, 115);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(161, 21);
            this.cboMonHoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn tên môn học:";
            // 
            // txtTenMonThem
            // 
            this.txtTenMonThem.Location = new System.Drawing.Point(824, 66);
            this.txtTenMonThem.Name = "txtTenMonThem";
            this.txtTenMonThem.Size = new System.Drawing.Size(135, 20);
            this.txtTenMonThem.TabIndex = 8;
            // 
            // txtTenMonCapNhat
            // 
            this.txtTenMonCapNhat.Location = new System.Drawing.Point(824, 131);
            this.txtTenMonCapNhat.Name = "txtTenMonCapNhat";
            this.txtTenMonCapNhat.Size = new System.Drawing.Size(135, 20);
            this.txtTenMonCapNhat.TabIndex = 9;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.button18.Location = new System.Drawing.Point(908, 215);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(154, 42);
            this.button18.TabIndex = 36;
            this.button18.Text = "Reset";
            this.button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.button17.Location = new System.Drawing.Point(604, 118);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(154, 42);
            this.button17.TabIndex = 37;
            this.button17.Text = "Sửa";
            this.button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.button16.Location = new System.Drawing.Point(604, 184);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(154, 42);
            this.button16.TabIndex = 38;
            this.button16.Text = "Xoá";
            this.button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.button15.Location = new System.Drawing.Point(604, 53);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(154, 42);
            this.button15.TabIndex = 39;
            this.button15.Text = "Thêm";
            this.button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Thông tin các môn học:";
            // 
            // dgvThongTinMonHoc
            // 
            this.dgvThongTinMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.dgvThongTinMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinMonHoc.Location = new System.Drawing.Point(12, 301);
            this.dgvThongTinMonHoc.Name = "dgvThongTinMonHoc";
            this.dgvThongTinMonHoc.Size = new System.Drawing.Size(1075, 280);
            this.dgvThongTinMonHoc.TabIndex = 41;
            this.dgvThongTinMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinMonHoc_CellClick);
            // 
            // frmThongTinMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1099, 593);
            this.Controls.Add(this.dgvThongTinMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.txtTenMonCapNhat);
            this.Controls.Add(this.txtTenMonThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.label1);
            this.Name = "frmThongTinMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongTinMonHoc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThongTinMonHoc_FormClosed);
            this.Load += new System.EventHandler(this.frmThongTinMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMonThem;
        private System.Windows.Forms.TextBox txtTenMonCapNhat;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThongTinMonHoc;
    }
}