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
            int total = 0;
            Parallel.ForEach(Enumerable.Range(1, 100).ToList(), () => 0, (x, loop, subTotal) =>
              {
                  subTotal += x;
                  return subTotal;
              }, (y) => Interlocked.Add(ref total, y));
            Console.WriteLine(total);

            Parallel.For(0, 100, () => 0, (x, loop, subTotal) =>
              {
                  subTotal += x;
                  return subTotal;

              },(y) => Interlocked.Add(ref total,y));

        }
    }
}
