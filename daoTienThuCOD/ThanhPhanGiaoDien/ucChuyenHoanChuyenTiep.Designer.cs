namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class ucChuyenHoanChuyenTiep
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnLayDuLieu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdChuyenTiep1 = new daoTienThuCOD.ThanhPhanGiaoDien.grdChuyenHoanChuyenTiep();
            this.grdChuyenHoan1 = new daoTienThuCOD.ThanhPhanGiaoDien.grdChuyenHoanChuyenTiep();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.pgb);
            this.groupBox1.Controls.Add(this.btnLayDuLieu);
            this.groupBox1.Controls.Add(this.btnHienThi);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1256, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày :";
            // 
            // txtNgay
            // 
            this.txtNgay.CustomFormat = "dd/MM/yyyy";
            this.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgay.Location = new System.Drawing.Point(104, 22);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(130, 26);
            this.txtNgay.TabIndex = 1;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(324, 20);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(144, 35);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnLayDuLieu
            // 
            this.btnLayDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayDuLieu.Location = new System.Drawing.Point(496, 19);
            this.btnLayDuLieu.Name = "btnLayDuLieu";
            this.btnLayDuLieu.Size = new System.Drawing.Size(144, 35);
            this.btnLayDuLieu.TabIndex = 3;
            this.btnLayDuLieu.Text = "Lấy dữ liệu";
            this.btnLayDuLieu.UseVisualStyleBackColor = true;
            this.btnLayDuLieu.Click += new System.EventHandler(this.btnLayDuLieu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdChuyenHoan1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1248, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bưu gửi Chuyển hoàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdChuyenTiep1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1248, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bưu gửi Chuyển tiếp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdChuyenTiep1
            // 
            this.grdChuyenTiep1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChuyenTiep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdChuyenTiep1.Location = new System.Drawing.Point(3, 3);
            this.grdChuyenTiep1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdChuyenTiep1.Name = "grdChuyenTiep1";
            this.grdChuyenTiep1.Size = new System.Drawing.Size(1242, 441);
            this.grdChuyenTiep1.TabIndex = 0;
            // 
            // grdChuyenHoan1
            // 
            this.grdChuyenHoan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChuyenHoan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdChuyenHoan1.Location = new System.Drawing.Point(3, 3);
            this.grdChuyenHoan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdChuyenHoan1.Name = "grdChuyenHoan1";
            this.grdChuyenHoan1.Size = new System.Drawing.Size(1242, 441);
            this.grdChuyenHoan1.TabIndex = 0;
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(710, 25);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(510, 20);
            this.pgb.TabIndex = 4;
            this.pgb.Visible = false;
            // 
            // ucChuyenHoanChuyenTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucChuyenHoanChuyenTiep";
            this.Size = new System.Drawing.Size(1256, 554);
            this.Resize += new System.EventHandler(this.ucChuyenHoanChuyenTiep_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLayDuLieu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private grdChuyenHoanChuyenTiep grdChuyenHoan1;
        private grdChuyenHoanChuyenTiep grdChuyenTiep1;
        private System.Windows.Forms.ProgressBar pgb;
    }
}
