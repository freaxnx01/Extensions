using System;
using System.IO;
using System.Reflection;
using freaxnx01.Extensions;
using Xunit;

namespace Extensions.Test
{
    public class Tests
    {
        [Fact]
        public void AssemblyDirectoryTest()
        {
            var result = Assembly.GetExecutingAssembly().AssemblyDirectory();
            Assert.True(Directory.Exists(result));
        }
    }
}