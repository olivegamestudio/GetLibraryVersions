using System;
using System.Diagnostics;
using System.IO;

namespace GetLibraryVersions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Library|Version|");
            Console.WriteLine("|-|-|");

            foreach (string fileName in Directory.GetFiles(args[0]))
            {
                if (fileName.EndsWith(".dll") || fileName.EndsWith(".exe"))
                {
                    FileVersionInfo f = FileVersionInfo.GetVersionInfo(fileName);
                    if (!string.IsNullOrEmpty(f.InternalName))
                    {
                        Console.WriteLine($"|{f.InternalName}|{f.FileVersion}|");
                    }
                }
            }
        }
    }
}
