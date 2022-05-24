using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskConsoleApp
{
  
    internal class Program
    {
        private async static Task Main(string[] args)
        {

            int deger;

            Parallel.ForEach(Enumerable.Range(0, 100), (x) =>
            {
                deger = x;
                Console.WriteLine(deger);
            });

        }




    }


}
