namespace QuanLiHocSinh2
{
    partial class fmQuanLiHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMaHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbThongTinHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Học Sinh";
            // 
            // gbThongTinHocSinh
            // 
            this.gbThongTinHocSinh.Controls.Add(this.txbDiaChi);
            this.gbThongTinHocSinh.Controls.Add(this.rbNu);
            this.gbThongTinHocSinh.Controls.Add(this.rbNam);
            this.gbThongTinHocSinh.Controls.Add(this.cmbLop);
            this.gbThongTinHocSinh.Controls.Add(this.dtpNgaySinh);
            this.gbThongTinHocSinh.Controls.Add(this.txbHoTen);
            this.gbThongTinHocSinh.Controls.Add(this.txbMaHS);
            this.gbThongTinHocSinh.Controls.Add(this.label7);
            this.gbThongTinHocSinh.Controls.Add(this.label6);
            this.gbThongTinHocSinh.Controls.Add(this.label4);
            this.gbThongTinHocSinh.Controls.Add(this.label5);
            this.gbThongTinHocSinh.Controls.Add(this.label3);
            this.gbThongTinHocSinh.Controls.Add(this.label2);
            this.gbThongTinHocSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinHocSinh.ForeColor = System.Drawing.Color.White;
            this.gbThongTinHocSinh.Location = new System.Drawing.Point(46, 81);
            this.gbThongTinHocSinh.Name = "gbThongTinHocSinh";
            this.gbThongTinHocSinh.Size = new System.Drawing.Size(780, 205);
            this.gbThongTinHocSinh.TabIndex = 1;
            this.gbThongTinHocSinh.TabStop = false;
            this.gbThongTinHocSinh.Text = "Thông tin học sinh";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(578, 152);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(181, 29);
            this.txbDiaChi.TabIndex = 5;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(674, 44);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(49, 25);
            this.rbNu.TabIndex = 4;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(578, 43);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(62, 25);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(578, 91);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(181, 29);
            this.cmbLop.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(146, 143);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 29);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(146, 91);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(200, 29);
            this.txbHoTen.TabIndex = 1;
            // 
            // txbMaHS
            // 
            this.txbMaHS.Location = new System.Drawing.Point(146, 43);
            this.txbMaHS.Name = "txbMaHS";
            this.txbMaHS.ReadOnly = true;
            this.txbMaHS.Size = new System.Drawing.Size(200, 29);
            this.txbMaHS.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HS";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Green;
            this.btThem.BackgroundImage = global::QuanLiHocSinh2.Properties.Resources.Them;
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Location = new System.Drawing.Point(674, 402);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(73, 65);
            this.btThem.TabIndex = 3;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Teal;
            this.btXoa.BackgroundImage = global::QuanLiHocSinh2.Properties.Resources.Xoa;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Location = new System.Drawing.Point(674, 473);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(73, 65);
            this.btXoa.TabIndex = 3;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Purple;
            this.btSua.BackgroundImage = global::QuanLiHocSinh2.Properties.Resources.sua;
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Location = new System.Drawing.Point(674, 544);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(73, 65);
            this.btSua.TabIndex = 3;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.Orange;
            this.btLuu.BackgroundImage = global::QuanLiHocSinh2.Properties.Resources.Luu;
            this.btLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLuu.Location = new System.Drawing.Point(753, 402);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(73, 65);
            this.btLuu.TabIndex = 3;
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.BackgroundImage = global::QuanLiHocSinh2.Properties.Resources.Thoat;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoat.Location = new System.Drawing.Point(753, 544);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(73, 65);
            this.btThoat.TabIndex = 3;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.Blue;
            this.btHuy.BackgroundImage = global::QuanLiHocSinh2.Properties.Resources.Huy;
            this.btHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHuy.Location = new System.Drawing.Point(753, 473);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(73, 65);
            this.btHuy.TabIndex = 3;
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.AllowUserToAddRows = false;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(46, 402);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDanhSachHocSinh.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(622, 207);
            this.dgvDanhSachHocSinh.TabIndex = 4;
            this.dgvDanhSachHocSinh.Click += new System.EventHandler(this.dgvDanhSachHocSinh_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.txtTimKiem);
            this.gbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimKiem.ForeColor = System.Drawing.Color.White;
            this.gbTimKiem.Location = new System.Drawing.Point(46, 301);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(780, 68);
            this.gbTimKiem.TabIndex = 5;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(18, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(404, 25);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Nhập vào tên học sinh ";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Location = new System.Drawing.Point(452, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 25);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // fmQuanLiHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(858, 664);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.gbThongTinHocSinh);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "fmQuanLiHocSinh";
            this.Text = "Quản Lí Học Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmQuanLiHocSinh_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThongTinHocSinh.ResumeLayout(false);
            this.gbThongTinHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinHocSinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbMaHS;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}

