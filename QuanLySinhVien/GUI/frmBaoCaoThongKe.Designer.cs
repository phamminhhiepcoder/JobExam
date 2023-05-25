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
            this.SuspendLayout();
            // 
            // btnThucHien
            // 
            this.btnThucHien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnThucHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHien.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnThucHien.Location = new System.Drawing.Point(267, 228);
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
            "Thống kê học bạ",
            "Thống kê điểm"});
            this.cboLuaChon.Location = new System.Drawing.Point(294, 144);
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
            this.label10.Location = new System.Drawing.Point(23, 142);
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
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "BÁO CÁO THỐNG KÊ HỆ THỐNG";
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(732, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboLuaChon);
            this.Controls.Add(this.btnThucHien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.ComboBox cboLuaChon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}