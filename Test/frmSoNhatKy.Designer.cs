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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Luu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(13, 116);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(710, 23);
            this.pgb.TabIndex = 1;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(186, 62);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(154, 21);
            this.cbo.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
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
            this.button3.Location = new System.Drawing.Point(478, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmSoNhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 447);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.button1);
            this.Name = "frmSoNhatKy";
            this.Text = "frmSoNhatKy";
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
    }
}