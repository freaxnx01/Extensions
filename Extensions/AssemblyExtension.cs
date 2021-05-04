using System;
using System.IO;
using System.Reflection;

namespace freaxnx01.Extensions
{
    public static class AssemblyExtension
    {
        public static string AssemblyDirectory(this Assembly assembly)
        {
            return Path.GetDirectoryName(assembly.Location);
        }        
    }
}