using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using freaxnx01.Extensions;
using Xunit;

namespace Extensions.Test
{
    public class DictionaryExtensionTests
    {
        [Fact]
        public void AddRangeTest()
        {
            var sourceDict = new Dictionary<int, string>() { {111, "111"}, {222, "222"} };
            var targetDict = new Dictionary<int, string>();
            
            targetDict.AddRange(sourceDict);
            
            Assert.Equal(sourceDict.Count, targetDict.Count);
        }
    }
}