using System;
using System.IO;
using freaxnx01.Extensions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Extensions.Test
{
    public class StringPathExtensionTests
    {
        [Fact]
        public void ShellExecuteTest()
        {
            Assert.Throws<FileNotFoundException>(() => new Guid().ToString().ShellExecute());
        }
    }
}