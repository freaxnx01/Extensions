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
        public void CombineTest()
        {
            var baseUri = new Uri("https://web.freaxnx01.ch/movies");

            var result = baseUri.Combine("all.html").AbsoluteUri;
            Assert.Equal("https://web.freaxnx01.ch/movies/all.html", result);
            
            result = baseUri.Combine("https://web.freaxnx01.ch/movies/already-absolute.html").AbsoluteUri;
            Assert.Equal("https://web.freaxnx01.ch/movies/already-absolute.html", result);
        }
        
        [Fact]
        public void IsAbsoluteTrueTest()
        {
            Assert.True("https://web.freaxnx01.ch/movies".IsAbsolute());
        }

        [Fact]
        public void IsAbsoluteTrueFalse()
        {
            Assert.False("all.html".IsAbsolute());
        }
        
        [Fact]
        public void GetHtmlDocumentTest()
        {
            var result = new Uri("https://kernel.org").GetHtmlDocument();
            Assert.True(result.DocumentNode != null);
        }
    }
}