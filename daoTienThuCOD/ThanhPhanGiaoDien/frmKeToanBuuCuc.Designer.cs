namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class frmKeToanBuuCuc
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
            daoTienThuCOD.daBase daBase1 = new daoTienThuCOD.daBase();
            this.cVuHoiBuuCuc = new daoTienThuCOD.ThanhPhanGiaoDien.ucKeToanBuuCuc();
            this.SuspendLayout();
            // 
            // cVuHoiBuuCuc
            // 
            this.cVuHoiBuuCuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cVuHoiBuuCuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cVuHoiBuuCuc.Location = new System.Drawing.Point(0, 0);
            this.cVuHoiBuuCuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cVuHoiBuuCuc.Name = "cVuHoiBuuCuc";
            this.cVuHoiBuuCuc.Size = new System.Drawing.Size(1370, 749);
            this.cVuHoiBuuCuc.TabIndex = 0;
            daBase1.Ca = ((short)(0));
            daBase1.DenNgay = new System.DateTime(((long)(0)));
            daBase1.MaBuuCuc = null;
            daBase1.MaBuuTa = null;
            daBase1.MaDonVi = null;
            daBase1.Nam = 0;
            daBase1.Ngay = new System.DateTime(((long)(0)));
            daBase1.Thang = ((short)(0));
            daBase1.TuNgay = new System.DateTime(((long)(0)));
            this.cVuHoiBuuCuc.ThamSo = daBase1;
            // 
            // frmKeToanBuuCuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.cVuHoiBuuCuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmKeToanBuuCuc";
            this.Text = "Vu hồi Bưu cục";
            this.ResumeLayout(false);

        }

        #endregion

        public ucKeToanBuuCuc cVuHoiBuuCuc;
    }
}