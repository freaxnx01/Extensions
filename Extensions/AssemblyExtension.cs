using System;
using System.IO;
using System.Reflection;

namespace freaxnx01.Extensions
{
    public static class AssemblyExtension
    {
        public static string AssemblyDirectory(this Assembly assembly)
        {
            var uri = new UriBuilder(assembly.Location ?? string.Empty);
            var path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }        
    }
}