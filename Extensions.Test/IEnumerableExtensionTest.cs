using System.Linq;
using System.Collections.Generic;
using freaxnx01.Extensions;
using Xunit;

namespace Extensions.Test
{
    // ReSharper disable once InconsistentNaming
    public class IEnumerableExtensionTest
    {
        [Fact]
        public void SafeListHasElementTest()
        {
            var theList = new List<string>() { "text" };
            Assert.True(theList.Safe().Any());
        }

        [Fact]
        public void SafeListNoElementTest()
        {
            var theList = new List<string>();
            Assert.False(new List<string>().Safe().Any());
        }

        [Fact]
        public void SafeListNullTest()
        {
            List<string> theList = null;
            // ReSharper disable once ExpressionIsAlwaysNull
            Assert.False(theList.Safe().Any());
        }
    }
}