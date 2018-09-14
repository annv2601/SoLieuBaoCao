namespace LaySoLieu.HeThong
{
    partial class frmThamSoCauHinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cboThamSo = new System.Windows.Forms.ComboBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tham số :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá trị :";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(185, 206);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(124, 41);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(371, 206);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(124, 41);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cboThamSo
            // 
            this.cboThamSo.FormattingEnabled = true;
            this.cboThamSo.Location = new System.Drawing.Point(152, 28);
            this.cboThamSo.Name = "cboThamSo";
            this.cboThamSo.Size = new System.Drawing.Size(434, 32);
            this.cboThamSo.TabIndex = 4;
            this.cboThamSo.SelectedValueChanged += new System.EventHandler(this.cboThamSo_SelectedValueChanged);
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(152, 87);
            this.txtGiaTri.Multiline = true;
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(434, 92);
            this.txtGiaTri.TabIndex = 5;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(593, 87);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(36, 34);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = "...";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // frmThamSoCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 259);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.cboThamSo);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmThamSoCauHinh";
            this.Text = "Tham số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboThamSo;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}