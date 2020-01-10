using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Drawing;
using System.Drawing.Printing;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public class daXuaBaoCao
    {
        public DataGridView grdDuLieu;

        private System.Drawing.Printing.PrintDocument printDocument1;


        #region Khai bao
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height

        public string mTieuDeBaoCao;

        public event XuatHandler Xuat;
        public delegate void XuatHandler(object sender, EventArgs e);
        public event XuatXongHandler XuatXong;
        public delegate void XuatXongHandler(object sender, EventArgs e);
        #endregion

        public daXuaBaoCao()
        {
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();

            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
        }

        #region Xuat excel
        public void XuatExcel()
        {
            if (grdDuLieu.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra file Excel");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "DuLieu.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XuatExcelChung(sfd.FileName);
                MessageBox.Show("Đã xuất ra file Excel " + sfd.FileName + " thành công!");

                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void XuatExcelChung(string TenFile)
        {
            HSSFWorkbook wb;
            HSSFSheet sh;
            wb = HSSFWorkbook.Create(InternalWorkbook.CreateWorkbook());

            // create sheet
            sh = (HSSFSheet)wb.CreateSheet(DateTime.Now.ToString("dd_MM_yyyy HH_mm_ss"));

            // Tieu De
            IFont font1 = wb.CreateFont();
            font1.Boldweight = 100;

            ICellStyle style = wb.CreateCellStyle();
            style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style.SetFont(font1);

            if (sh.GetRow(0) == null)
                sh.CreateRow(0);
            int j;
            int k = 0;
            for (j = 0; j < grdDuLieu.ColumnCount; j++)
            {
                if (grdDuLieu.Columns[j].Visible == true)
                {
                    if (sh.GetRow(0).GetCell(k) == null)
                        sh.GetRow(0).CreateCell(k);
                    sh.GetRow(0).GetCell(k).CellStyle = style;
                    sh.GetRow(0).GetCell(k).SetCellValue(grdDuLieu.Columns[j].HeaderText);
                    k = k + 1;
                }
            }

            //Du lieu
            Double GiaTri;
            string _gt;
            for (int i = 0; i < grdDuLieu.RowCount; i++)
            {
                sh.CreateRow(i + 1);
                k = 0;
                for (j = 0; j < grdDuLieu.ColumnCount; j++)
                {
                    if (grdDuLieu.Rows[i].Cells[j].Visible == true)
                    {
                        if (sh.GetRow(i + 1).GetCell(k) == null)
                            sh.GetRow(i + 1).CreateCell(k);

                        if (grdDuLieu.Rows[i].Cells[j].Value == null)
                        {
                            sh.GetRow(i + 1).GetCell(k).SetCellValue("");
                        }
                        else
                        {
                            _gt = grdDuLieu.Rows[i].Cells[j].Value.ToString();
                            _gt = _gt.Replace(".", "");
                            if (Double.TryParse(_gt, out GiaTri))
                            {
                                sh.GetRow(i + 1).GetCell(k).SetCellValue(GiaTri);
                            }
                            else
                            {
                                sh.GetRow(i + 1).GetCell(k).SetCellValue(_gt);                                
                            }
                        }
                        k = k + 1;
                    }
                }

                Xuat(i, null);
            }

            //Ghi ra file
            using (var fs = new FileStream(TenFile, FileMode.Create, FileAccess.Write))
            {
                wb.Write(fs);
            }

            XuatXong(null, null);
        }
        #endregion

        #region In bao cao
        public void InBaoCao()
        {
            bool flag = DialogResult.OK == new PrintDialog
            {
                Document = this.printDocument1,
                UseEXDialog = true
            }.ShowDialog();
            if (flag)
            {
                this.printDocument1.DocumentName = "In dữ liệu";
                this.printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                this.strFormat = new StringFormat();
                this.strFormat.Alignment = StringAlignment.Near;
                this.strFormat.LineAlignment = StringAlignment.Center;
                this.strFormat.Trimming = StringTrimming.EllipsisCharacter;
                this.arrColumnLefts.Clear();
                this.arrColumnWidths.Clear();
                this.iCellHeight = 0;
                this.iRow = 0;
                this.bFirstPage = true;
                this.bNewPage = true;
                this.iTotalWidth = 0;
                foreach (DataGridViewColumn dataGridViewColumn in this.grdDuLieu.Columns)
                {
                    this.iTotalWidth += dataGridViewColumn.Width;
                }
                /*switch (this.mBieu)
                {
                    case 0:
                        this.mTieuDeBaoCao = "BÁO CÁO CHI TRẢ THEO DANH SÁCH";
                        break;
                    case 2:
                        this.mTieuDeBaoCao = "BÁO CÁO TỔNG HỢP CHƯA TRẢ TIỀN THEO TỔ";
                        break;
                    case 4:
                        this.mTieuDeBaoCao = "BÁO CÁO TỔNG HỢP ĐÃ TRẢ TIỀN THEO TỔ";
                        break;
                    case 5:
                        this.mTieuDeBaoCao = "BÁO CÁO TÌNH HÌNH CHI TRẢ";
                        break;
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int num = e.MarginBounds.Left;
                int num2 = e.MarginBounds.Top;
                bool flag = false;
                bool flag2 = this.bFirstPage;
                if (flag2)
                {
                    foreach (DataGridViewColumn dataGridViewColumn in this.grdDuLieu.Columns)
                    {
                        int num3 = (int)Math.Floor((double)dataGridViewColumn.Width / (double)this.iTotalWidth * (double)this.iTotalWidth * ((double)e.MarginBounds.Width / (double)this.iTotalWidth));
                        this.iHeaderHeight = (int)e.Graphics.MeasureString(dataGridViewColumn.HeaderText, dataGridViewColumn.InheritedStyle.Font, num3).Height + 11;
                        this.arrColumnLefts.Add(num);
                        this.arrColumnWidths.Add(num3);
                        num += num3;
                    }
                    e.Graphics.DrawString(this.mTieuDeBaoCao, new Font(System.Drawing.FontFamily.GenericSansSerif, 18f, FontStyle.Bold), Brushes.Black, (float)(e.MarginBounds.Left + 20), (float)e.MarginBounds.Top - e.Graphics.MeasureString(this.mTieuDeBaoCao, new Font(System.Drawing.FontFamily.GenericSansSerif, 18f, FontStyle.Bold), e.MarginBounds.Width).Height - 13f);
                }
                while (this.iRow <= this.grdDuLieu.Rows.Count - 1)
                {
                    DataGridViewRow dataGridViewRow = this.grdDuLieu.Rows[this.iRow];
                    this.iCellHeight = dataGridViewRow.Height + 5;
                    int num4 = 0;
                    bool flag3 = num2 + this.iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top;
                    if (flag3)
                    {
                        this.bNewPage = true;
                        this.bFirstPage = false;
                        flag = true;
                        break;
                    }
                    bool flag4 = this.bNewPage;
                    if (flag4)
                    {
                        num2 = e.MarginBounds.Top;
                        foreach (DataGridViewColumn dataGridViewColumn2 in this.grdDuLieu.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int)this.arrColumnLefts[num4], num2, (int)this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)this.arrColumnLefts[num4], num2, (int)this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawString(dataGridViewColumn2.HeaderText, dataGridViewColumn2.InheritedStyle.Font, new SolidBrush(dataGridViewColumn2.InheritedStyle.ForeColor), new RectangleF((float)((int)this.arrColumnLefts[num4]), (float)num2, (float)((int)this.arrColumnWidths[num4]), (float)this.iHeaderHeight), this.strFormat);
                            num4++;
                        }
                        this.bNewPage = false;
                        num2 += this.iHeaderHeight;
                    }
                    num4 = 0;
                    foreach (DataGridViewCell dataGridViewCell in dataGridViewRow.Cells)
                    {
                        bool flag5 = dataGridViewCell.Value != null;
                        if (flag5)
                        {
                            decimal num5;
                            bool flag6 = decimal.TryParse(dataGridViewCell.Value.ToString(), out num5);
                            if (flag6)
                            {
                                e.Graphics.DrawString(num5.ToString("### ### ### ### ###"), dataGridViewCell.InheritedStyle.Font, new SolidBrush(dataGridViewCell.InheritedStyle.ForeColor), new RectangleF((float)((int)this.arrColumnLefts[num4]), (float)num2, (float)((int)this.arrColumnWidths[num4]), (float)this.iCellHeight), this.strFormat);
                            }
                            else
                            {
                                e.Graphics.DrawString(dataGridViewCell.Value.ToString(), dataGridViewCell.InheritedStyle.Font, new SolidBrush(dataGridViewCell.InheritedStyle.ForeColor), new RectangleF((float)((int)this.arrColumnLefts[num4]), (float)num2, (float)((int)this.arrColumnWidths[num4]), (float)this.iCellHeight), this.strFormat);
                            }
                        }
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)this.arrColumnLefts[num4], num2, (int)this.arrColumnWidths[num4], this.iCellHeight));
                        num4++;
                    }
                    this.iRow++;
                    num2 += this.iCellHeight;
                }
                bool flag7 = flag;
                if (flag7)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion
    }
}
