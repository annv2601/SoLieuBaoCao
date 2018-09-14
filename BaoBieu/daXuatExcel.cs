﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;


namespace BaoBieu
{
    public class daXuatExcel
    {
        #region "Thuoc tinh"
        private const string DuongDanLuuFile = "DataFile";

        private string _TenFileExcel;
        public string TenFileExcel
        {
            get { return _TenFileExcel; }
            set { _TenFileExcel = value; }
        }

        private string _TenFileMau;
        public string TenFileMau
        {
            get { return _TenFileMau; }
            set { _TenFileMau = value; }
        }

        private string _DuongDan;
        public string DuongDan
        {
            get { return _DuongDan; }
            set { _DuongDan = value; }
        }

        private DataTable _DuLieu;
        public DataTable DuLieu
        {
            get { return _DuLieu; }
            set { _DuLieu = value; }
        }

        private DataSet _DuLieuNhieu;
        public DataSet DuLieuNhieu
        {
            get { return _DuLieuNhieu; }
            set { _DuLieuNhieu = value; }
        }

        private DataTable _DuLieuTong;
        public DataTable DuLieuTong
        {
            get { return _DuLieuTong; }
            set { _DuLieuTong = value; }
        }
        #endregion

        public bool IsNumeric(DataColumn col)
        {
            if (col == null)
                return false;
            // Make this const
            var numericTypes = new[] { typeof(Byte), typeof(System.Decimal), typeof(Double),
        typeof(Int16), typeof(Int32), typeof(Int64), typeof(SByte),
        typeof(Single), typeof(UInt16), typeof(UInt32), typeof(UInt64)};
            return numericTypes.Contains(col.DataType);
        }

        private string KiemTraTonTaiFile()
        {
            DirectoryInfo di = new DirectoryInfo(DuongDan + "\\" + DuongDanLuuFile);
            if (!di.Exists)
            {
                di.Create();
            }
            FileInfo fi = new FileInfo(DuongDan + "\\" + DuongDanLuuFile + "\\" + TenFileExcel);
            if (fi.Exists)
            {
                fi.Delete();
            }
            return fi.FullName;
        }

        public string XuatFileExcel_TheoMau()
        {
            HSSFWorkbook wb;
            HSSFSheet sh;


            using (var fs = new FileStream(TenFileMau, FileMode.Open, FileAccess.Read))
            {
                wb = new HSSFWorkbook(fs);
            }

            sh = (HSSFSheet)wb.GetSheet("Sheet1");

            //Day dong ky xuong cuoi cung
            int _DongCuoi = sh.LastRowNum;
            //============================
            int j;
            DateTime _Ngay;
            for (int i = 0; i < DuLieu.Rows.Count; i++)
            {
                IRow row;
                if (sh.GetRow(_DongCuoi + i - 1) == null)
                {
                    row = sh.CreateRow(_DongCuoi + i - 1);
                }

                sh.CopyRow(_DongCuoi + i - 1, _DongCuoi + i);

                row = sh.GetRow(_DongCuoi + i - 1);

                for (j = 0; j < DuLieu.Columns.Count; j++)
                {
                    if (row.GetCell(j) == null)
                        row.CreateCell(j);

                    if (IsNumeric(DuLieu.Columns[j]))
                    {
                        row.GetCell(j).SetCellValue(Convert.ToDouble(DuLieu.Rows[i][j] == DBNull.Value ? 0 : DuLieu.Rows[i][j]));
                    }
                    else
                    {
                        if (DuLieu.Rows[i][j].ToString().Length >= 8 && DateTime.TryParse(DuLieu.Rows[i][j].ToString(), out _Ngay))
                        {
                            row.GetCell(j).SetCellValue(Convert.ToDateTime(DuLieu.Rows[i][j]).ToString("dd/MM/yyyy"));
                        }
                        else
                        {
                            row.GetCell(j).SetCellValue(DuLieu.Rows[i][j].ToString());
                        }
                    }
                }
            }

            string _TenFileServer;
            _TenFileServer = KiemTraTonTaiFile();
            using (var fs = new FileStream(_TenFileServer, FileMode.Create, FileAccess.Write))
            {
                wb.Write(fs);
            }
            return "/" + DuongDanLuuFile + "/" + TenFileExcel;
        }
    }
}
