namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class frmBuuCucGiuLai
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
            daoTienThuCOD.Database.sp_tblPhanBuuTa_DanhSach_THopResult sp_tblPhanBuuTa_DanhSach_THopResult1 = new daoTienThuCOD.Database.sp_tblPhanBuuTa_DanhSach_THopResult();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatBuuTaGiuLai = new System.Windows.Forms.Button();
            this.txtSoHieu = new System.Windows.Forms.TextBox();
            this.chkToanBuuCuc = new System.Windows.Forms.CheckBox();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.grdBuuGuiGiuLai1 = new daoTienThuCOD.ThanhPhanGiaoDien.ucBuuGuiGiuLai();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhatBuuTaGiuLai);
            this.groupBox1.Controls.Add(this.txtSoHieu);
            this.groupBox1.Controls.Add(this.chkToanBuuCuc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCapNhatBuuTaGiuLai
            // 
            this.btnCapNhatBuuTaGiuLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatBuuTaGiuLai.Location = new System.Drawing.Point(704, 16);
            this.btnCapNhatBuuTaGiuLai.Name = "btnCapNhatBuuTaGiuLai";
            this.btnCapNhatBuuTaGiuLai.Size = new System.Drawing.Size(178, 41);
            this.btnCapNhatBuuTaGiuLai.TabIndex = 2;
            this.btnCapNhatBuuTaGiuLai.Text = "Giữ lại phát tiếp";
            this.btnCapNhatBuuTaGiuLai.UseVisualStyleBackColor = true;
            this.btnCapNhatBuuTaGiuLai.Visible = false;
            this.btnCapNhatBuuTaGiuLai.Click += new System.EventHandler(this.btnCapNhatBuuTaGiuLai_Click);
            // 
            // txtSoHieu
            // 
            this.txtSoHieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHieu.Location = new System.Drawing.Point(299, 16);
            this.txtSoHieu.MaxLength = 20;
            this.txtSoHieu.Name = "txtSoHieu";
            this.txtSoHieu.Size = new System.Drawing.Size(363, 44);
            this.txtSoHieu.TabIndex = 1;
            this.txtSoHieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoHieu.TextChanged += new System.EventHandler(this.txtSoHieu_TextChanged);
            this.txtSoHieu.Enter += new System.EventHandler(this.txtSoHieu_Enter);
            this.txtSoHieu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoHieu_KeyUp);
            this.txtSoHieu.Leave += new System.EventHandler(this.txtSoHieu_Leave);
            // 
            // chkToanBuuCuc
            // 
            this.chkToanBuuCuc.AutoSize = true;
            this.chkToanBuuCuc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkToanBuuCuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkToanBuuCuc.Location = new System.Drawing.Point(12, 25);
            this.chkToanBuuCuc.Name = "chkToanBuuCuc";
            this.chkToanBuuCuc.Size = new System.Drawing.Size(153, 24);
            this.chkToanBuuCuc.TabIndex = 0;
            this.chkToanBuuCuc.Text = "Tất cả Bưu cục:";
            this.chkToanBuuCuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkToanBuuCuc.UseVisualStyleBackColor = true;
            this.chkToanBuuCuc.CheckedChanged += new System.EventHandler(this.chkToanBuuCuc_CheckedChanged);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(172, 281);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(903, 23);
            this.pgb.TabIndex = 2;
            this.pgb.Visible = false;
            // 
            // grdBuuGuiGiuLai1
            // 
            this.grdBuuGuiGiuLai1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdBuuGuiGiuLai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdBuuGuiGiuLai1.Location = new System.Drawing.Point(0, 73);
            this.grdBuuGuiGiuLai1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdBuuGuiGiuLai1.Name = "grdBuuGuiGiuLai1";
            sp_tblPhanBuuTa_DanhSach_THopResult1.Ca = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.FromPoscode = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.FullName = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.IncomingDate = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.MailTripNumber = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.Ngay = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.PostBagNumber = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.ServiceCode = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.SoLuong = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.ToPoscode = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.Value = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.Weight = null;
            sp_tblPhanBuuTa_DanhSach_THopResult1.WeightConvert = null;
            this.grdBuuGuiGiuLai1.PHBT = sp_tblPhanBuuTa_DanhSach_THopResult1;
            this.grdBuuGuiGiuLai1.Size = new System.Drawing.Size(1200, 619);
            this.grdBuuGuiGiuLai1.TabIndex = 1;
            this.grdBuuGuiGiuLai1.Hien += new daoTienThuCOD.ThanhPhanGiaoDien.ucBuuGuiGiuLai.HienThiHandler(this.grdBuuGuiGiuLai1_Hien);
            this.grdBuuGuiGiuLai1.HienXong += new daoTienThuCOD.ThanhPhanGiaoDien.ucBuuGuiGiuLai.HienThiXongHandler(this.grdBuuGuiGiuLai1_HienXong);
            // 
            // frmBuuCucGiuLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.grdBuuGuiGiuLai1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuuCucGiuLai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bưu gửi chưa phát được trong ngày";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuuCucGiuLai_FormClosing);
            this.Resize += new System.EventHandler(this.frmBuuCucGiuLai_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhatBuuTaGiuLai;
        private System.Windows.Forms.TextBox txtSoHieu;
        private System.Windows.Forms.CheckBox chkToanBuuCuc;
        private ucBuuGuiGiuLai grdBuuGuiGiuLai1;
        private System.Windows.Forms.ProgressBar pgb;
    }
}