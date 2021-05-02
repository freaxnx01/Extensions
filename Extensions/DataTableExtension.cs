using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace freaxnx01.Extensions
{
    public static class DataTableExtension
    {
        public static List<string> Stringify(this DataTable dataTable)
        {
            var lines = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                lines.Add(string.Join(" ", row.ItemArray.Where(s => s != DBNull.Value && !string.IsNullOrEmpty((string)s))));
            }

            return lines.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
        }
    }
}