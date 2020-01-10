namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    partial class ucLoaiTien
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
            this.lblLoaiTien = new System.Windows.Forms.Label();
            this.txtSoTo = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoaiTien
            // 
            this.lblLoaiTien.Location = new System.Drawing.Point(4, 4);
            this.lblLoaiTien.Name = "lblLoaiTien";
            this.lblLoaiTien.Size = new System.Drawing.Size(217, 32);
            this.lblLoaiTien.TabIndex = 0;
            this.lblLoaiTien.Text = "label1";
            this.lblLoaiTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoTo
            // 
            this.txtSoTo.BackColor = System.Drawing.Color.Turquoise;
            this.txtSoTo.Location = new System.Drawing.Point(227, 3);
            this.txtSoTo.Multiline = true;
            this.txtSoTo.Name = "txtSoTo";
            this.txtSoTo.Size = new System.Drawing.Size(241, 30);
            this.txtSoTo.TabIndex = 1;
            this.txtSoTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTo.Enter += new System.EventHandler(this.txtSoTo_Enter);
            this.txtSoTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTo_KeyPress);
            this.txtSoTo.Leave += new System.EventHandler(this.txtSoTo_Leave);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(474, 4);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(253, 29);
            this.lblThanhTien.TabIndex = 2;
            this.lblThanhTien.Text = "label2";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucLoaiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtSoTo);
            this.Controls.Add(this.lblLoaiTien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucLoaiTien";
            this.Size = new System.Drawing.Size(1023, 36);
            this.Resize += new System.EventHandler(this.ucLoaiTien_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoaiTien;
        private System.Windows.Forms.TextBox txtSoTo;
        private System.Windows.Forms.Label lblThanhTien;
    }
}
