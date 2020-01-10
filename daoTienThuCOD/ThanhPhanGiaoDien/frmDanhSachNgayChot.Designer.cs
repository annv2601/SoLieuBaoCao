namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class frmDanhSachNgayChot
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChotSoLieu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgayChot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChotMo = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.Ngay,
            this.ChotSoLieu,
            this.NgayChot,
            this.NgayMo,
            this.ChotMo,
            this.STT});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(826, 736);
            this.dgv.TabIndex = 0;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 120;
            // 
            // ChotSoLieu
            // 
            this.ChotSoLieu.HeaderText = "Chốt";
            this.ChotSoLieu.Name = "ChotSoLieu";
            this.ChotSoLieu.ReadOnly = true;
            this.ChotSoLieu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChotSoLieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayChot
            // 
            this.NgayChot.HeaderText = "Ngày chốt";
            this.NgayChot.Name = "NgayChot";
            this.NgayChot.ReadOnly = true;
            this.NgayChot.Width = 200;
            // 
            // NgayMo
            // 
            this.NgayMo.HeaderText = "Ngày mở";
            this.NgayMo.Name = "NgayMo";
            this.NgayMo.ReadOnly = true;
            this.NgayMo.Width = 200;
            // 
            // ChotMo
            // 
            this.ChotMo.HeaderText = "Mở";
            this.ChotMo.Name = "ChotMo";
            this.ChotMo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChotMo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChotMo.Text = "Mở";
            this.ChotMo.Width = 160;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            // 
            // frmDanhSachNgayChot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 736);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDanhSachNgayChot";
            this.Text = "Danh sách ngày chốt";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChotSoLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChot;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMo;
        private System.Windows.Forms.DataGridViewButtonColumn ChotMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}