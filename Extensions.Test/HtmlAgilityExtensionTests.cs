using System;
using System.IO;
using System.Reflection;
using freaxnx01.Extensions;
using HtmlAgilityPack;
using Xunit;

namespace Extensions.Test
{
    public class HtmlAgilityExtensionTests
    {
        [Fact]
        public void TitleTest()
        {
            var result = new Uri("https://kernel.org").GetHtmlDocument().Title();
            Assert.True(!result.IsNullOrEmpty());
        }

        [Fact]
        public void SelectSingleNodeTest()
        {
            var result = GetHtmlDoc().SelectSingleNode("//table");
            Assert.True(result.Name == "table");
        }

        [Fact]
        public void ToDataTableTest()
        {
            var result = GetHtmlDoc().SelectSingleNode("//table").ToDataTable();
            var expected = 2;
            Assert.Equal(result.Rows.Count, expected);
        }

        [Fact]
        public void ToDataTableSingleRowTest()
        {
            var result = GetHtmlDoc().SelectSingleNode("//table").ToDataTableSingleRow();
            var expected = 1;
            Assert.Equal(result.Rows.Count, expected);
        }
        
        #region Helpers

        public static HtmlDocument GetHtmlDoc()
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc;
        }
    
        private const string html = 
@"<!DOCTYPE html>
<html>
<head>
<title>Page Title</title>
</head>
<body>
<h1>This is a Heading</h1>
<table>
<tr>
<th>Firstname</th>
<th>Lastname</th>
<th>Age</th>
</tr>
<tr>
<td>Jill</td>
<td>Smith</td>
<td>50</td>
</tr>
<tr>
<td>Eve</td>
<td>Jackson</td>
<td>94</td>
</tr>
</table>
</body>
</html>";
    
        #endregion
    }
}