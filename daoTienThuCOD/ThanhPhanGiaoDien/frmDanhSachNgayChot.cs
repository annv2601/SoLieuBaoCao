using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoTienThuCOD.Database;
using daoTienThuCOD.Khac;

namespace daoTienThuCOD.ThanhPhanGiaoDien
{
    public partial class frmDanhSachNgayChot : Form
    {
        public frmDanhSachNgayChot()
        {
            InitializeComponent();
        }

        public string MaBuuCuc;
        public List<sp_tblTrangThaiKeToan_DanhSachResult> lstNgayChot = new List<sp_tblTrangThaiKeToan_DanhSachResult>();

        public void HienThiDuLieu()
        {
            dgv.Rows.Clear();
            DataGridViewRow Dong;
            Button btn = new Button();
            for (int i = 0; i < lstNgayChot.Count; i++)
            {
                Dong = dgv.Rows[dgv.Rows.Add()];

                Dong.Cells["STT"].Value = i;
                Dong.Cells["Ngay"].Value = lstNgayChot[i].Ngay.Value.ToString("dd/MM/yyyy");
                Dong.Cells["ChotSoLieu"].Value = lstNgayChot[i].ChotSoLieu.Value;
                Dong.Cells["NgayChot"].Value = lstNgayChot[i].NgayChot.Value.ToString("dd/MM/yyyy HH:mm:ss");
                try
                {
                    Dong.Cells["NgayMo"].Value = lstNgayChot[i].NgayMo.Value.ToString("dd/MM/yyyy HH:mm:ss");
                }
                catch { }

                //DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                if (lstNgayChot[i].ChotSoLieu.Value)
                {
                    Dong.DefaultCellStyle.BackColor = Color.Green;
                    //buttonColumn.Text = "Mở";
                }
                else
                {
                    //buttonColumn.Text = "Chốt";
                    Dong.DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                //buttonColumn.UseColumnTextForButtonValue = true;

               // Dong.Cells["ChotMo"].Value = buttonColumn;

                // Add a CellClick handler to handle clicks in the button column.
                dgv.CellClick +=
                    new DataGridViewCellEventHandler(dgv_CellClick);

                //Dong.Cells["ChotMo"].Value = btn;

                Dong.Height = 25;
            }
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            System.Drawing.Font rowFont = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat);
                        
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int i;
            Button btn;
            btn = (Button)sender;
            i = Convert.ToInt32(btn.Tag);

            daTrangThaiKeToan dTT = new daTrangThaiKeToan();
            dTT.MaBuuCuc = MaBuuCuc;
            dTT.Ngay = lstNgayChot[i].Ngay.Value;
            if (dTT.LayNgayChot() != null || dTT.Ngay.Year == 2018)
            {
                if (dTT.NgayChot.Ngay.Value.AddDays(1).ToShortDateString() == dTT.Ngay.ToShortDateString())
                {
                    dTT.TThai.ChotSoLieu = !lstNgayChot[i].ChotSoLieu;
                    dTT.ChotMo();
                    //MessageBox.Show("Hoàn thành chốt số liệu ngày " + txtTuNgay.Value.ToString("dd/MM/yyyy"));
                }
                else
                {
                    MessageBox.Show("Số liệu đã được chốt vào ngày " + dTT.NgayChot.Ngay.Value.ToString("dd/MM/yyyy") + ". Anh/chị không thể chốt số liệu vào ngày " + dTT.Ngay.ToString("dd/MM/yyyy"));
                }
            }
            else
            {
                MessageBox.Show("Anh/chị chưa chốt số liệu ngày nào. Xin hãy liên hệ với quản trị!");
            }
        }

        void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dgv.Columns["ChotMo"].Index) return;

            // Retrieve the task ID.
            Int32 i = (Int32)dgv["STT", e.RowIndex].Value;
            daTrangThaiKeToan dTT = new daTrangThaiKeToan();
            dTT.MaBuuCuc = MaBuuCuc;
            dTT.Ngay = lstNgayChot[i].Ngay.Value;
            if (dTT.LayNgayChot() != null || dTT.Ngay.Year == 2018)
            {
                if (dTT.NgayChot.Ngay.Value <= dTT.Ngay)
                {
                    dTT.TThai.ChotSoLieu = !lstNgayChot[i].ChotSoLieu;
                    dTT.ChotMo();
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                    dgv.Rows[e.RowIndex].Cells["ChotSoLieu"].Value = false;
                }
                else
                {
                    MessageBox.Show("Số liệu đã được chốt vào ngày " + dTT.NgayChot.Ngay.Value.ToString("dd/MM/yyyy") + ". Anh/chị không thể chốt số liệu vào ngày " + dTT.Ngay.ToString("dd/MM/yyyy"));
                }
            }
            else
            {
                MessageBox.Show("Anh/chị chưa chốt số liệu ngày nào. Xin hãy liên hệ với quản trị!");
            }
        }
    }
}
