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
    }
}