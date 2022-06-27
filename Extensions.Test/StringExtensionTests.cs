using System;
using System.IO;
using System.Reflection;
using freaxnx01.Extensions;
using Xunit;

namespace Extensions.Test
{
    public class StringExtensionTests
    {
        [Fact]
        public void IsNullOrEmptyTrueTest()
        {
            Assert.True(string.Empty.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmptyFalseTest()
        {
            Assert.False("LGTM".IsNullOrEmpty());
        }

        [Fact]
        public void PutInCharacterTest()
        {
            Assert.Equal("'Lorem ipsum'", "Lorem ipsum".PutInQuotes());
            Assert.Equal("\"Lorem ipsum\"", "Lorem ipsum".PutInDoubleQuotes());
            Assert.Equal("(Lorem ipsum)", "Lorem ipsum".PutInRoundBrackets());
            Assert.Equal("[Lorem ipsum]", "Lorem ipsum".PutInSquareBrackets());
            Assert.Equal("{Lorem ipsum}", "Lorem ipsum".PutInCurlyBrackets());
        }
    }
}