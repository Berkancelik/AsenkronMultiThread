using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ForEachParalelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long totalyte = 0;

            var files = Directory.GetFiles(@"C:\Users\berka\Desktop\pictures");

            Parallel.For(0, files.Length, (index) =>
            {
                var file = new FileInfo(files[index]);
                Interlocked.Add(ref totalyte, file.Length);
            });

            Console.WriteLine("Total Byte :" +totalyte.ToString());

        }
    }
}
