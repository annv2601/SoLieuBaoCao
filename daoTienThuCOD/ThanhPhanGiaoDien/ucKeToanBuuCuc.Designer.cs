namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class ucKeToanBuuCuc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBuuCuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuDauSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuDauSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanMoiSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanMoiSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanBuuTaSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanBuuTaSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenHoanSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenHoanSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenTiepSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenTiepSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuCuoiSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuCuoiSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuanLyChotSoLieu = new System.Windows.Forms.Button();
            this.btnChotSoLieu = new System.Windows.Forms.Button();
            this.btnTongHop = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.MaBuuCuc,
            this.DuDauSanLuong,
            this.DuDauSoTien,
            this.NhanMoiSanLuong,
            this.NhanMoiSoTien,
            this.PhanBuuTaSanLuong,
            this.PhanBuuTaSoTien,
            this.TraSanLuong,
            this.TraSoTien,
            this.ChuyenHoanSanLuong,
            this.ChuyenHoanSoTien,
            this.ChuyenTiepSanLuong,
            this.ChuyenTiepSoTien,
            this.DuCuoiSanLuong,
            this.DuCuoiSoTien,
            this.STT});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 63);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1258, 601);
            this.dgv.TabIndex = 1;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            this.dgv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseMove);
            // 
            // Ngay
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Ngay.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 120;
            // 
            // MaBuuCuc
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MaBuuCuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaBuuCuc.HeaderText = "Mã";
            this.MaBuuCuc.Name = "MaBuuCuc";
            this.MaBuuCuc.ReadOnly = true;
            this.MaBuuCuc.Width = 150;
            // 
            // DuDauSanLuong
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "######";
            this.DuDauSanLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.DuDauSanLuong.HeaderText = "Dư đầu SL";
            this.DuDauSanLuong.Name = "DuDauSanLuong";
            this.DuDauSanLuong.ReadOnly = true;
            this.DuDauSanLuong.Width = 120;
            // 
            // DuDauSoTien
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuDauSoTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.DuDauSoTien.HeaderText = "Dư đầu Số tiền";
            this.DuDauSoTien.Name = "DuDauSoTien";
            this.DuDauSoTien.ReadOnly = true;
            this.DuDauSoTien.Width = 160;
            // 
            // NhanMoiSanLuong
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "######";
            this.NhanMoiSanLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.NhanMoiSanLuong.HeaderText = "Nhận mới SL";
            this.NhanMoiSanLuong.Name = "NhanMoiSanLuong";
            this.NhanMoiSanLuong.ReadOnly = true;
            this.NhanMoiSanLuong.Width = 120;
            // 
            // NhanMoiSoTien
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanMoiSoTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.NhanMoiSoTien.HeaderText = "Nhận mới Số tiền";
            this.NhanMoiSoTien.Name = "NhanMoiSoTien";
            this.NhanMoiSoTien.ReadOnly = true;
            this.NhanMoiSoTien.Width = 200;
            // 
            // PhanBuuTaSanLuong
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhanBuuTaSanLuong.DefaultCellStyle = dataGridViewCellStyle7;
            this.PhanBuuTaSanLuong.HeaderText = "Giao Bưu tá SL";
            this.PhanBuuTaSanLuong.Name = "PhanBuuTaSanLuong";
            this.PhanBuuTaSanLuong.ReadOnly = true;
            this.PhanBuuTaSanLuong.Width = 120;
            // 
            // PhanBuuTaSoTien
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhanBuuTaSoTien.DefaultCellStyle = dataGridViewCellStyle8;
            this.PhanBuuTaSoTien.HeaderText = "Giao Bưu tá Số tiền";
            this.PhanBuuTaSoTien.Name = "PhanBuuTaSoTien";
            this.PhanBuuTaSoTien.ReadOnly = true;
            this.PhanBuuTaSoTien.Width = 200;
            // 
            // TraSanLuong
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "######";
            this.TraSanLuong.DefaultCellStyle = dataGridViewCellStyle9;
            this.TraSanLuong.HeaderText = "Phát SL";
            this.TraSanLuong.Name = "TraSanLuong";
            this.TraSanLuong.ReadOnly = true;
            this.TraSanLuong.Width = 120;
            // 
            // TraSoTien
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraSoTien.DefaultCellStyle = dataGridViewCellStyle10;
            this.TraSoTien.HeaderText = "Phát Số tiền";
            this.TraSoTien.Name = "TraSoTien";
            this.TraSoTien.ReadOnly = true;
            this.TraSoTien.Width = 200;
            // 
            // ChuyenHoanSanLuong
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "######";
            this.ChuyenHoanSanLuong.DefaultCellStyle = dataGridViewCellStyle11;
            this.ChuyenHoanSanLuong.HeaderText = "Chuyển hoàn SL";
            this.ChuyenHoanSanLuong.Name = "ChuyenHoanSanLuong";
            this.ChuyenHoanSanLuong.ReadOnly = true;
            this.ChuyenHoanSanLuong.Width = 120;
            // 
            // ChuyenHoanSoTien
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuyenHoanSoTien.DefaultCellStyle = dataGridViewCellStyle12;
            this.ChuyenHoanSoTien.HeaderText = "Chuyển hoàn Số tiền";
            this.ChuyenHoanSoTien.Name = "ChuyenHoanSoTien";
            this.ChuyenHoanSoTien.ReadOnly = true;
            this.ChuyenHoanSoTien.Width = 200;
            // 
            // ChuyenTiepSanLuong
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "######";
            this.ChuyenTiepSanLuong.DefaultCellStyle = dataGridViewCellStyle13;
            this.ChuyenTiepSanLuong.HeaderText = "Chuyển tiếp SL";
            this.ChuyenTiepSanLuong.Name = "ChuyenTiepSanLuong";
            this.ChuyenTiepSanLuong.ReadOnly = true;
            this.ChuyenTiepSanLuong.Width = 120;
            // 
            // ChuyenTiepSoTien
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuyenTiepSoTien.DefaultCellStyle = dataGridViewCellStyle14;
            this.ChuyenTiepSoTien.HeaderText = "Chuyển tiếp Số tiền";
            this.ChuyenTiepSoTien.Name = "ChuyenTiepSoTien";
            this.ChuyenTiepSoTien.ReadOnly = true;
            this.ChuyenTiepSoTien.Width = 200;
            // 
            // DuCuoiSanLuong
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "######";
            this.DuCuoiSanLuong.DefaultCellStyle = dataGridViewCellStyle15;
            this.DuCuoiSanLuong.HeaderText = "Dư cuối SL";
            this.DuCuoiSanLuong.Name = "DuCuoiSanLuong";
            this.DuCuoiSanLuong.ReadOnly = true;
            this.DuCuoiSanLuong.Width = 120;
            // 
            // DuCuoiSoTien
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuCuoiSoTien.DefaultCellStyle = dataGridViewCellStyle16;
            this.DuCuoiSoTien.HeaderText = "Dư cuối Số tiền";
            this.DuCuoiSoTien.Name = "DuCuoiSoTien";
            this.DuCuoiSoTien.ReadOnly = true;
            this.DuCuoiSoTien.Width = 200;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnQuanLyChotSoLieu);
            this.groupBox1.Controls.Add(this.btnChotSoLieu);
            this.groupBox1.Controls.Add(this.btnTongHop);
            this.groupBox1.Controls.Add(this.btnHienThi);
            this.groupBox1.Controls.Add(this.txtDenNgay);
            this.groupBox1.Controls.Add(this.txtTuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1258, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnQuanLyChotSoLieu
            // 
            this.btnQuanLyChotSoLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyChotSoLieu.Location = new System.Drawing.Point(877, 16);
            this.btnQuanLyChotSoLieu.Name = "btnQuanLyChotSoLieu";
            this.btnQuanLyChotSoLieu.Size = new System.Drawing.Size(140, 34);
            this.btnQuanLyChotSoLieu.TabIndex = 7;
            this.btnQuanLyChotSoLieu.Text = "QL Ngày chốt";
            this.btnQuanLyChotSoLieu.UseVisualStyleBackColor = true;
            this.btnQuanLyChotSoLieu.Click += new System.EventHandler(this.btnQuanLyChotSoLieu_Click);
            // 
            // btnChotSoLieu
            // 
            this.btnChotSoLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChotSoLieu.Location = new System.Drawing.Point(705, 16);
            this.btnChotSoLieu.Name = "btnChotSoLieu";
            this.btnChotSoLieu.Size = new System.Drawing.Size(140, 34);
            this.btnChotSoLieu.TabIndex = 6;
            this.btnChotSoLieu.Text = "Chốt Số liệu";
            this.btnChotSoLieu.UseVisualStyleBackColor = true;
            this.btnChotSoLieu.Click += new System.EventHandler(this.btnChotSoLieu_Click);
            // 
            // btnTongHop
            // 
            this.btnTongHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongHop.Location = new System.Drawing.Point(731, 17);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(140, 34);
            this.btnTongHop.TabIndex = 5;
            this.btnTongHop.Text = "Tổng hợp";
            this.btnTongHop.UseVisualStyleBackColor = true;
            this.btnTongHop.Visible = false;
            this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(525, 16);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(140, 34);
            this.btnHienThi.TabIndex = 4;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDenNgay.Location = new System.Drawing.Point(332, 18);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(118, 26);
            this.txtDenNgay.TabIndex = 3;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTuNgay.Location = new System.Drawing.Point(86, 18);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(121, 26);
            this.txtTuNgay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày : ";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(40, 113);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(156, 48);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Visible = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // ucKeToanBuuCuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucKeToanBuuCuc";
            this.Size = new System.Drawing.Size(1258, 664);
            this.Resize += new System.EventHandler(this.ucBuuGuiDenPhat_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DateTimePicker txtDenNgay;
        private System.Windows.Forms.DateTimePicker txtTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTongHop;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnChotSoLieu;
        private System.Windows.Forms.Button btnQuanLyChotSoLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBuuCuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuDauSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuDauSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanMoiSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanMoiSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanBuuTaSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanBuuTaSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenHoanSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenHoanSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenTiepSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenTiepSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuCuoiSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuCuoiSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}
