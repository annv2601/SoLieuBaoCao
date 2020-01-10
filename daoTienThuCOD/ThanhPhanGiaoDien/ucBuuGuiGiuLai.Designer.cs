namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class ucBuuGuiGiuLai
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.MaBuuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBuuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVach = new System.Windows.Forms.DataGridViewImageColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailTripNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostBagNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendingContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaPhat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DaChuyenHoan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBuuTa,
            this.TenBuuTa,
            this.ItemCode,
            this.STT,
            this.MaVach,
            this.Weight,
            this.Value,
            this.MailTripNumber,
            this.PostBagNumber,
            this.IncomingDate,
            this.SendingContent,
            this.ReceiverFullname,
            this.ReceiverAddress,
            this.ReceiverTel,
            this.DaPhat,
            this.DaChuyenHoan});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1050, 664);
            this.dgv.TabIndex = 1;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseMove);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnInBaoCao.Location = new System.Drawing.Point(261, 52);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(156, 48);
            this.btnInBaoCao.TabIndex = 10;
            this.btnInBaoCao.Text = "In Báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Visible = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(38, 52);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(156, 48);
            this.btnXuatExcel.TabIndex = 9;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Visible = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // MaBuuTa
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MaBuuTa.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaBuuTa.HeaderText = "Mã Bưu tá";
            this.MaBuuTa.Name = "MaBuuTa";
            this.MaBuuTa.ReadOnly = true;
            this.MaBuuTa.Width = 120;
            // 
            // TenBuuTa
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenBuuTa.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenBuuTa.HeaderText = "Tên bưu tá";
            this.TenBuuTa.Name = "TenBuuTa";
            this.TenBuuTa.ReadOnly = true;
            this.TenBuuTa.Width = 220;
            // 
            // ItemCode
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Olive;
            this.ItemCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemCode.HeaderText = "Số hiệu";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 220;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            // 
            // MaVach
            // 
            this.MaVach.HeaderText = "Mã vạch";
            this.MaVach.Name = "MaVach";
            this.MaVach.ReadOnly = true;
            this.MaVach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaVach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaVach.Width = 200;
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
            // Value
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Value.DefaultCellStyle = dataGridViewCellStyle5;
            this.Value.HeaderText = "Số tiền COD";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 150;
            // 
            // MailTripNumber
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MailTripNumber.DefaultCellStyle = dataGridViewCellStyle6;
            this.MailTripNumber.HeaderText = "Số CT";
            this.MailTripNumber.Name = "MailTripNumber";
            this.MailTripNumber.ReadOnly = true;
            // 
            // PostBagNumber
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PostBagNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.PostBagNumber.HeaderText = "Số túi";
            this.PostBagNumber.Name = "PostBagNumber";
            this.PostBagNumber.ReadOnly = true;
            // 
            // IncomingDate
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "dd/MM/yyyy HH:mm:ss";
            this.IncomingDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.IncomingDate.HeaderText = "Ngày đến";
            this.IncomingDate.Name = "IncomingDate";
            this.IncomingDate.ReadOnly = true;
            this.IncomingDate.Width = 180;
            // 
            // SendingContent
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SendingContent.DefaultCellStyle = dataGridViewCellStyle9;
            this.SendingContent.HeaderText = "Nội dung";
            this.SendingContent.Name = "SendingContent";
            this.SendingContent.ReadOnly = true;
            this.SendingContent.Width = 300;
            // 
            // ReceiverFullname
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverFullname.DefaultCellStyle = dataGridViewCellStyle10;
            this.ReceiverFullname.HeaderText = "Tên người nhận";
            this.ReceiverFullname.Name = "ReceiverFullname";
            this.ReceiverFullname.ReadOnly = true;
            this.ReceiverFullname.Width = 200;
            // 
            // ReceiverAddress
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverAddress.DefaultCellStyle = dataGridViewCellStyle11;
            this.ReceiverAddress.HeaderText = "Địa chỉ người nhận";
            this.ReceiverAddress.Name = "ReceiverAddress";
            this.ReceiverAddress.ReadOnly = true;
            this.ReceiverAddress.Width = 300;
            // 
            // ReceiverTel
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverTel.DefaultCellStyle = dataGridViewCellStyle12;
            this.ReceiverTel.HeaderText = "Điện thoại người nhận";
            this.ReceiverTel.Name = "ReceiverTel";
            this.ReceiverTel.ReadOnly = true;
            this.ReceiverTel.Width = 150;
            // 
            // DaPhat
            // 
            this.DaPhat.HeaderText = "Đã phát";
            this.DaPhat.Name = "DaPhat";
            this.DaPhat.ReadOnly = true;
            this.DaPhat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DaPhat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DaChuyenHoan
            // 
            this.DaChuyenHoan.HeaderText = "Đã chuyển hoàn";
            this.DaChuyenHoan.Name = "DaChuyenHoan";
            this.DaChuyenHoan.ReadOnly = true;
            // 
            // ucBuuGuiGiuLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucBuuGuiGiuLai";
            this.Size = new System.Drawing.Size(1050, 664);
            this.Resize += new System.EventHandler(this.ucBuuGuiDenPhat_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBuuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBuuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewImageColumn MaVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailTripNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostBagNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendingContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverTel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaPhat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaChuyenHoan;
    }
}
