using System.Data;
using freaxnx01.Extensions;
using Xunit;

namespace Extensions.Test
{
    public class DataTableExtensionTests
    {
        [Fact]
        public void StringifyTest()
        {
            const string expected = "value1 value2";
            var result = GetDataTable().Stringify();
            Assert.Equal(result[0], expected);
        }
        
        #region Helpers
        
        private DataTable GetDataTable()
        {
            var dt = new DataTable(); 
            dt.Columns.Add("Col1");
            dt.Columns.Add("Col2");
            
            var theRow = dt.NewRow();
            theRow["Col1"] = "value1";
            theRow["Col2"] = "value2";
            dt.Rows.Add(theRow);

            return dt;
        }
        
        #endregion
    }
}