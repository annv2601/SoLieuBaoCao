namespace Test
{
    partial class frmSoNhatKy
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
            this.button1 = new System.Windows.Forms.Button();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLuuB0205 = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLuuB02KTNV = new System.Windows.Forms.Button();
            this.btnLuuChiPhi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu Sổ nhật ký chung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(12, 203);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(710, 23);
            this.pgb.TabIndex = 1;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(97, 62);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(154, 21);
            this.cbo.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Chọn File ...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(13, 13);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 4;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(174, 13);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(166, 20);
            this.txtNam.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLuuB0205
            // 
            this.btnLuuB0205.Location = new System.Drawing.Point(401, 56);
            this.btnLuuB0205.Name = "btnLuuB0205";
            this.btnLuuB0205.Size = new System.Drawing.Size(131, 44);
            this.btnLuuB0205.TabIndex = 7;
            this.btnLuuB0205.Text = "Lưu Doanh thu B02 - 05";
            this.btnLuuB0205.UseVisualStyleBackColor = true;
            this.btnLuuB0205.Click += new System.EventHandler(this.btnLuuB0205_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.Color.Green;
            this.lblThongTin.Location = new System.Drawing.Point(12, 141);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(710, 35);
            this.lblThongTin.TabIndex = 8;
            this.lblThongTin.Text = "label1";
            this.lblThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Lưu 1 File Doanh thu B02 - 05";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLuuB02KTNV
            // 
            this.btnLuuB02KTNV.Location = new System.Drawing.Point(402, 0);
            this.btnLuuB02KTNV.Name = "btnLuuB02KTNV";
            this.btnLuuB02KTNV.Size = new System.Drawing.Size(130, 46);
            this.btnLuuB02KTNV.TabIndex = 10;
            this.btnLuuB02KTNV.Text = "Lưu B02-KTNV";
            this.btnLuuB02KTNV.UseVisualStyleBackColor = true;
            this.btnLuuB02KTNV.Click += new System.EventHandler(this.btnLuuB02KTNV_Click);
            // 
            // btnLuuChiPhi
            // 
            this.btnLuuChiPhi.Location = new System.Drawing.Point(556, 0);
            this.btnLuuChiPhi.Name = "btnLuuChiPhi";
            this.btnLuuChiPhi.Size = new System.Drawing.Size(156, 46);
            this.btnLuuChiPhi.TabIndex = 11;
            this.btnLuuChiPhi.Text = "Lưu Chi phí";
            this.btnLuuChiPhi.UseVisualStyleBackColor = true;
            this.btnLuuChiPhi.Click += new System.EventHandler(this.btnLuuChiPhi_Click);
            // 
            // frmSoNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 296);
            this.Controls.Add(this.btnLuuChiPhi);
            this.Controls.Add(this.btnLuuB02KTNV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnLuuB0205);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.button1);
            this.Name = "frmSoNhatKy";
            this.Text = "frmSoNhatKy";
            this.Load += new System.EventHandler(this.frmSoNhatKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLuuB0205;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLuuB02KTNV;
        private System.Windows.Forms.Button btnLuuChiPhi;
    }
}