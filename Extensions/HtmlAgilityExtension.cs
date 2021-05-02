using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace freaxnx01.Extensions
{
    public static class HtmlAgilityExtension
    {
        public static HtmlNode SelectSingleNode(this HtmlDocument htmlDocument, string xpath)
        {
            return htmlDocument.DocumentNode.SelectSingleNode(xpath);
        }
        
        public static DataTable ToDataTable(this HtmlNode htmlNode)
        {
            var table = new DataTable();
            
            // Header
            var headers = htmlNode.SelectNodes("tr/th");
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    table.Columns.Add(HttpUtility.HtmlDecode(header.InnerText).Trim());
                }
            }

            var rowList = new List<object>();
            var maxColumns = 0;
            
            // Rows
            foreach (var row in htmlNode.SelectNodes("tr[td]"))
            {
                var values = row.SelectNodes("td").Select(td => HttpUtility.HtmlDecode(td.InnerText).Trim()).ToArray();
                if (values.Length > maxColumns)
                {
                    maxColumns = values.Length;
                }
                rowList.Add(values);
            }
            
            // Columns
            if (table.Columns.Count == 0)
            {
                for (var c = 1; c <= maxColumns; c++)
                {
                    table.Columns.Add(string.Concat("Col", string.Format(c.ToString(), new string('0', (int)maxColumns.ToString().Length))));
                }
            }
 
            foreach (var row in rowList)
            {
                table.Rows.Add((string[])row);
            }

            return table;
        }
        
        public static DataTable ToDataTableSingleRow(this HtmlNode htmlNode)
        {
            var dataTableIn = ToDataTable(htmlNode);
            var dataTableOut = new DataTable();
            var values = new List<string>();

            foreach (DataRow rowIn in dataTableIn.Rows)
            {
                if (rowIn.ItemArray.Length == 2)
                {
                    dataTableOut.Columns.Add(rowIn.ItemArray[0].ToString());
                    values.Add(rowIn.ItemArray[1].ToString());
                }
            }
            
            dataTableOut.Rows.Add(values.ToArray());

            return dataTableOut;
        }
        
    }
}