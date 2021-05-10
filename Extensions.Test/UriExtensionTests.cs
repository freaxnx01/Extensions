using System;
using System.IO;
using System.Reflection;
using freaxnx01.Extensions;
using Xunit;

namespace Extensions.Test
{
    public class UriExtensionTests
    {
        [Fact]
        public void GetHtmlDocumentTest()
        {
            var result = new Uri("https://kernel.org").GetHtmlDocument();
            Assert.True(result.DocumentNode != null);
        }
    }
}