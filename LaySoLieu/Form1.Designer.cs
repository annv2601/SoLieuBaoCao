namespace LaySoLieu
{
    partial class frmTheoDoi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheoDoi));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuitemThamSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemLayDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemLayDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuitemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrChay = new System.Windows.Forms.Timer(this.components);
            this.tmrChayHomTruoc = new System.Windows.Forms.Timer(this.components);
            this.tmrLayBCCP = new System.Windows.Forms.Timer(this.components);
            this.tmrThuGom1 = new System.Windows.Forms.Timer(this.components);
            this.tmrThuGom2 = new System.Windows.Forms.Timer(this.components);
            this.tmrThuGom3 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tmrChayPhat = new System.Windows.Forms.Timer(this.components);
            this.mnuitemSoLieuPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Lấy số liệu";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitemThamSo,
            this.mnuitemLayDanhMuc,
            this.mnuitemLayDuLieu,
            this.mnuitemSoLieuPhat,
            this.toolStripSeparator1,
            this.mnuitemThoat,
            this.testToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 188);
            // 
            // mnuitemThamSo
            // 
            this.mnuitemThamSo.Name = "mnuitemThamSo";
            this.mnuitemThamSo.Size = new System.Drawing.Size(186, 26);
            this.mnuitemThamSo.Text = "Tham số";
            this.mnuitemThamSo.Click += new System.EventHandler(this.mnuitemThamSo_Click);
            // 
            // mnuitemLayDanhMuc
            // 
            this.mnuitemLayDanhMuc.Name = "mnuitemLayDanhMuc";
            this.mnuitemLayDanhMuc.Size = new System.Drawing.Size(186, 26);
            this.mnuitemLayDanhMuc.Text = "Lấy danh mục";
            this.mnuitemLayDanhMuc.Click += new System.EventHandler(this.mnuitemLayDanhMuc_Click);
            // 
            // mnuitemLayDuLieu
            // 
            this.mnuitemLayDuLieu.Name = "mnuitemLayDuLieu";
            this.mnuitemLayDuLieu.Size = new System.Drawing.Size(186, 26);
            this.mnuitemLayDuLieu.Text = "Lấy dữ liệu";
            this.mnuitemLayDuLieu.Click += new System.EventHandler(this.mnuitemLayDuLieu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuitemThoat
            // 
            this.mnuitemThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuitemThoat.Name = "mnuitemThoat";
            this.mnuitemThoat.Size = new System.Drawing.Size(186, 26);
            this.mnuitemThoat.Text = "Thoát";
            this.mnuitemThoat.Click += new System.EventHandler(this.mnuitemThoat_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Visible = false;
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // btnLay
            // 
            this.btnLay.Location = new System.Drawing.Point(60, 12);
            this.btnLay.Name = "btnLay";
            this.btnLay.Size = new System.Drawing.Size(75, 23);
            this.btnLay.TabIndex = 1;
            this.btnLay.Text = "Lấy dữ liệu";
            this.btnLay.UseVisualStyleBackColor = true;
            this.btnLay.Visible = false;
            this.btnLay.Click += new System.EventHandler(this.btnLay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrChay
            // 
            this.tmrChay.Tick += new System.EventHandler(this.tmrChay_Tick);
            // 
            // tmrChayHomTruoc
            // 
            this.tmrChayHomTruoc.Interval = 30000;
            this.tmrChayHomTruoc.Tick += new System.EventHandler(this.tmrChayHomTruoc_Tick);
            // 
            // tmrLayBCCP
            // 
            this.tmrLayBCCP.Tick += new System.EventHandler(this.tmrLayBCCP_Tick);
            // 
            // tmrThuGom1
            // 
            this.tmrThuGom1.Tick += new System.EventHandler(this.tmrThuGom1_Tick);
            // 
            // tmrThuGom2
            // 
            this.tmrThuGom2.Tick += new System.EventHandler(this.tmrThuGom2_Tick);
            // 
            // tmrThuGom3
            // 
            this.tmrThuGom3.Tick += new System.EventHandler(this.tmrThuGom3_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 450);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // tmrChayPhat
            // 
            this.tmrChayPhat.Tick += new System.EventHandler(this.tmrChayPhat_Tick);
            // 
            // mnuitemSoLieuPhat
            // 
            this.mnuitemSoLieuPhat.Image = ((System.Drawing.Image)(resources.GetObject("mnuitemSoLieuPhat.Image")));
            this.mnuitemSoLieuPhat.Name = "mnuitemSoLieuPhat";
            this.mnuitemSoLieuPhat.Size = new System.Drawing.Size(186, 26);
            this.mnuitemSoLieuPhat.Text = "Số liệu Phát";
            this.mnuitemSoLieuPhat.Click += new System.EventHandler(this.mnuitemSoLieuPhat_Click);
            // 
            // frmTheoDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLay);
            this.Name = "frmTheoDoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTheoDoi_FormClosing);
            this.Load += new System.EventHandler(this.frmTheoDoi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuitemThoat;
        private System.Windows.Forms.Button btnLay;
        private System.Windows.Forms.ToolStripMenuItem mnuitemThamSo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrChay;
        private System.Windows.Forms.Timer tmrChayHomTruoc;
        private System.Windows.Forms.Timer tmrLayBCCP;
        private System.Windows.Forms.Timer tmrThuGom1;
        private System.Windows.Forms.Timer tmrThuGom2;
        private System.Windows.Forms.Timer tmrThuGom3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuitemLayDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuitemLayDuLieu;
        private System.Windows.Forms.Timer tmrChayPhat;
        private System.Windows.Forms.ToolStripMenuItem mnuitemSoLieuPhat;
    }
}

