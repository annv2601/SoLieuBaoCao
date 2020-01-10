namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class ucKeToanBuuTa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBuuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuDauSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuDauSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanMoiSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanMoiSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenHoanSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenHoanSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSGiamKhacSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSGiamKhacSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuCuoiSanLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuCuoiSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBuuTa = new System.Windows.Forms.ComboBox();
            this.btnTongHop = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnKeToanBuuCuc = new System.Windows.Forms.Button();
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
            this.MaBuuTa,
            this.Ten,
            this.DuDauSanLuong,
            this.DuDauSoTien,
            this.NhanMoiSanLuong,
            this.NhanMoiSoTien,
            this.TraSanLuong,
            this.TraSoTien,
            this.ChuyenHoanSanLuong,
            this.ChuyenHoanSoTien,
            this.PSGiamKhacSanLuong,
            this.PSGiamKhacSoTien,
            this.DuCuoiSanLuong,
            this.DuCuoiSoTien,
            this.STT});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 63);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1297, 601);
            this.dgv.TabIndex = 1;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseMove);
            // 
            // Ngay
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "dd/MM/yyyy";
            this.Ngay.DefaultCellStyle = dataGridViewCellStyle16;
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 120;
            // 
            // MaBuuTa
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MaBuuTa.DefaultCellStyle = dataGridViewCellStyle17;
            this.MaBuuTa.HeaderText = "Mã";
            this.MaBuuTa.Name = "MaBuuTa";
            this.MaBuuTa.ReadOnly = true;
            this.MaBuuTa.Width = 150;
            // 
            // Ten
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Ten.DefaultCellStyle = dataGridViewCellStyle18;
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 250;
            // 
            // DuDauSanLuong
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "######";
            this.DuDauSanLuong.DefaultCellStyle = dataGridViewCellStyle19;
            this.DuDauSanLuong.HeaderText = "Dư đầu SL";
            this.DuDauSanLuong.Name = "DuDauSanLuong";
            this.DuDauSanLuong.ReadOnly = true;
            this.DuDauSanLuong.Width = 120;
            // 
            // DuDauSoTien
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuDauSoTien.DefaultCellStyle = dataGridViewCellStyle20;
            this.DuDauSoTien.HeaderText = "Dư đầu Số tiền";
            this.DuDauSoTien.Name = "DuDauSoTien";
            this.DuDauSoTien.ReadOnly = true;
            this.DuDauSoTien.Width = 160;
            // 
            // NhanMoiSanLuong
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "######";
            this.NhanMoiSanLuong.DefaultCellStyle = dataGridViewCellStyle21;
            this.NhanMoiSanLuong.HeaderText = "Nhận mới SL";
            this.NhanMoiSanLuong.Name = "NhanMoiSanLuong";
            this.NhanMoiSanLuong.ReadOnly = true;
            this.NhanMoiSanLuong.Width = 120;
            // 
            // NhanMoiSoTien
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanMoiSoTien.DefaultCellStyle = dataGridViewCellStyle22;
            this.NhanMoiSoTien.HeaderText = "Nhận mới Số tiền";
            this.NhanMoiSoTien.Name = "NhanMoiSoTien";
            this.NhanMoiSoTien.ReadOnly = true;
            this.NhanMoiSoTien.Width = 200;
            // 
            // TraSanLuong
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Format = "######";
            this.TraSanLuong.DefaultCellStyle = dataGridViewCellStyle23;
            this.TraSanLuong.HeaderText = "Phát SL";
            this.TraSanLuong.Name = "TraSanLuong";
            this.TraSanLuong.ReadOnly = true;
            this.TraSanLuong.Width = 120;
            // 
            // TraSoTien
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraSoTien.DefaultCellStyle = dataGridViewCellStyle24;
            this.TraSoTien.HeaderText = "Phát Số tiền";
            this.TraSoTien.Name = "TraSoTien";
            this.TraSoTien.ReadOnly = true;
            this.TraSoTien.Width = 200;
            // 
            // ChuyenHoanSanLuong
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Format = "######";
            this.ChuyenHoanSanLuong.DefaultCellStyle = dataGridViewCellStyle25;
            this.ChuyenHoanSanLuong.HeaderText = "Chuyển hoàn SL";
            this.ChuyenHoanSanLuong.Name = "ChuyenHoanSanLuong";
            this.ChuyenHoanSanLuong.ReadOnly = true;
            this.ChuyenHoanSanLuong.Width = 120;
            // 
            // ChuyenHoanSoTien
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuyenHoanSoTien.DefaultCellStyle = dataGridViewCellStyle26;
            this.ChuyenHoanSoTien.HeaderText = "Chuyển hoàn Số tiền";
            this.ChuyenHoanSoTien.Name = "ChuyenHoanSoTien";
            this.ChuyenHoanSoTien.ReadOnly = true;
            this.ChuyenHoanSoTien.Width = 200;
            // 
            // PSGiamKhacSanLuong
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Format = "######";
            this.PSGiamKhacSanLuong.DefaultCellStyle = dataGridViewCellStyle27;
            this.PSGiamKhacSanLuong.HeaderText = "Khác SL";
            this.PSGiamKhacSanLuong.Name = "PSGiamKhacSanLuong";
            this.PSGiamKhacSanLuong.ReadOnly = true;
            this.PSGiamKhacSanLuong.Width = 120;
            // 
            // PSGiamKhacSoTien
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSGiamKhacSoTien.DefaultCellStyle = dataGridViewCellStyle28;
            this.PSGiamKhacSoTien.HeaderText = "Khác Số tiền";
            this.PSGiamKhacSoTien.Name = "PSGiamKhacSoTien";
            this.PSGiamKhacSoTien.ReadOnly = true;
            this.PSGiamKhacSoTien.Width = 200;
            // 
            // DuCuoiSanLuong
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.Format = "######";
            this.DuCuoiSanLuong.DefaultCellStyle = dataGridViewCellStyle29;
            this.DuCuoiSanLuong.HeaderText = "Dư cuối SL";
            this.DuCuoiSanLuong.Name = "DuCuoiSanLuong";
            this.DuCuoiSanLuong.ReadOnly = true;
            this.DuCuoiSanLuong.Width = 120;
            // 
            // DuCuoiSoTien
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuCuoiSoTien.DefaultCellStyle = dataGridViewCellStyle30;
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
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnKeToanBuuCuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboBuuTa);
            this.groupBox1.Controls.Add(this.btnTongHop);
            this.groupBox1.Controls.Add(this.btnHienThi);
            this.groupBox1.Controls.Add(this.txtDenNgay);
            this.groupBox1.Controls.Add(this.txtTuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1297, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bưu tá : ";
            // 
            // cboBuuTa
            // 
            this.cboBuuTa.FormattingEnabled = true;
            this.cboBuuTa.Location = new System.Drawing.Point(557, 17);
            this.cboBuuTa.Name = "cboBuuTa";
            this.cboBuuTa.Size = new System.Drawing.Size(240, 28);
            this.cboBuuTa.TabIndex = 6;
            // 
            // btnTongHop
            // 
            this.btnTongHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongHop.Location = new System.Drawing.Point(997, 17);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(128, 34);
            this.btnTongHop.TabIndex = 5;
            this.btnTongHop.Text = "Tổng hợp";
            this.btnTongHop.UseVisualStyleBackColor = true;
            this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(838, 16);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(128, 34);
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
            // btnKeToanBuuCuc
            // 
            this.btnKeToanBuuCuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeToanBuuCuc.Location = new System.Drawing.Point(1151, 16);
            this.btnKeToanBuuCuc.Name = "btnKeToanBuuCuc";
            this.btnKeToanBuuCuc.Size = new System.Drawing.Size(128, 34);
            this.btnKeToanBuuCuc.TabIndex = 8;
            this.btnKeToanBuuCuc.Text = "Vu hồi BC";
            this.btnKeToanBuuCuc.UseVisualStyleBackColor = true;
            this.btnKeToanBuuCuc.Click += new System.EventHandler(this.btnKeToanBuuCuc_Click);
            // 
            // ucKeToanBuuTa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucKeToanBuuTa";
            this.Size = new System.Drawing.Size(1297, 664);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBuuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBuuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuDauSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuDauSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanMoiSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanMoiSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenHoanSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenHoanSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSGiamKhacSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSGiamKhacSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuCuoiSanLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuCuoiSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnKeToanBuuCuc;
    }
}
