using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace daoSLBC.Core
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

        public static DateTime NgayDauThang(DateTime rNgay)
        {
            DateTime _Na;
            _Na = DateTime.Parse(rNgay.Month.ToString() + "/01/" + rNgay.Year.ToString());
            return _Na;
        }

        public static DateTime NgayCuoiThang(DateTime rNgay)
        {
            DateTime _Na;
            _Na = NgayDauThang(rNgay);
            _Na = _Na.AddMonths(1);
            return _Na.AddDays(-1);
        }

        public static string LayBenPhai(string str, int SoKyTu)
        {
            return str.Substring(str.Length - SoKyTu, SoKyTu);
        }
    }
}
