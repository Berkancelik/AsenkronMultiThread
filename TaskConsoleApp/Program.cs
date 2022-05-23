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
        public static int cachedata { get; set; } = 150;

        private async static Task Main(string[] args)
        {

            var myTask = GetData();
        }

        public static ValueTask<int> GetData()
        {
            return new ValueTask<int>(cachedata);
        }

     



    }


}
