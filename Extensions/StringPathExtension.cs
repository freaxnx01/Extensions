using System.Diagnostics;

namespace freaxnx01.Extensions
{
    public static class StringPathExtension
    {
        public static void ShellExecute(this string filePath)
        {
            Process.Start(new ProcessStartInfo() { UseShellExecute = true, FileName = filePath });
        }
    }
}