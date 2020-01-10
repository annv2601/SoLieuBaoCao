namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class ucBuuGuiDenPhat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVach = new System.Windows.Forms.DataGridViewImageColumn();
            this.FromPOSCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailTripNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostBagNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendingContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaPhat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DaChuyenHoan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DaHuy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
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
            this.FromPOSCode,
            this.MailTripNumber,
            this.PostBagNumber,
            this.IncomingDate,
            this.Weight,
            this.Value,
            this.SendingContent,
            this.ReceiverFullname,
            this.ReceiverAddress,
            this.ReceiverTel,
            this.DaPhat,
            this.DaChuyenHoan,
            this.DaHuy,
            this.STT});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1050, 664);
            this.dgv.TabIndex = 1;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseMove);
            // 
            // ItemCode
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Maroon;
            this.ItemCode.DefaultCellStyle = dataGridViewCellStyle34;
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
            // FromPOSCode
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FromPOSCode.DefaultCellStyle = dataGridViewCellStyle35;
            this.FromPOSCode.HeaderText = "BC đóng";
            this.FromPOSCode.Name = "FromPOSCode";
            this.FromPOSCode.ReadOnly = true;
            // 
            // MailTripNumber
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MailTripNumber.DefaultCellStyle = dataGridViewCellStyle36;
            this.MailTripNumber.HeaderText = "Số CT";
            this.MailTripNumber.Name = "MailTripNumber";
            this.MailTripNumber.ReadOnly = true;
            this.MailTripNumber.Width = 80;
            // 
            // PostBagNumber
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PostBagNumber.DefaultCellStyle = dataGridViewCellStyle37;
            this.PostBagNumber.HeaderText = "Số túi";
            this.PostBagNumber.Name = "PostBagNumber";
            this.PostBagNumber.ReadOnly = true;
            this.PostBagNumber.Width = 60;
            // 
            // IncomingDate
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Format = "dd/MM/yyyy HH:mm:ss";
            this.IncomingDate.DefaultCellStyle = dataGridViewCellStyle38;
            this.IncomingDate.HeaderText = "Ngày đến";
            this.IncomingDate.Name = "IncomingDate";
            this.IncomingDate.ReadOnly = true;
            this.IncomingDate.Width = 200;
            // 
            // Weight
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Weight.DefaultCellStyle = dataGridViewCellStyle39;
            this.Weight.HeaderText = "Trọng lượng";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 120;
            // 
            // Value
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Value.DefaultCellStyle = dataGridViewCellStyle40;
            this.Value.HeaderText = "Số tiền COD";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 150;
            // 
            // SendingContent
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SendingContent.DefaultCellStyle = dataGridViewCellStyle41;
            this.SendingContent.HeaderText = "Nội dung";
            this.SendingContent.Name = "SendingContent";
            this.SendingContent.ReadOnly = true;
            this.SendingContent.Width = 300;
            // 
            // ReceiverFullname
            // 
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverFullname.DefaultCellStyle = dataGridViewCellStyle42;
            this.ReceiverFullname.HeaderText = "Tên người nhận";
            this.ReceiverFullname.Name = "ReceiverFullname";
            this.ReceiverFullname.ReadOnly = true;
            this.ReceiverFullname.Width = 200;
            // 
            // ReceiverAddress
            // 
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverAddress.DefaultCellStyle = dataGridViewCellStyle43;
            this.ReceiverAddress.HeaderText = "Địa chỉ người nhận";
            this.ReceiverAddress.Name = "ReceiverAddress";
            this.ReceiverAddress.ReadOnly = true;
            this.ReceiverAddress.Width = 300;
            // 
            // ReceiverTel
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceiverTel.DefaultCellStyle = dataGridViewCellStyle44;
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
            // DaHuy
            // 
            this.DaHuy.HeaderText = "Đã hủy";
            this.DaHuy.Name = "DaHuy";
            this.DaHuy.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnInBaoCao.Location = new System.Drawing.Point(270, 52);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(156, 48);
            this.btnInBaoCao.TabIndex = 6;
            this.btnInBaoCao.Text = "In Báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Visible = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(47, 52);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(156, 48);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Visible = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // ucBuuGuiDenPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucBuuGuiDenPhat";
            this.Size = new System.Drawing.Size(1050, 664);
            this.Resize += new System.EventHandler(this.ucBuuGuiDenPhat_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewImageColumn MaVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromPOSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailTripNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostBagNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendingContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverTel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaPhat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaChuyenHoan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}
