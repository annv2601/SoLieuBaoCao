namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class frmBuuGuiGiuLai
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
            this.ucBuuGuiGiuLai1 = new daoTienThuCOD.ThanhPhanGiaoDien.ucBuuGuiGiuLai();
            this.SuspendLayout();
            // 
            // ucBuuGuiGiuLai1
            // 
            this.ucBuuGuiGiuLai1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBuuGuiGiuLai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBuuGuiGiuLai1.Location = new System.Drawing.Point(0, 0);
            this.ucBuuGuiGiuLai1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucBuuGuiGiuLai1.Name = "ucBuuGuiGiuLai1";
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
            this.ucBuuGuiGiuLai1.PHBT = sp_tblPhanBuuTa_DanhSach_THopResult1;
            this.ucBuuGuiGiuLai1.Size = new System.Drawing.Size(1218, 548);
            this.ucBuuGuiGiuLai1.TabIndex = 0;
            this.ucBuuGuiGiuLai1.Hien += new daoTienThuCOD.ThanhPhanGiaoDien.ucBuuGuiGiuLai.HienThiHandler(this.ucBuuGuiGiuLai1_Hien);
            this.ucBuuGuiGiuLai1.HienXong += new daoTienThuCOD.ThanhPhanGiaoDien.ucBuuGuiGiuLai.HienThiXongHandler(this.ucBuuGuiGiuLai1_HienXong);
            // 
            // frmBuuGuiGiuLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 548);
            this.Controls.Add(this.ucBuuGuiGiuLai1);
            this.Name = "frmBuuGuiGiuLai";
            this.Text = "frmBuuGuiGiuLai";
            this.ResumeLayout(false);

        }

        #endregion

        private ucBuuGuiGiuLai ucBuuGuiGiuLai1;
    }
}