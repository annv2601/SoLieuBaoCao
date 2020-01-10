using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;


namespace DuLieuBCCP
{
    public class daDB
    {
        private SqlConnection KetNoi;
        private SqlCommand Chay = new SqlCommand();
        private SqlParameter ThamSo = new SqlParameter();
        private SqlDataAdapter DuLieu;
        private SqlDataReader DuLieuDoc;

        private string _IPMayChu;
        public string IPMayChu
        {
            get { return _IPMayChu; }
            set { _IPMayChu = value; }
        }

        private string _TenDatabase;
        public string TenDatabase
        {
            get { return _TenDatabase; }
            set { _TenDatabase = value; }
        }

        private string _TenKetNoi;
        public string TenKetNoi
        {
            get { return _TenKetNoi; }
            set { _TenKetNoi = value; }
        }

        private string _MatKhauKetNoi;
        public string MatKhauKetNoi
        {
            get { return _MatKhauKetNoi; }
            set { _MatKhauKetNoi = value; }
        }

        private string _ChuoiKetNoi;
        public string ChuoiKetNoi
        {
            get { return _ChuoiKetNoi; }
            set { _ChuoiKetNoi = value; }
        }

        public daDB()
        {
            //lay Ma Buu Cuc
            /*daCauHinh dCauHinh = new daCauHinh((int)daCauHinh.eTenFile.Cấu_Hình, true);
            
            dCauHinh.TenThamSo = daDanhMucThamSo.Mã_Bưu_Cục;
            //Lay tham so ket noi csdl EMS
            daMayChuDichVu dMayChu = new daMayChuDichVu();
            dMayChu.MayChuDV.SoHieuBuuCuc = dCauHinh.Doc();
            dMayChu.MayChuDV.IDLoaiDichVu = 5; //Dich vu EMS
            dMayChu.ThongTin();

            IPMayChu = dMayChu.MayChuDV.MayChu;
            TenDatabase = dMayChu.MayChuDV.CSDL;
            TenKetNoi = dMayChu.MayChuDV.UsrCSDL;
            MatKhauKetNoi = dMayChu.MayChuDV.PwdCSDL;

            TaoChuoiKetNoi();*/

        }

        public daDB(bool Cuoc)
        {
            //lay Ma Buu Cuc
            /*daCauHinh dCauHinh = new daCauHinh((int)daCauHinh.eTenFile.Cấu_Hình, true);
            dCauHinh.TenThamSo = daDanhMucThamSo.Bảng_Cước_Chung;

            if (dCauHinh.Doc() == "Có" && Cuoc)
            {
                IPMayChu = "10.10.200.159";
                TenDatabase = "BCCP";
                TenKetNoi = "khl";
                MatKhauKetNoi = "123";
            }
            else
            {
                dCauHinh.TenThamSo = daDanhMucThamSo.Mã_Bưu_Cục;
                //Lay tham so ket noi csdl EMS
                daMayChuDichVu dMayChu = new daMayChuDichVu();
                dMayChu.MayChuDV.SoHieuBuuCuc = dCauHinh.Doc();
                dMayChu.MayChuDV.IDLoaiDichVu = 5; //Dich vu EMS
                dMayChu.ThongTin();

                IPMayChu = dMayChu.MayChuDV.MayChu;
                TenDatabase = dMayChu.MayChuDV.CSDL;
                TenKetNoi = dMayChu.MayChuDV.UsrCSDL;
                MatKhauKetNoi = dMayChu.MayChuDV.PwdCSDL;
            }
            TaoChuoiKetNoi();*/
        }

        public void TaoChuoiKetNoi()
        {
            ChuoiKetNoi = "Server=" + IPMayChu + ";Database=" + TenDatabase + ";uid=" + TenKetNoi + ";pwd=" + MatKhauKetNoi + ";";
        }

        private void LayKetNoiBCCP(string rTenFileConfig)
        {
            ExeConfigurationFileMap FileCH = new ExeConfigurationFileMap();
            FileCH.ExeConfigFilename = rTenFileConfig+ "\\Ctin.Css.GUIManager.exe.config";
            Configuration config;
            config = ConfigurationManager.OpenMappedExeConfiguration(FileCH, ConfigurationUserLevel.None);
            string giatri = config.AppSettings.Settings["ConnectionString"].Value;
            ChuoiKetNoi = Ctin.Css.Configuration.TwoWayEncryptionHelpers.Decrypt(giatri);
        }

        public bool TaoKetNoi()
        {
            KetNoi = new SqlConnection();
            KetNoi.ConnectionString = ChuoiKetNoi;
            if (KetNoi.State != ConnectionState.Open)
            {
                try
                {
                    KetNoi.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool TaoKetNoi(string rFileConfig)
        {
            KetNoi = new SqlConnection();
            LayKetNoiBCCP(rFileConfig);
            KetNoi.ConnectionString = ChuoiKetNoi;
            if (KetNoi.State != ConnectionState.Open)
            {
                try
                {
                    KetNoi.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool TaoKetNoiTuConfig()
        {
            ChuoiKetNoi = System.Configuration.ConfigurationManager.ConnectionStrings["SoLieuTongHopConnectionString"].ConnectionString;
            KetNoi = new SqlConnection();
            KetNoi.ConnectionString = ChuoiKetNoi;
            if (KetNoi.State != ConnectionState.Open)
            {
                try
                {
                    KetNoi.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public DataSet ChayThuTuc(string TenThuTuc)
        {
            DataSet ds = new DataSet();
            Chay.CommandText = TenThuTuc;
            Chay.Connection = KetNoi;
            DuLieu = new SqlDataAdapter(Chay);
            DuLieu.Fill(ds);
            KetNoi.Close();
            return ds;
        }
        
        public int ChayThuTuc_Khong(string TenThuTuc)
        {
            DataSet ds = new DataSet();
            Chay.CommandText = TenThuTuc;
            Chay.Connection = KetNoi;
            return Chay.ExecuteNonQuery();            
        }
    }

}
