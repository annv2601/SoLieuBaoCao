namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class frmChiTietSLDen
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
            daoTienThuCOD.Database.sp_tblSLDen_ThongTInResult sp_tblSLDen_ThongTInResult1 = new daoTienThuCOD.Database.sp_tblSLDen_ThongTInResult();
            daoTienThuCOD.daBase daBase1 = new daoTienThuCOD.daBase();
            this.ucBuuGuiDenPhat1 = new daoTienThuCOD.ThanhPhanGiaoDien.ucBuuGuiDenPhat();
            this.SuspendLayout();
            // 
            // ucBuuGuiDenPhat1
            // 
            sp_tblSLDen_ThongTInResult1.AcceptancePOSCode = null;
            sp_tblSLDen_ThongTInResult1.BatchCode = null;
            sp_tblSLDen_ThongTInResult1.Ca = null;
            sp_tblSLDen_ThongTInResult1.CustomerCode = null;
            sp_tblSLDen_ThongTInResult1.DaChuyenHoan = null;
            sp_tblSLDen_ThongTInResult1.DaHuy = null;
            sp_tblSLDen_ThongTInResult1.DaPhat = null;
            sp_tblSLDen_ThongTInResult1.FromPOSCode = null;
            sp_tblSLDen_ThongTInResult1.IncomingDate = null;
            sp_tblSLDen_ThongTInResult1.ItemCode = null;
            sp_tblSLDen_ThongTInResult1.LyDo = null;
            sp_tblSLDen_ThongTInResult1.MailTripNumber = null;
            sp_tblSLDen_ThongTInResult1.Ngay = null;
            sp_tblSLDen_ThongTInResult1.NgayHeThong = null;
            sp_tblSLDen_ThongTInResult1.NgayHuy = null;
            sp_tblSLDen_ThongTInResult1.PostBagNumber = null;
            sp_tblSLDen_ThongTInResult1.PostBagTypeCode = null;
            sp_tblSLDen_ThongTInResult1.ReceiverAddress = null;
            sp_tblSLDen_ThongTInResult1.ReceiverFullname = null;
            sp_tblSLDen_ThongTInResult1.ReceiverTel = null;
            sp_tblSLDen_ThongTInResult1.SenderAddress = null;
            sp_tblSLDen_ThongTInResult1.SenderFullname = null;
            sp_tblSLDen_ThongTInResult1.SenderTel = null;
            sp_tblSLDen_ThongTInResult1.SendingContent = null;
            sp_tblSLDen_ThongTInResult1.SendingTime = null;
            sp_tblSLDen_ThongTInResult1.ServiceCode = null;
            sp_tblSLDen_ThongTInResult1.ToPOSCode = null;
            sp_tblSLDen_ThongTInResult1.Value = null;
            sp_tblSLDen_ThongTInResult1.Weight = null;
            sp_tblSLDen_ThongTInResult1.WeightConvert = null;
            sp_tblSLDen_ThongTInResult1.Year = null;
            this.ucBuuGuiDenPhat1.BGThamSo = sp_tblSLDen_ThongTInResult1;
            this.ucBuuGuiDenPhat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBuuGuiDenPhat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBuuGuiDenPhat1.Location = new System.Drawing.Point(0, 0);
            this.ucBuuGuiDenPhat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucBuuGuiDenPhat1.Name = "ucBuuGuiDenPhat1";
            this.ucBuuGuiDenPhat1.Size = new System.Drawing.Size(1370, 749);
            this.ucBuuGuiDenPhat1.TabIndex = 0;
            daBase1.Ca = ((short)(0));
            daBase1.DenNgay = new System.DateTime(((long)(0)));
            daBase1.MaBuuCuc = null;
            daBase1.MaBuuTa = null;
            daBase1.MaDonVi = null;
            daBase1.Nam = 0;
            daBase1.Ngay = new System.DateTime(((long)(0)));
            daBase1.Thang = ((short)(0));
            daBase1.TuNgay = new System.DateTime(((long)(0)));
            this.ucBuuGuiDenPhat1.ThamSo = daBase1;
            // 
            // frmChiTietSLDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ucBuuGuiDenPhat1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmChiTietSLDen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết";
            this.ResumeLayout(false);

        }

        #endregion

        public ucBuuGuiDenPhat ucBuuGuiDenPhat1;
    }
}