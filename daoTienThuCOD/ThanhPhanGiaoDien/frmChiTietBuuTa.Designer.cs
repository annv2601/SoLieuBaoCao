namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class frmChiTietBuuTa
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
            this.ucPhanHuongBuuTa1 = new daoTienThuCOD.ThanhPhanGiaoDien.ucPhanHuongBuuTa();
            this.SuspendLayout();
            // 
            // ucPhanHuongBuuTa1
            // 
            this.ucPhanHuongBuuTa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPhanHuongBuuTa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPhanHuongBuuTa1.Location = new System.Drawing.Point(0, 0);
            this.ucPhanHuongBuuTa1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPhanHuongBuuTa1.Name = "ucPhanHuongBuuTa1";
            /*sp_tblPhanBuuTa_DanhSach_THopResult1.Ca = null;
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
            sp_tblPhanBuuTa_DanhSach_THopResult1.WeightConvert = null;*/
            this.ucPhanHuongBuuTa1.PHBT = null;
            this.ucPhanHuongBuuTa1.Size = new System.Drawing.Size(1467, 831);
            this.ucPhanHuongBuuTa1.TabIndex = 0;
            // 
            // frmChiTietBuuTa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.ucPhanHuongBuuTa1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmChiTietBuuTa";
            this.Text = "frmChiTietBuuTa";
            this.ResumeLayout(false);

        }

        #endregion

        private ucPhanHuongBuuTa ucPhanHuongBuuTa1;
    }
}