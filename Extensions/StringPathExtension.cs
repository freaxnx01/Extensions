using System.Diagnostics;
using System.IO;
using System.Net;

namespace freaxnx01.Extensions
{
    public static class StringPathExtension
    {
        public static void ShellExecute(this string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }
            
            Process.Start(new ProcessStartInfo() { UseShellExecute = true, FileName = filePath });
        }
    }
}