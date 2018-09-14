namespace Test
{
    partial class Form1
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(13, 39);
            this.txtCT.Multiline = true;
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(743, 115);
            this.txtCT.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 161);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(743, 283);
            this.dgv.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 446);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCT);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
    }
}

