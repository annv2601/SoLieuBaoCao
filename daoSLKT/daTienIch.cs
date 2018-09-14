using System;
using System.Collections.Generic;
using System.Reflection;
using System.Data;

namespace daoSLKT
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
    }
}
