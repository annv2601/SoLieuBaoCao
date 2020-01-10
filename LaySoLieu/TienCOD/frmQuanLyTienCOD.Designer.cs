namespace LaySoLieu.TienCOD
{
    partial class frmQuanLyTienCOD
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnVuHoiBuuTa = new System.Windows.Forms.Button();
            this.btnBuuGuiDaThuTienCOD = new System.Windows.Forms.Button();
            this.btnBuuGuiChuyenHoan = new System.Windows.Forms.Button();
            this.btnPhanHuongBuuTa = new System.Windows.Forms.Button();
            this.btnBuuGuiDenPhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnVuHoiBuuTa);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuuGuiDaThuTienCOD);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuuGuiChuyenHoan);
            this.splitContainer1.Panel1.Controls.Add(this.btnPhanHuongBuuTa);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuuGuiDenPhat);
            this.splitContainer1.Size = new System.Drawing.Size(1467, 831);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(1385, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(70, 53);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnVuHoiBuuTa
            // 
            this.btnVuHoiBuuTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVuHoiBuuTa.Location = new System.Drawing.Point(857, 3);
            this.btnVuHoiBuuTa.Name = "btnVuHoiBuuTa";
            this.btnVuHoiBuuTa.Size = new System.Drawing.Size(193, 53);
            this.btnVuHoiBuuTa.TabIndex = 4;
            this.btnVuHoiBuuTa.Text = "Vu hồi Bưu tá";
            this.btnVuHoiBuuTa.UseVisualStyleBackColor = true;
            this.btnVuHoiBuuTa.Click += new System.EventHandler(this.btnVuHoiBuuTa_Click);
            // 
            // btnBuuGuiDaThuTienCOD
            // 
            this.btnBuuGuiDaThuTienCOD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuuGuiDaThuTienCOD.Location = new System.Drawing.Point(645, 3);
            this.btnBuuGuiDaThuTienCOD.Name = "btnBuuGuiDaThuTienCOD";
            this.btnBuuGuiDaThuTienCOD.Size = new System.Drawing.Size(193, 53);
            this.btnBuuGuiDaThuTienCOD.TabIndex = 3;
            this.btnBuuGuiDaThuTienCOD.Text = "BG đã thu tiền COD";
            this.btnBuuGuiDaThuTienCOD.UseVisualStyleBackColor = true;
            this.btnBuuGuiDaThuTienCOD.Click += new System.EventHandler(this.btnBuuGuiDaThuTienCOD_Click);
            // 
            // btnBuuGuiChuyenHoan
            // 
            this.btnBuuGuiChuyenHoan.ForeColor = System.Drawing.Color.Blue;
            this.btnBuuGuiChuyenHoan.Location = new System.Drawing.Point(434, 3);
            this.btnBuuGuiChuyenHoan.Name = "btnBuuGuiChuyenHoan";
            this.btnBuuGuiChuyenHoan.Size = new System.Drawing.Size(193, 53);
            this.btnBuuGuiChuyenHoan.TabIndex = 2;
            this.btnBuuGuiChuyenHoan.Text = "Bưu gửi Hoàn";
            this.btnBuuGuiChuyenHoan.UseVisualStyleBackColor = true;
            this.btnBuuGuiChuyenHoan.Click += new System.EventHandler(this.btnBuuGuiChuyenHoan_Click);
            // 
            // btnPhanHuongBuuTa
            // 
            this.btnPhanHuongBuuTa.ForeColor = System.Drawing.Color.Olive;
            this.btnPhanHuongBuuTa.Location = new System.Drawing.Point(223, 3);
            this.btnPhanHuongBuuTa.Name = "btnPhanHuongBuuTa";
            this.btnPhanHuongBuuTa.Size = new System.Drawing.Size(193, 53);
            this.btnPhanHuongBuuTa.TabIndex = 1;
            this.btnPhanHuongBuuTa.Text = "Phân hướng Bưu tá";
            this.btnPhanHuongBuuTa.UseVisualStyleBackColor = true;
            this.btnPhanHuongBuuTa.Click += new System.EventHandler(this.btnPhanHuongBuuTa_Click);
            // 
            // btnBuuGuiDenPhat
            // 
            this.btnBuuGuiDenPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuuGuiDenPhat.Location = new System.Drawing.Point(13, 3);
            this.btnBuuGuiDenPhat.Name = "btnBuuGuiDenPhat";
            this.btnBuuGuiDenPhat.Size = new System.Drawing.Size(193, 53);
            this.btnBuuGuiDenPhat.TabIndex = 0;
            this.btnBuuGuiDenPhat.Text = "Bưu gửi Đến phát";
            this.btnBuuGuiDenPhat.UseVisualStyleBackColor = true;
            this.btnBuuGuiDenPhat.Click += new System.EventHandler(this.btnBuuGuiDenPhat_Click);
            // 
            // frmQuanLyTienCOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmQuanLyTienCOD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tiền COD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyTienCOD_FormClosing);
            this.Resize += new System.EventHandler(this.frmQuanLyTienCOD_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnVuHoiBuuTa;
        private System.Windows.Forms.Button btnBuuGuiDaThuTienCOD;
        private System.Windows.Forms.Button btnBuuGuiChuyenHoan;
        private System.Windows.Forms.Button btnPhanHuongBuuTa;
        private System.Windows.Forms.Button btnBuuGuiDenPhat;
    }
}