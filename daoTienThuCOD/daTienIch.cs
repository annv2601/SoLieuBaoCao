using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace daoTienThuCOD
{
    public static class daTienIch
    {
        public static DataTable ToDataTable<TSource>(this IList<TSource> data)
        {
            DataTable dt = new DataTable(typeof(TSource).Name);
            PropertyInfo[] props = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (TSource item in data)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        public static DateTime CuoiNgay(DateTime Ngay)
        {
            string _ngay;
            _ngay = Ngay.ToString("MM/dd/yyyy") + " 23:59:00";
            return DateTime.Parse(_ngay);
        }

        public static DateTime DauNgay(DateTime Ngay)
        {
            string _ngay;
            _ngay = Ngay.ToString("MM/dd/yyyy") + " 00:00:00";
            return DateTime.Parse(_ngay);
        }

        public static DateTime NgayDauThang(Int16 Thang, int Nam)
        {
            return DateTime.Parse(Thang.ToString() + "/01/" + Nam.ToString());
        }

        public static DateTime NgayCuoiThang(Int16 Thang, int Nam)
        {
            DateTime _ngay;
            _ngay = DateTime.Parse(Thang.ToString() + "/01/" + Nam.ToString());
            _ngay = _ngay.AddMonths(1);
            return _ngay.AddDays(-1);
        }
    }
}
