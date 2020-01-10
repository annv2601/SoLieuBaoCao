namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class frmBanKeNopTien
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
            this.lblBKNopTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayCapNguoiNhan = new System.Windows.Forms.DateTimePicker();
            this.txtNgayCapNguoGiao = new System.Windows.Forms.DateTimePicker();
            this.txtNoiCapNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtNoiCapNguoiGiao = new System.Windows.Forms.TextBox();
            this.txtChucDanhNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtChucDanhNguoiGiao = new System.Windows.Forms.TextBox();
            this.txtCMNDNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtCMNDNguoiGiao = new System.Windows.Forms.TextBox();
            this.txtNguoiGiao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTongTienCo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiaDiemGiaoNhan = new System.Windows.Forms.TextBox();
            this.txtChiNhanhNganHang = new System.Windows.Forms.TextBox();
            this.txtPhuongThucGiaoNhan = new System.Windows.Forms.TextBox();
            this.grdTaiKhoan1 = new daoTienThuCOD.ThanhPhanGiaoDien.grdTaiKhoan();
            this.grdMenhGia1 = new daoTienThuCOD.ThanhPhanGiaoDien.grdMenhGia();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBKNopTien
            // 
            this.lblBKNopTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBKNopTien.Location = new System.Drawing.Point(-2, 3);
            this.lblBKNopTien.Name = "lblBKNopTien";
            this.lblBKNopTien.Size = new System.Drawing.Size(1201, 38);
            this.lblBKNopTien.TabIndex = 0;
            this.lblBKNopTien.Text = "BẢN KÊ NỘP TIỀN NGÀY ....";
            this.lblBKNopTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgayCapNguoiNhan);
            this.groupBox1.Controls.Add(this.txtNgayCapNguoGiao);
            this.groupBox1.Controls.Add(this.txtNoiCapNguoiNhan);
            this.groupBox1.Controls.Add(this.txtNoiCapNguoiGiao);
            this.groupBox1.Controls.Add(this.txtChucDanhNguoiNhan);
            this.groupBox1.Controls.Add(this.txtChucDanhNguoiGiao);
            this.groupBox1.Controls.Add(this.txtCMNDNguoiNhan);
            this.groupBox1.Controls.Add(this.txtNguoiNhan);
            this.groupBox1.Controls.Add(this.txtCMNDNguoiGiao);
            this.groupBox1.Controls.Add(this.txtNguoiGiao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtNgayCapNguoiNhan
            // 
            this.txtNgayCapNguoiNhan.CustomFormat = "dd/MM/yyyy";
            this.txtNgayCapNguoiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayCapNguoiNhan.Location = new System.Drawing.Point(550, 96);
            this.txtNgayCapNguoiNhan.Name = "txtNgayCapNguoiNhan";
            this.txtNgayCapNguoiNhan.Size = new System.Drawing.Size(200, 26);
            this.txtNgayCapNguoiNhan.TabIndex = 23;
            this.txtNgayCapNguoiNhan.ValueChanged += new System.EventHandler(this.txtNgayCapNguoiNhan_ValueChanged);
            // 
            // txtNgayCapNguoGiao
            // 
            this.txtNgayCapNguoGiao.CustomFormat = "dd/MM/yyyy";
            this.txtNgayCapNguoGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayCapNguoGiao.Location = new System.Drawing.Point(550, 40);
            this.txtNgayCapNguoGiao.Name = "txtNgayCapNguoGiao";
            this.txtNgayCapNguoGiao.Size = new System.Drawing.Size(200, 26);
            this.txtNgayCapNguoGiao.TabIndex = 22;
            this.txtNgayCapNguoGiao.ValueChanged += new System.EventHandler(this.txtNgayCapNguoGiao_ValueChanged);
            // 
            // txtNoiCapNguoiNhan
            // 
            this.txtNoiCapNguoiNhan.Location = new System.Drawing.Point(938, 96);
            this.txtNoiCapNguoiNhan.Name = "txtNoiCapNguoiNhan";
            this.txtNoiCapNguoiNhan.Size = new System.Drawing.Size(237, 26);
            this.txtNoiCapNguoiNhan.TabIndex = 21;
            this.txtNoiCapNguoiNhan.TextChanged += new System.EventHandler(this.txtNoiCapNguoiNhan_TextChanged);
            // 
            // txtNoiCapNguoiGiao
            // 
            this.txtNoiCapNguoiGiao.Location = new System.Drawing.Point(938, 35);
            this.txtNoiCapNguoiGiao.Name = "txtNoiCapNguoiGiao";
            this.txtNoiCapNguoiGiao.Size = new System.Drawing.Size(237, 26);
            this.txtNoiCapNguoiGiao.TabIndex = 20;
            this.txtNoiCapNguoiGiao.TextChanged += new System.EventHandler(this.txtNoiCapNguoiGiao_TextChanged);
            // 
            // txtChucDanhNguoiNhan
            // 
            this.txtChucDanhNguoiNhan.Location = new System.Drawing.Point(550, 68);
            this.txtChucDanhNguoiNhan.Name = "txtChucDanhNguoiNhan";
            this.txtChucDanhNguoiNhan.Size = new System.Drawing.Size(286, 26);
            this.txtChucDanhNguoiNhan.TabIndex = 18;
            this.txtChucDanhNguoiNhan.TextChanged += new System.EventHandler(this.txtChucDanhNguoiNhan_TextChanged);
            // 
            // txtChucDanhNguoiGiao
            // 
            this.txtChucDanhNguoiGiao.Location = new System.Drawing.Point(550, 14);
            this.txtChucDanhNguoiGiao.Name = "txtChucDanhNguoiGiao";
            this.txtChucDanhNguoiGiao.Size = new System.Drawing.Size(286, 26);
            this.txtChucDanhNguoiGiao.TabIndex = 16;
            this.txtChucDanhNguoiGiao.TextChanged += new System.EventHandler(this.txtChucDanhNguoiGiao_TextChanged);
            // 
            // txtCMNDNguoiNhan
            // 
            this.txtCMNDNguoiNhan.Location = new System.Drawing.Point(103, 96);
            this.txtCMNDNguoiNhan.Name = "txtCMNDNguoiNhan";
            this.txtCMNDNguoiNhan.Size = new System.Drawing.Size(291, 26);
            this.txtCMNDNguoiNhan.TabIndex = 15;
            this.txtCMNDNguoiNhan.TextChanged += new System.EventHandler(this.txtCMNDNguoiNhan_TextChanged);
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(103, 71);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(291, 26);
            this.txtNguoiNhan.TabIndex = 14;
            this.txtNguoiNhan.TextChanged += new System.EventHandler(this.txtNguoiNhan_TextChanged);
            // 
            // txtCMNDNguoiGiao
            // 
            this.txtCMNDNguoiGiao.Location = new System.Drawing.Point(103, 35);
            this.txtCMNDNguoiGiao.Name = "txtCMNDNguoiGiao";
            this.txtCMNDNguoiGiao.Size = new System.Drawing.Size(291, 26);
            this.txtCMNDNguoiGiao.TabIndex = 13;
            this.txtCMNDNguoiGiao.TextChanged += new System.EventHandler(this.txtCMNDNguoiGiao_TextChanged);
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Location = new System.Drawing.Point(103, 14);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.Size = new System.Drawing.Size(291, 26);
            this.txtNguoiGiao.TabIndex = 12;
            this.txtNguoiGiao.TextChanged += new System.EventHandler(this.txtNguoiGiao_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(865, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nơi cấp:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(865, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nơi cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày cấp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chức danh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chức danh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CMND số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người nhận: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMND số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người giao: ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(941, 337);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(221, 55);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Visible = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(941, 433);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(221, 55);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In bản kê";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Visible = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(941, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tổng tiền có:";
            // 
            // lblTongTienCo
            // 
            this.lblTongTienCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienCo.Location = new System.Drawing.Point(945, 274);
            this.lblTongTienCo.Name = "lblTongTienCo";
            this.lblTongTienCo.Size = new System.Drawing.Size(217, 40);
            this.lblTongTienCo.TabIndex = 7;
            this.lblTongTienCo.Text = "TienCo";
            this.lblTongTienCo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Địa điểm giao nhận: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(467, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Ngân hàng: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Phương thức giao nhận: ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtDiaDiemGiaoNhan
            // 
            this.txtDiaDiemGiaoNhan.Location = new System.Drawing.Point(166, 167);
            this.txtDiaDiemGiaoNhan.Name = "txtDiaDiemGiaoNhan";
            this.txtDiaDiemGiaoNhan.Size = new System.Drawing.Size(1012, 26);
            this.txtDiaDiemGiaoNhan.TabIndex = 11;
            this.txtDiaDiemGiaoNhan.TextChanged += new System.EventHandler(this.txtDiaDiemGiaoNhan_TextChanged);
            // 
            // txtChiNhanhNganHang
            // 
            this.txtChiNhanhNganHang.Location = new System.Drawing.Point(568, 207);
            this.txtChiNhanhNganHang.Name = "txtChiNhanhNganHang";
            this.txtChiNhanhNganHang.Size = new System.Drawing.Size(610, 26);
            this.txtChiNhanhNganHang.TabIndex = 12;
            this.txtChiNhanhNganHang.TextChanged += new System.EventHandler(this.txtChiNhanhNganHang_TextChanged);
            // 
            // txtPhuongThucGiaoNhan
            // 
            this.txtPhuongThucGiaoNhan.Location = new System.Drawing.Point(194, 207);
            this.txtPhuongThucGiaoNhan.Name = "txtPhuongThucGiaoNhan";
            this.txtPhuongThucGiaoNhan.Size = new System.Drawing.Size(267, 26);
            this.txtPhuongThucGiaoNhan.TabIndex = 13;
            this.txtPhuongThucGiaoNhan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // grdTaiKhoan1
            // 
            this.grdTaiKhoan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTaiKhoan1.Location = new System.Drawing.Point(3, 247);
            this.grdTaiKhoan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdTaiKhoan1.Name = "grdTaiKhoan1";
            this.grdTaiKhoan1.Size = new System.Drawing.Size(836, 239);
            this.grdTaiKhoan1.TabIndex = 3;
            // 
            // grdMenhGia1
            // 
            this.grdMenhGia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdMenhGia1.Location = new System.Drawing.Point(3, 496);
            this.grdMenhGia1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdMenhGia1.Name = "grdMenhGia1";
            this.grdMenhGia1.Size = new System.Drawing.Size(1196, 359);
            this.grdMenhGia1.TabIndex = 2;
            this.grdMenhGia1.Nhap += new daoTienThuCOD.ThanhPhanGiaoDien.grdMenhGia.NhapHandler(this.grdMenhGia1_Nhap);
            // 
            // frmBanKeNopTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.txtPhuongThucGiaoNhan);
            this.Controls.Add(this.txtChiNhanhNganHang);
            this.Controls.Add(this.txtDiaDiemGiaoNhan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTongTienCo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grdTaiKhoan1);
            this.Controls.Add(this.grdMenhGia1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBKNopTien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBanKeNopTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bản kê Nộp tiền";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBKNopTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private grdMenhGia grdMenhGia1;
        private grdTaiKhoan grdTaiKhoan1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTongTienCo;
        private System.Windows.Forms.TextBox txtNoiCapNguoiNhan;
        private System.Windows.Forms.TextBox txtNoiCapNguoiGiao;
        private System.Windows.Forms.TextBox txtChucDanhNguoiNhan;
        private System.Windows.Forms.TextBox txtChucDanhNguoiGiao;
        private System.Windows.Forms.TextBox txtCMNDNguoiNhan;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.TextBox txtCMNDNguoiGiao;
        private System.Windows.Forms.TextBox txtNguoiGiao;
        private System.Windows.Forms.DateTimePicker txtNgayCapNguoiNhan;
        private System.Windows.Forms.DateTimePicker txtNgayCapNguoGiao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiaDiemGiaoNhan;
        private System.Windows.Forms.TextBox txtChiNhanhNganHang;
        private System.Windows.Forms.TextBox txtPhuongThucGiaoNhan;
    }
}