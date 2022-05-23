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
            Stopwatch sw = new Stopwatch();
            string pictures = @"C:\Users\berka\Desktop\pictures";

            var files = Directory.GetFiles(pictures);

            Parallel.ForEach(files, (item) =>
            {
                Console.WriteLine("thread no:" + Thread.CurrentThread);
                Image img = new Bitmap(item);
                var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);
                thumbnail.Save(Path.Combine(pictures, "thumbnail", Path.GetFileName(item)));
            });
            sw.Stop();
            Console.WriteLine("işlem bitti" + sw.ElapsedMilliseconds);
            sw.Reset();
            sw.Start();
            files.ToList().ForEach(f =>
            {
                Console.WriteLine("thread no:" + Thread.CurrentThread);
                Image img = new Bitmap(f);
                var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);
                thumbnail.Save(Path.Combine(pictures, "thumbnail", Path.GetFileName(f)));
            });
            sw.Stop();
            Console.WriteLine("işlem bitti" + sw.ElapsedMilliseconds);

        }

    }
}
