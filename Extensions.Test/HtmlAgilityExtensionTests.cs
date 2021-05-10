using System;
using System.IO;
using System.Reflection;
using freaxnx01.Extensions;
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
    }
}