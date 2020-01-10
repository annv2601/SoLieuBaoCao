using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using daoSLCT.Data;
using daoSLCT.grdDuLieu;
using daoSLPH.DataClient;

namespace LaySoLieu
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        #region Khai bao
        private bool LoadForm;
        private grdTien bcTien = new grdTien();
        private grdDoanhThuBCCP bcBCCP = new grdDoanhThuBCCP();
        private grdTaiChinh bcTaiChinh = new grdTaiChinh();
        #endregion

        #region Rieng
        private void DanhSachBaoCaoChon()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Ten", typeof(string));

            dt.Rows.Add(1, "1. Báo cáo Kế toán");
            dt.Rows.Add(2, "2. Báo cáo Doanh thu Ghi nợ BCCP");
            dt.Rows.Add(3, "3. Báo cáo Doanh thu Tiền mặt BCCP");
            dt.Rows.Add(4, "4. Báo cáo Doanh thu Ghi nợ Khách hàng BCCP");
            dt.Rows.Add(5, "5. Báo cáo Doanh thu Paypost");

            listBox1.DisplayMember = "Ten";
            listBox1.ValueMember = "ID";
            listBox1.DataSource = dt;

            listBox1.SelectedIndex = -1;
        }
        #endregion
        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            //string _ChMa;
            //_ChMa = daMaHoa.Encrypt("Data Source=10.10.200.167; Initial Catalog=SoLieuChiTiet; User ID=LayDuLieu; Password=TuDong@SL*", true, "559C3067-A6AC-4E31-B96E-F4F3AE38B630");
        }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            daData dDTa = new daData();
            daCauHinh dCH = new daCauHinh();            

            dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
            if (dCH.CauHinh != null)
            {
                dDTa.MaBuuCuc = dCH.CauHinh.GiaTri;
            }
            else
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Tham số Mã Bưu cục chưa được khai báo");
                return;
            }

            dDTa.Ngay = txtNgay.Value;//DateTime.Now;

            dDTa.LayDuLieu();

            dDTa.TongHopDuLieu();

            Cursor = Cursors.Default;
            MessageBox.Show("Đã Tổng hợp dữ liệu ngày hôm nay thành công!");
        }

        private void frmBaoCao_Resize(object sender, EventArgs e)
        {
            listBox1.Height = this.Height - 2 * btnTongHop.Height;
            listBox1.Top = this.Top + btnTongHop.Top + 10;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            LoadForm = true;
            DanhSachBaoCaoChon();
            txtNgay.Value = DateTime.Now;
            LoadForm = false;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!LoadForm)
            {
                Cursor = Cursors.WaitCursor;
                daCauHinh dCH = new daCauHinh();
                DateTime _ngay = DateTime.Now;
                _ngay = txtNgay.Value;
                daData dDTa = new daData();
                dCH.Lay((int)daCauHinh.eCauHinh.Mã_Bưu_Cục);
                if (dCH.CauHinh != null)
                {
                    dDTa.MaBuuCuc = dCH.CauHinh.GiaTri;
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Tham số Mã Bưu cục chưa được khai báo");
                    return;
                }
                if (splitContainer1.Panel2.Controls.Count > 0)
                {
                    splitContainer1.Panel2.Controls.RemoveAt(0);
                }
                dDTa.DenNgay = _ngay;
                int _IDBaoCao = 0;
                try
                {
                    _IDBaoCao = (int)listBox1.SelectedValue;
                }
                catch
                {
                    MessageBox.Show("Xin hãy chọn vào một biểu báo cáo");
                    return;
                }

                switch (_IDBaoCao)
                {
                    case 1:
                        dDTa.TuNgay = DateTime.Parse(_ngay.Month.ToString() + "/01/" + _ngay.Year.ToString());                        
                        bcTien.lstTien = dDTa.lstTien();
                        bcTien.HienThiDuLieu();
                        bcTien.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(bcTien);                        
                        break;
                    case 2:
                        dDTa.TuNgay = _ngay;
                        bcBCCP.lstGN = dDTa.lstKinhDoanhGhiNo();
                        bcBCCP.HienThiDuLieuGhiNo();
                        bcBCCP.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(bcBCCP);
                        break;
                    case 3:
                        dDTa.TuNgay = _ngay;
                        bcBCCP.lstTM = dDTa.lstKinhDoanhTiemMat();
                        bcBCCP.HienThiDuLieuTienMat();
                        bcBCCP.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(bcBCCP);
                        break;
                    case 4:
                        dDTa.TuNgay = _ngay;
                        bcBCCP.lstKH = dDTa.lstKinhDoanhGhiNoKhachHang();
                        bcBCCP.HienThiDuLieuGhiNoKhachHang();
                        bcBCCP.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(bcBCCP);
                        break;
                    case 5:
                        dDTa.TuNgay = _ngay;
                        bcTaiChinh.lstTC = dDTa.lstTaiChinhTapChung();
                        bcTaiChinh.HienThiDuLieu();
                        bcTaiChinh.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(bcTaiChinh);
                        break;
                }

                Cursor = Cursors.Default;
            }
        }
    }
}
