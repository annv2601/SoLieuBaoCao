namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class grdChuyenHoanChuyenTiep
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVach = new System.Windows.Forms.DataGridViewImageColumn();
            this.NgayChuyenHoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienCOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongCuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.MaVach,
            this.NgayChuyenHoan,
            this.LyDo,
            this.Weight,
            this.SoTienCOD,
            this.ReceiverFullname,
            this.ReceiverAddress,
            this.ReceiverTel,
            this.TongCuoc,
            this.VAT,
            this.ThanhTien,
            this.STT});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1314, 576);
            this.dgv.TabIndex = 2;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseMove);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnInBaoCao.Location = new System.Drawing.Point(263, 51);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(156, 48);
            this.btnInBaoCao.TabIndex = 12;
            this.btnInBaoCao.Text = "In Báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Visible = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(40, 51);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(156, 48);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Visible = false;
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(263, 140);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(806, 23);
            this.pgb.TabIndex = 13;
            this.pgb.Visible = false;
            // 
            // ItemCode
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ItemCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemCode.HeaderText = "Số hiệu";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 220;
            // 
            // MaVach
            // 
            this.MaVach.HeaderText = "Mã vạch";
            this.MaVach.Name = "MaVach";
            this.MaVach.ReadOnly = true;
            this.MaVach.Width = 200;
            // 
            // NgayChuyenHoan
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm:ss";
            this.NgayChuyenHoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgayChuyenHoan.HeaderText = "Ngày chuyển";
            this.NgayChuyenHoan.Name = "NgayChuyenHoan";
            this.NgayChuyenHoan.ReadOnly = true;
            this.NgayChuyenHoan.Width = 180;
            // 
            // LyDo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LyDo.DefaultCellStyle = dataGridViewCellStyle3;
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            this.LyDo.Width = 400;
            // 
            // Weight
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Weight.DefaultCellStyle = dataGridViewCellStyle4;
            this.Weight.HeaderText = "Trọng lượng";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 120;
            // 
            // SoTienCOD
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SoTienCOD.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoTienCOD.HeaderText = "Số tiền COD";
            this.SoTienCOD.Name = "SoTienCOD";
            this.SoTienCOD.ReadOnly = true;
            this.SoTienCOD.Width = 150;
            // 
            // ReceiverFullname
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverFullname.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReceiverFullname.HeaderText = "Tên người nhận";
            this.ReceiverFullname.Name = "ReceiverFullname";
            this.ReceiverFullname.ReadOnly = true;
            this.ReceiverFullname.Width = 200;
            // 
            // ReceiverAddress
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverAddress.DefaultCellStyle = dataGridViewCellStyle7;
            this.ReceiverAddress.HeaderText = "Địa chỉ người nhận";
            this.ReceiverAddress.Name = "ReceiverAddress";
            this.ReceiverAddress.ReadOnly = true;
            this.ReceiverAddress.Width = 300;
            // 
            // ReceiverTel
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverTel.DefaultCellStyle = dataGridViewCellStyle8;
            this.ReceiverTel.HeaderText = "Điện thoại người nhận";
            this.ReceiverTel.Name = "ReceiverTel";
            this.ReceiverTel.ReadOnly = true;
            this.ReceiverTel.Width = 150;
            // 
            // TongCuoc
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "### ### ### ###";
            this.TongCuoc.DefaultCellStyle = dataGridViewCellStyle9;
            this.TongCuoc.HeaderText = "Tổng cước";
            this.TongCuoc.Name = "TongCuoc";
            this.TongCuoc.ReadOnly = true;
            this.TongCuoc.Width = 150;
            // 
            // VAT
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "### ### ###";
            this.VAT.DefaultCellStyle = dataGridViewCellStyle10;
            this.VAT.HeaderText = "VAT";
            this.VAT.Name = "VAT";
            this.VAT.ReadOnly = true;
            this.VAT.Width = 120;
            // 
            // ThanhTien
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "### ### ### ###";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle11;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 150;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            // 
            // grdChuyenHoanChuyenTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "grdChuyenHoanChuyenTiep";
            this.Size = new System.Drawing.Size(1314, 576);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewImageColumn MaVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChuyenHoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienCOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongCuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}
