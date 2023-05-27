namespace DictionaryEng
{
    partial class frmTuDien
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
            this.dgvDictionary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLoaiTu = new System.Windows.Forms.ComboBox();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNap = new System.Windows.Forms.Button();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.txtViDu = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDictionary
            // 
            this.dgvDictionary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictionary.Location = new System.Drawing.Point(12, 375);
            this.dgvDictionary.Name = "dgvDictionary";
            this.dgvDictionary.Size = new System.Drawing.Size(1433, 451);
            this.dgvDictionary.TabIndex = 0;
            this.dgvDictionary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDictionary_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "DICTIONARY ENG -ENG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nghĩa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ví dụ:";
            // 
            // cboLoaiTu
            // 
            this.cboLoaiTu.FormattingEnabled = true;
            this.cboLoaiTu.Items.AddRange(new object[] {
            "Noun",
            "Verb",
            "Adjective"});
            this.cboLoaiTu.Location = new System.Drawing.Point(555, 70);
            this.cboLoaiTu.Name = "cboLoaiTu";
            this.cboLoaiTu.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiTu.TabIndex = 6;
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(119, 155);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(187, 20);
            this.txtTu.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(508, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 44);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm từ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(732, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 44);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá từ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1249, 37);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 44);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu từ điển vào file test";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNap
            // 
            this.btnNap.Location = new System.Drawing.Point(1249, 131);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(93, 44);
            this.btnNap.TabIndex = 11;
            this.btnNap.Text = "Nạp từ điển từ file test";
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(555, 142);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(520, 20);
            this.txtNghia.TabIndex = 12;
            // 
            // txtViDu
            // 
            this.txtViDu.Location = new System.Drawing.Point(555, 183);
            this.txtViDu.Multiline = true;
            this.txtViDu.Name = "txtViDu";
            this.txtViDu.Size = new System.Drawing.Size(558, 68);
            this.txtViDu.TabIndex = 13;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(1336, 295);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 60);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Xem file excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmTuDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 835);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtViDu);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.btnNap);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.cboLoaiTu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDictionary);
            this.Name = "frmTuDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỪ ĐIỂN ANH - VIỆT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDictionary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiTu;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNap;
        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.TextBox txtViDu;
        private System.Windows.Forms.Button btnExcel;
    }
}

