using freaxnx01.Extensions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Extensions.Test
{
    public class ObjectExtensionTests
    {
        [Fact]
        public void SerializeToJsonObjectTest()
        {
            var theObject = this.GetType().FullName;
            var json = theObject.SerializeToJson();
            Assert.NotNull(JToken.Parse(json));
        }
        
        [Fact]
        public void SerializeToJsonDataTableTest()
        {
            var dataTable = HtmlAgilityExtensionTests.GetHtmlDoc().SelectSingleNode("//table").ToDataTable();
            var jsonDataTable = dataTable.SerializeToJson();
            Assert.NotNull(JToken.Parse(jsonDataTable));
        }
        
    }
}